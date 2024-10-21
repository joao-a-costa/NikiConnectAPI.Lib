using System;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models;
using NikiConnectAPI.Lib.Models.Data;

namespace NikiConnectAPI.Lib.Api
{
    public static class DataFetcher
    {
        public static async Task<DataResponse<T>> Get<T>(string url, Header header, long limit = 9223372036854775807) where T : class
        {
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

                var res = await Utilities.HttpUtility.EXECUTEAsync<DataResult<T>, DataResultError>(url,
                    $"models?limit={limit}&slug={entityName}", App._ApiGet,
                    string.Empty,
                    headers, string.Empty, App._ContentType, 999999999);

                return new DataResponse<T>
                {
                    DataResult = res.Item2,
                    Error = res.Item3
                };
            }
            catch(Exception ex)
            {
                var teste = string.Empty;
            }

            return null;
        }
    }
}