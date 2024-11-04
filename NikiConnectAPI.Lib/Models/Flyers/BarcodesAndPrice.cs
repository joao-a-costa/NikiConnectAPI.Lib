using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class BarcodesAndPrice
    {
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }
}
