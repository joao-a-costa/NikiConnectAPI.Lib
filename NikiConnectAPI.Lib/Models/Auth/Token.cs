using System;
using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Auth
{
    /// <summary>
    /// Represents the token returned by the Niki API
    /// </summary>
    public class Token
    {
        /// <summary>
        /// The type of token
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        /// <summary>
        /// The expiration time of the token
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        /// <summary>
        /// The access token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// The refresh token
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public DateTime ExpireDate => DateTime.Now.AddSeconds(ExpiresIn);
    }
}
