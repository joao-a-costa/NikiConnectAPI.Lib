using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NikiConnectAPI.Lib.Utilities;
using NikiConnectAPI.Lib.Models.Auth;

namespace NikiConnectAPI.Lib.Api
{
    public static class Auth
    {
        /// <summary>
        /// Get the token from the Niki API
        /// </summary>
        /// <param name="url">The URL of the Niki API</param>
        /// <param name="clientID">The client ID</param>
        /// <param name="clientSecret">The client secret</param>
        /// <param name="userAgent">The User-Agent header</param>
        /// <returns>The token</returns>
        public static async Task<Tuple<Token, TokenError>> CreateToken(string url, string userAgent, string clientID, string clientSecret)
        {
            var authorization = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientID}:{clientSecret}"));

            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "Authorization", $"Basic {authorization}" }
            };

            if (url.EndsWith("/"))
                url = url.TrimEnd('/');

            var res = await HttpUtility.EXECUTEAsync<Token, TokenError>(
                url,
                "",
                "POST",
                "grant_type=api-client-credentials",
                headers,
                userAgent,
                "application/x-www-form-urlencoded",
                999999999
            );

            return Tuple.Create(res.Item2, res.Item3); // Return token and error
        }
    }
}
