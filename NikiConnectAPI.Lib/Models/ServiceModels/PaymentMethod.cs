using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("paymentMethods")]
    public class PaymentMethod : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [Editable(true)]
        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("bank_check_issued")]
        public bool BankCheckIssued { get; set; }

        [JsonProperty("limit_lower_amount")]
        public double LimitLowerAmount { get; set; }

        [JsonProperty("limit_higher_amount")]
        public double LimitHigherAmount { get; set; }

        [JsonProperty("customer_identification_required")]
        public bool CustomerIdentificationRequired { get; set; }

        [JsonProperty("cash_exchanged")]
        public bool CashExchanged { get; set; }

        [JsonProperty("generate_current_account")]
        public bool GenerateCurrentAccount { get; set; }
    }
}