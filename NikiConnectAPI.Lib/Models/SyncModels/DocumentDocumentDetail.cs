using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    public class DocumentDocumentDetail
    {
        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }
}