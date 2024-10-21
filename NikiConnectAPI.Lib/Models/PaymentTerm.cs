using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models
{
    [System.ComponentModel.DisplayName("paymentTerms")]
    public class PaymentTerm
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

}