using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models
{
    public class DataResultError
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("errors")]
        public object[] Errors { get; set; }
    }
}
