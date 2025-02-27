﻿using System;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.Data;
using NikiConnectAPI.Lib.Models.Auth;
using System.Collections.Generic;

namespace NikiConnectAPI.Lib.Api
{
    public static class DataFetcher
    {
        public static async Task<DataResponse<T>> Get<T>(string url, Header header,
            bool addSlug = true,
            Dictionary<string, string> additionalParams = null) where T : class
        {
            Exception exception = null;

            try
            {
                var headers = typeof(Header)
                .GetProperties()
                .ToDictionary(
                    prop => ((DisplayNameAttribute)Attribute.GetCustomAttribute(prop, typeof(DisplayNameAttribute)))?.DisplayName ?? prop.Name,
                    prop => prop.GetValue(header)?.ToString()
                );

                if (url.EndsWith("/"))
                    url = url.TrimEnd('/');

                // Get the display name of the class T, fallback to the class name if no DisplayNameAttribute is present
                var entityName = string.Empty;
                if (addSlug)
                    entityName = typeof(T).GetCustomAttributes(typeof(DisplayNameAttribute), false)
                        .FirstOrDefault() is DisplayNameAttribute displayName
                        ? displayName.DisplayName
                        : typeof(T).Name.ToLower(); // fallback to the type name in lowercase

                // Build the query string
                var queryParams = new Dictionary<string, string>();

                if (addSlug)
                    queryParams.Add(App._FieldSlug, entityName);

                // Add additional parameters if provided
                if (additionalParams != null)
                {
                    foreach (var param in additionalParams)
                    {
                        queryParams[param.Key] = param.Value;
                    }
                }

                var queryString = string.Join("&", queryParams
                    .Where(kvp => !string.IsNullOrEmpty(kvp.Value)) // Exclude null or empty values
                    .Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));

                var res = await Utilities.HttpUtility.EXECUTEAsync<DataResult<T>, DataResultError>(url,
                    queryString, App._ApiGet,
                    string.Empty,
                    headers, string.Empty, App._ContentType, 999999999);

                var dataResponse = new DataResponse<T>
                {
                    DataResult = res.Item2,
                    Error = res.Item3
                };

                if (res.Item2 == null && res.Item3 == null && dataResponse.Error == null &&
                    !string.IsNullOrEmpty(res.Item4) && !string.IsNullOrEmpty(res.Item5))
                {
                    dataResponse.Error = new DataResultError
                    {
                        Message = res.Item5
                    };
                }

                return dataResponse;
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return new DataResponse<T>
            {
                Exception = exception
            };
        }


        public static async Task<DataResponseByID<T>> GetByID<T>(string url, Header header,
            long? limit = null, bool addSlug = true) where T : class
        {
            Exception exception = null;

            try
            {
                var headers = typeof(Header)
                .GetProperties()
                .ToDictionary(
                    prop => ((DisplayNameAttribute)Attribute.GetCustomAttribute(prop, typeof(DisplayNameAttribute)))?.DisplayName ?? prop.Name,
                    prop => prop.GetValue(header)?.ToString()
                );

                if (url.EndsWith("/"))
                    url = url.TrimEnd('/');

                // Get the display name of the class T, fallback to the class name if no DisplayNameAttribute is present
                var entityName = string.Empty;
                if (addSlug)
                    entityName = typeof(T).GetCustomAttributes(typeof(DisplayNameAttribute), false)
                        .FirstOrDefault() is DisplayNameAttribute displayName
                        ? displayName.DisplayName
                        : typeof(T).Name.ToLower(); // fallback to the type name in lowercase

                var res = await Utilities.HttpUtility.EXECUTEAsync<DataResultByID<T>, DataResultError>(url,
                    $"{(limit.HasValue ? $"limit={limit}" : string.Empty)}{$"{(addSlug ? $"&{App._FieldSlug}={entityName}" : string.Empty)}"}", App._ApiGet,
                    string.Empty,
                    headers, string.Empty, App._ContentType, 999999999);

                var dataResponse = new DataResponseByID<T>
                {
                    DataResult = res.Item2,
                    Error = res.Item3
                };

                if (res.Item2 == null && res.Item3 == null && dataResponse.Error == null &&
                    !string.IsNullOrEmpty(res.Item4) && !string.IsNullOrEmpty(res.Item5))
                {
                    dataResponse.Error = new DataResultError
                    {
                        Message = res.Item5
                    };
                }

                return dataResponse;
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return new DataResponseByID<T>
            {
                Exception = exception
            };
        }

        public static async Task<DataResponse<T>> Post<T>(string url, Header header, object body,
            long limit = 9223372036854775807, bool addSlug = true) where T : class
        {
            Exception exception = null;

            try
            {
                var headers = typeof(Header)
                .GetProperties()
                .ToDictionary(
                    prop => ((DisplayNameAttribute)Attribute.GetCustomAttribute(prop, typeof(DisplayNameAttribute)))?.DisplayName ?? prop.Name,
                    prop => prop.GetValue(header)?.ToString()
                );

                if (url.EndsWith("/"))
                    url = url.TrimEnd('/');

                // Get the display name of the class T, fallback to the class name if no DisplayNameAttribute is present
                var entityName = typeof(T).GetCustomAttributes(typeof(DisplayNameAttribute), false)
                    .FirstOrDefault() is DisplayNameAttribute displayName
                    ? displayName.DisplayName
                    : typeof(T).Name.ToLower(); // fallback to the type name in lowercase

                var res = await Utilities.HttpUtility.EXECUTEAsync<DataResult<T>,
                    DataResultError>(url,
                    addSlug ? $"{App._FieldSlug}={entityName}" : string.Empty, App._ApiPost,
                    body,
                    headers, string.Empty, App._ContentType, 999999999, System.Net.SecurityProtocolType.Tls12, App._Accept,
                    Enums.RequestFormat.FormData);

                var dataResponse = new DataResponse<T>
                {
                    DataResult = res.Item2,
                    Error = res.Item3
                };

                if (res.Item2 == null && res.Item3 == null && dataResponse.Error == null &&
                    !string.IsNullOrEmpty(res.Item4) && !string.IsNullOrEmpty(res.Item5))
                {
                    dataResponse.Error = new DataResultError
                    {
                        Message = res.Item5
                    };
                }

                return dataResponse;
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return new DataResponse<T>
            {
                Exception = exception
            };
        }


        public static async Task<DataResponse<T>> Patch<T>(string url, Header header, object body,
            long limit = 9223372036854775807, bool addSlug = true) where T : class
        {
            Exception exception = null;

            try
            {
                var headers = typeof(Header)
                .GetProperties()
                .ToDictionary(
                    prop => ((DisplayNameAttribute)Attribute.GetCustomAttribute(prop, typeof(DisplayNameAttribute)))?.DisplayName ?? prop.Name,
                    prop => prop.GetValue(header)?.ToString()
                );

                if (url.EndsWith("/"))
                    url = url.TrimEnd('/');

                // Get the display name of the class T, fallback to the class name if no DisplayNameAttribute is present
                var entityName = typeof(T).GetCustomAttributes(typeof(DisplayNameAttribute), false)
                    .FirstOrDefault() is DisplayNameAttribute displayName
                    ? displayName.DisplayName
                    : typeof(T).Name.ToLower(); // fallback to the type name in lowercase

                var res = await Utilities.HttpUtility.EXECUTEAsync<DataResult<T>,
                    DataResultError>(url,
                    addSlug ? $"{App._FieldSlug}={entityName}" : string.Empty, App._ApiPatch,
                    body,
                    headers, string.Empty, App._ContentType, 999999999, System.Net.SecurityProtocolType.Tls12, App._Accept,
                    Enums.RequestFormat.FormData);

                var dataResponse = new DataResponse<T>
                {
                    DataResult = res.Item2,
                    Error = res.Item3
                };

                if (res.Item2 == null && res.Item3 == null && dataResponse.Error == null &&
                    !string.IsNullOrEmpty(res.Item4) && !string.IsNullOrEmpty(res.Item5))
                {
                    dataResponse.Error = new DataResultError
                    {
                        Message = res.Item5
                    };
                }

                return dataResponse;
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return new DataResponse<T>
            {
                Exception = exception
            };
        }
    }
}