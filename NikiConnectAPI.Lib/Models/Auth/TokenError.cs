using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Auth
{
    /// <summary>
    /// Represents the token returned by the Niki API with error
    /// </summary>
    public class TokenError
    {
        /// <summary>
        /// The error
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
        /// <summary>
        /// The error description
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
        /// <summary>
        /// The message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
