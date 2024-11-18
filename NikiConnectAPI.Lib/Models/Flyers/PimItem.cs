using Newtonsoft.Json;
namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class PimItem
    {
        [JsonProperty("data")]
        public PimItemDetail Data { get; set; }
    }
}