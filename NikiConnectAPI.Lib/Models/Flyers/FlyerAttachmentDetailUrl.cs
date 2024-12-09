using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class FlyerAttachmentDetailUrl
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }
}