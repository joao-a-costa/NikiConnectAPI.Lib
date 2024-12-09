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
        public static Header Header { get; set; }

        #endregion

        #region "Private Methods"

        private static PropertyInfo GetFirstProperty<T>(T item, List<string> propertiesToSearch)
        {
            PropertyInfo propertyInfo = null;

            foreach (var property in propertiesToSearch)
            {
                propertyInfo = item.GetType().GetProperty(property);

                if (propertyInfo != null)
                    break;
            }

            return propertyInfo;
        }

        protected static async Task<string> GetAccessTokenAsync()
        {
            var tokenFilePath = _TokenFilePath;
            var accessToken = string.Empty;
            var app = new App();
            Token token = null;

            //// Try to read the token and expiration time from the file
            //if (File.Exists(tokenFilePath))
            //{
            //    token = JsonConvert.DeserializeObject<Token>(File.ReadAllText(tokenFilePath));

            //    // Check if the token is still valid
            //    if (token != null && DateTime.UtcNow < token.ExpireDate)
            //        accessToken = token.AccessToken;
            //}

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

        private static async Task<DataResponse<T>> PostDataAsync<T>(object data) where T : class
        {
            var app = new App();

            if (Header == null) return null;
            var res = await Lib.Api.DataFetcher.Post<T>($"{app.Url}{app.UrlVersion}{app.UrlRemoteApiClientPost}",
                Header,
                data);
            return res;
        }

        private static async Task PostEntity<T>(List<string> listFieldsNotToInclude)
            where T : class, IBaseModel
        {
            var app = new App();
            var resOperation = false;

            // Step 1: Get data
            var resGet = await GetDataModelsAsync<T>();

            if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
            {
                // Step 2: Select a random item from the data list
                var item = resGet.DataResult.Data[new Random().Next(resGet.DataResult.Data.Count)];
                var itemPropertyToChange = GetFirstProperty(item, App._FieldExternalId);

                if (itemPropertyToChange == null)
                    Assert.Fail($"Property '{App._FieldExternalId}' not found in the model.");

                item.Id = 0;
                RandomPropertyChanger.SetPrimitiveProperty(itemPropertyToChange, item, Guid.NewGuid().ToString());

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
                    var res = await PostDataAsync<T>(DynamicToStringHelper.ToDictionary(item, listFieldsNotToInclude));

                    if (res?.DataResult != null)
                    {
                        // Step 6: Re-fetch the data
                        resGet = await GetDataModelsAsync<T>();

                        if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
                        {
                            // Step 7: Find the updated item based on its ID
                            var externalId = RandomPropertyChanger.GetPrimitiveValue(itemPropertyToChange, item)?.ToString();
                            var itemFound = resGet.DataResult.Data.Find(f =>
                                RandomPropertyChanger.GetPrimitiveValue(itemPropertyToChange, f)?.ToString() == externalId);

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
            Assert.IsTrue(resOperation, "Post entity.");
        }

        protected static async Task DeleteEntity<T>(List<string> listFieldsToInclude)
            where T : class, IBaseModel
        {
            var app = new App();
            var resOperation = false;

            // Step 1: Get data
            var resGet = await GetDataModelsAsync<T>();

            if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
            {
                // Step 2: Select a random item from the data list
                var item = resGet.DataResult.Data[new Random().Next(resGet.DataResult.Data.Count)];

                // Step 3: Convert the item to a dictionary with fields to include
                var res = await PostDataAsync<T>(DynamicToStringHelper.ToDictionary(item, listFieldsToInclude: listFieldsToInclude));

                if (res?.DataResult != null)
                {
                    // Step 5: Re-fetch the data
                    resGet = await GetDataModelsAsync<T>();

                    if (resGet?.DataResult != null && resGet.DataResult?.Data?.Count > 0)
                    {
                        // Step 6: Find the updated item based on its ID
                        var itemFound = resGet.DataResult.Data.Find(f => f.Id == item.Id);
                        resOperation = itemFound == null;

                        if (resOperation)
                        {
                            Assert.IsTrue(resOperation, "Item was not found after delete.");
                        }
                        else
                            Assert.IsTrue(resOperation, "Item was found after insert.");
                    }
                }
                else if (res?.Error != null)
                    Assert.Fail(res.Error.Message);
            }
            else if (resGet?.Exception != null)
                Assert.Fail(resGet.Exception.Message);

            // Final assertion to ensure the operation was successful
            Assert.IsTrue(resOperation, "Delete entity.");
        }

        #region "Get"

        protected static async Task<DataResponse<T>> GetDataAsync<T>(string url, bool addSlug = true,
            Dictionary<string, string> additionalParams = null) where T : class
        {
            if (Header == null) return null;
            var res = await Lib.Api.DataFetcher.Get<T>(url,
                Header,
                addSlug, additionalParams);

            if (res?.Exception != null)
                Assert.Fail(res.Exception.Message);

            return res;
        }

        protected static async Task<DataResponseByID<T>> GetDataByIDAsync<T>(string url, long? limit = null, bool addSlug = true) where T : class
        {
            if (Header == null) return null;
            var res = await Lib.Api.DataFetcher.GetByID<T>(url,
                Header,
                limit, addSlug);

            if (res?.Exception != null)
                Assert.Fail(res.Exception.Message);

            return res;
        }

        protected static async Task<DataResponse<T>> GetDataModelsAsync<T>() where T : class
        {
            var app = new App();

            return await GetDataAsync<T>($"{app.Url}{app.UrlVersion}{app.UrlRemoteApiClientGet}",
                additionalParams: new Dictionary<string, string>()
                {
                    { "limit", $"{app.Limit}" }
                }
            );
        }

        protected static async Task<DataResponseByID<T>> GetDataModelsByIDAsync<T>(string id) where T : class
        {
            var app = new App();

            return await GetDataByIDAsync<T>($"{app.Url}{app.UrlVersion}{app.UrlRemoteApiClientGetByID}/{id}", app.Limit);
        }

        protected static async Task<DataResponseByID<T>> GetDataModelsByFieldsAsync<T>(string id) where T : class
        {
            var app = new App();

            return await GetDataByIDAsync<T>($"{app.Url}{app.UrlVersion}{app.UrlRemoteApiClientGetByID}/{id}", app.Limit);
        }

        #region "Flyers"

        protected static async Task<DataResponse<T>> GetDataFlyersAsync<T>() where T : class
        {
            var app = new App();

            return await GetDataAsync<T>($"{app.Url}{app.UrlVersion}{app.UrlFlyers}{app.UrlFlyersInclude}", addSlug: false);
        }

        protected static async Task<DataResponseByID<T>> GetDataFlyersByIDAsync<T>(string id) where T : class
        {
            var app = new App();

            return await GetDataByIDAsync<T>($"{app.Url}{app.UrlVersion}{app.UrlFlyers}/{id}{app.UrlFlyersInclude}", null, false);
        }

        protected static async Task<DataResponse<T>> GetDataFlyersByDateAsync<T>(DateTime? startAt, DateTime? finishAt) where T : class
        {
            var app = new App();

            var queryParameters = new List<string>();
            if (startAt.HasValue)
                queryParameters.Add($"start_at={startAt.Value:yyyy-MM-dd}");
            if (finishAt.HasValue)
                queryParameters.Add($"finish_at={finishAt.Value:yyyy-MM-dd}");

            // Combine query parameters into a single query string
            var queryString = string.Join("&", queryParameters);

            // Construct the final URL
            var url = $"{app.Url}{app.UrlVersion}{app.UrlFlyers}{app.UrlFlyersInclude}";
            if (!string.IsNullOrEmpty(queryString))
                url += $"&{queryString}";

            return await GetDataAsync<T>(url, false);
        }

        #endregion

        #endregion

        protected static async Task PatchEntity<T>() where T : class, IBaseModel
        {
            var app = new App();
            var resOperation = false;

            // Step 1: Get data
            var resGet = await GetDataModelsAsync<T>();

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
                        resGet = await GetDataModelsAsync<T>();

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
            Assert.IsTrue(resOperation, "Patch entity.");
        }

        protected static async Task PostEntity<T>() where T : class, IBaseModel
        {
            await PostEntity<T>(App.ListFieldsNotToInclude);
        }

        #endregion
    }
}
