using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class FlyerItemResult
    {
        //[JsonProperty("object")]
        //public string Object { get; set; }

        //[JsonProperty("id")]
        //public int Id { get; set; }

        [JsonProperty("flyer_id")]
        public string FlyerId { get; set; }

        [JsonProperty("external_flyer_id")]
        public string ExternalFlyerId { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("filial_id")]
        public string FilialId { get; set; }

        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        //[JsonProperty("company_name")]
        //public string CompanyName { get; set; }

        [JsonProperty("filial_name")]
        public string FilialName { get; set; }

        [JsonProperty("exist_in_campaign")]
        public bool ExistInCampaign { get; set; }

        //[JsonProperty("created_by")]
        //public int CreatedBy { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("created_at")]
        //public string CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public string UpdatedAt { get; set; }
    }
}
