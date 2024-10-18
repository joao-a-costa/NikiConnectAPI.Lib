using System;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models;
using NikiConnectAPI.Lib.Models.Auth;

namespace NikiConnectAPI.Lib.Api
{
    public static class Country
    {
        private const string _Slug = "countries";

        public static async Task<Tuple<DataResult<Models.Country>, DataResultError>> Get(string url, Header header, long limit = 9223372036854775807)
        {
            var headers = typeof(Header)
                   .GetProperties()
                   .ToDictionary(
                       prop => ((DisplayNameAttribute)Attribute.GetCustomAttribute(prop, typeof(DisplayNameAttribute)))?.DisplayName ?? prop.Name,
                       prop => prop.GetValue(header)?.ToString()
                   );

            if (url.EndsWith("/"))
                url = url.TrimEnd('/');

            var res = await Utilities.HttpUtility.EXECUTEAsync<DataResult<Models.Country>, DataResultError>(url,
                $"models?limit={9223372036854775807}&slug={_Slug}", "GET",
                string.Empty,
                headers, string.Empty, "application/x-www-form-urlencoded", 999999999);

            return Tuple.Create(res.Item2, res.Item3); // Return token and error
        }
    }
}
