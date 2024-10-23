using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Meta
{
    public class Meta
    {
        [JsonProperty("include")]
        public object[] Include { get; set; }
        [JsonProperty("custom")]
        public object[] Custom { get; set; }
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}