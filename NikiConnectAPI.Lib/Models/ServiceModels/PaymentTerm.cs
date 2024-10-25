using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("paymentTerms")]
    public class PaymentTerm : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; } = 1;

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [Editable(true)]
        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

}