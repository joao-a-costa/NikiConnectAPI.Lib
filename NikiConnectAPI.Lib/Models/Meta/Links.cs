using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Meta
{
    public class Links
    {
        [JsonProperty("next")]
        public string Next { get; set; }
    }
}