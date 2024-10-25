using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Helpers;
using NikiConnectAPI.Lib.Interfaces;
using NikiConnectAPI.Lib.Models.Auth;
using NikiConnectAPI.Lib.Models.Data;
using NikiConnectAPI.Test.Utilities;

namespace NikiConnectAPI.Test.Api
{
    public class BaseTester
    {
        #region "Constants"

        private const string _TokenFilePath = "tokenInfo.json";

        #endregion

        #region "Properties"

        public string AccessToken { get; set; }
        public Header Header { get; set; }

        #endregion

        #region "Private Methods"

        protected static async Task<string> GetAccessTokenAsync()
        {
            var tokenFilePath = _TokenFilePath;
            var accessToken = string.Empty;
            var app = new App();
            Token token = null;

            // Try to read the token and expiration time from the file
            if (File.Exists(tokenFilePath))
            {
                token = JsonConvert.DeserializeObject<Token>(File.ReadAllText(tokenFilePath));

                // Check if the token is still valid
                if (token != null && DateTime.UtcNow < token.ExpireDate)
                    accessToken = token.AccessToken;
            }

            if (string.IsNullOrEmpty(accessToken))
            {
                // If token is not available or expired, fetch a new one
                var tokenResponse = await Lib.Api.Auth.CreateToken(
                    $"{app.Url}{app.UrlVersion}{app.UrlToken}",
                    app.UrlUserAgent,
                    app.ClientID,
                    app.ClientSecret
                );

                // Cache the token and expiration in a file
                if (tokenResponse?.Token?.AccessToken != null)
                {
                    var newTokenInfoJson = JsonConvert.SerializeObject(tokenResponse.Token);
                    File.WriteAllText(tokenFilePath, newTokenInfoJson);

                    accessToken = tokenResponse.Token.AccessToken;
                }
            }

            return accessToken;
        }

        protected Header CreateHeader(string AccessToken)
        {
            var app = new App();

            return new Header
            {
                Authorization = $"Bearer {AccessToken}",
                XCompanyID = app.XCompany,
                XTenant = app.XTenant,
                XVersion = app.XVersion
            };
        }

        protected async Task<DataResponse<T>> GetDataAsync<T>() where T : class
        {
            var app = new App();

            if (Header == null) return null;
            var res = await Lib.Api.DataFetcher.Get<T>($"{app.Url}{app.UrlVersion}{app.UrlRemoteApiClientModels}",
                Header,
                app.Limit);

            if (res?.Exception != null)
                Assert.Fail(res.Exception.Message);
            return res;
        }

        protected async Task<DataResponse<T>> PostDataAsync<T>(object data) where T : class
        {
            var app = new App();

            if (Header == null) return null;
            var res = await Lib.Api.DataFetcher.Post<T>($"{app.Url}{app.UrlVersion}{app.UrlRemoteApiClientUpsert}",
                Header,
                data);
            return res;
        }

        protected async Task PatchEntity<T>() where T : class, IBaseModel
        {
            var app = new App();
            var resOperation = false;

            // Step 1: Get data
            var resGet = await GetDataAsync<T>();

            if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
            {
                // Step 2: Select a random item from the data list
                var item = resGet.DataResult.Data[new Random().Next(resGet.DataResult.Data.Count)];

                // Step 3: Get the list of random primitive properties
                var itemProperties = RandomPropertyChanger.GetRandomPropertiesWithAttributes(item, App.AttributeTypes);

                // Dictionary to store original and new values for each property
                var originalAndNewValues = new Dictionary<PropertyInfo, (object originalValue, object originalValueNew)>();

                if (itemProperties != null && itemProperties.Count > 0)
                {
                    // Step 4: For each property, store original values and modify the item
                    foreach (var itemProperty in itemProperties)
                    {
                        var originalValue = RandomPropertyChanger.GetPrimitiveValue(itemProperty, item);
                        var originalValueNew = $"{originalValue}{DateTime.Now.ToString(app.DateFormat)}";

                        // Store original and new values in the dictionary
                        originalAndNewValues[itemProperty] = (originalValue, originalValueNew);

                        // Change the property to a new value
                        RandomPropertyChanger.SetPrimitiveProperty(itemProperty, item, originalValueNew);
                    }

                    // Step 5: Post the updated item after modifying all properties
                    var res = await PostDataAsync<T>(DynamicToStringHelper.ToDictionary(item));

                    if (res?.DataResult != null)
                    {
                        // Step 6: Re-fetch the data
                        resGet = await GetDataAsync<T>();

                        if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
                        {
                            // Step 7: Find the updated item based on its ID
                            var itemFound = resGet.DataResult.Data.Find(f => f.Id == item.Id);

                            if (itemFound != null)
                            {
                                // Step 8: For each property, check the updated value and verify the changes
                                foreach (var kvp in originalAndNewValues)
                                {
                                    var itemProperty = kvp.Key;
                                    var (originalValue, originalValueNew) = kvp.Value;

                                    var newValue = RandomPropertyChanger.GetPrimitiveValue(itemProperty, itemFound);

                                    // Step 9: Verify if the original value and new value are different
                                    resOperation = originalValue?.ToString() != newValue.ToString() && originalValueNew.ToString() == newValue.ToString();

                                    Assert.AreNotEqual(originalValue?.ToString(), newValue.ToString(), $"Property '{itemProperty.Name}' was not updated correctly.");

                                    if (!resOperation)
                                        break; // If one property fails, stop further processing
                                }

                                if (resOperation)
                                {
                                    // Step 10: Change back all properties to their original values
                                    foreach (var kvp in originalAndNewValues)
                                    {
                                        RandomPropertyChanger.SetPrimitiveProperty(kvp.Key, item, kvp.Value.originalValue);
                                    }

                                    // Step 11: Post the item with original values restored
                                    res = await PostDataAsync<T>(DynamicToStringHelper.ToDictionary(item));
                                    resOperation = res?.DataResult != null;
                                }
                            }
                            else
                                Assert.IsTrue(resOperation, "Item was not found after update.");
                        }
                    }
                    else if (res?.Error != null)
                        Assert.Fail(res.Error.Message);
                }
            }
            else if (resGet?.Exception != null)
                Assert.Fail(resGet.Exception.Message);


            // Final assertion to ensure the operation was successful
            Assert.IsTrue(resOperation, "No changes were detected in the property values.");
        }

        protected async Task PostEntity<T>() where T : class, IBaseModel
        {
            var app = new App();
            var resOperation = false;

            // Step 1: Get data
            var resGet = await GetDataAsync<T>();

            if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
            {
                // Step 2: Select a random item from the data list
                var item = resGet.DataResult.Data[new Random().Next(resGet.DataResult.Data.Count)];

                item.Id = 0;
                RandomPropertyChanger.SetPrimitiveProperty(item.GetType().GetProperty(App._FieldExternalId), item, Guid.NewGuid().ToString());

                // Step 3: Get the list of random primitive properties
                var itemProperties = RandomPropertyChanger.GetRandomPropertiesWithAttributes(item, App.AttributeTypes);

                // Dictionary to store original and new values for each property
                var originalAndNewValues = new Dictionary<PropertyInfo, (object originalValue, object originalValueNew)>();

                if (itemProperties != null && itemProperties.Count > 0)
                {
                    // Step 4: For each property, store original values and modify the item
                    foreach (var itemProperty in itemProperties)
                    {
                        var originalValue = RandomPropertyChanger.GetPrimitiveValue(itemProperty, item);
                        var originalValueNew = $"{originalValue}{DateTime.Now.ToString(app.DateFormat)}";

                        // Store original and new values in the dictionary
                        originalAndNewValues[itemProperty] = (originalValue, originalValueNew);

                        // Change the property to a new value
                        RandomPropertyChanger.SetPrimitiveProperty(itemProperty, item, originalValueNew);
                    }

                    // Step 5: Post the updated item after modifying all properties
                    var res = await PostDataAsync<T>(DynamicToStringHelper.ToDictionary(item));

                    if (res?.DataResult != null)
                    {
                        // Step 6: Re-fetch the data
                        resGet = await GetDataAsync<T>();

                        if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
                        {
                            // Step 7: Find the updated item based on its ID
                            var externalId = RandomPropertyChanger.GetPrimitiveValue(item.GetType().GetProperty(App._FieldExternalId), item)?.ToString();
                            var itemFound = resGet.DataResult.Data.Find(f =>
                                RandomPropertyChanger.GetPrimitiveValue(f.GetType().GetProperty(App._FieldExternalId), f)?.ToString() == externalId);

                            if (itemFound != null)
                            {
                                // Step 8: For each property, check the updated value and verify the changes
                                foreach (var kvp in originalAndNewValues)
                                {
                                    var itemProperty = kvp.Key;
                                    var (originalValue, originalValueNew) = kvp.Value;

                                    var newValue = RandomPropertyChanger.GetPrimitiveValue(itemProperty, itemFound);

                                    // Step 9: Verify if the original value and new value are different
                                    resOperation = originalValue?.ToString() != newValue.ToString() && originalValueNew.ToString() == newValue.ToString();

                                    Assert.AreNotEqual(originalValue?.ToString(), newValue.ToString(), $"Property '{itemProperty.Name}' was not updated correctly.");

                                    if (!resOperation)
                                        break; // If one property fails, stop further processing
                                }
                            }
                            else
                                Assert.IsTrue(resOperation, "Item was not found after insert.");
                        }
                    }
                    else if (res?.Error != null)
                        Assert.Fail(res.Error.Message);
                }
            }
            else if (resGet?.Exception != null)
                Assert.Fail(resGet.Exception.Message);

            // Final assertion to ensure the operation was successful
            Assert.IsTrue(resOperation, "No changes were detected in the property values.");
        }

        #endregion
    }
}
