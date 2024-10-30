using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("countries")]
    public class Country : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;
        [JsonProperty("group_id")]
        public int GroupId { get; set; } = 1;
        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("primary_language")]
        public string PrimaryLanguage { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("capital_id")]
        public object CapitalId { get; set; }

        [JsonProperty("citizenship")]
        public string Citizenship { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currency_id")]
        public object CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_sub_unit")]
        public string CurrencySubUnit { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("iso_3166_2")]
        public string Iso31662 { get; set; }

        [JsonProperty("iso_3166_3")]
        public string Iso31663 { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("nationalIDCode")]
        public object NationalIDCode { get; set; }

        [JsonProperty("SEPA_area")]
        public bool SEPAArea { get; set; }

        [JsonProperty("EU_entry_date")]
        public object EUEntryDate { get; set; }

        [JsonProperty("EU_withdrawal_date")]
        public object EUWithdrawalDate { get; set; }

        [JsonProperty("date_format")]
        public object DateFormat { get; set; }

        [JsonProperty("internet_TLD")]
        public string InternetTLD { get; set; }

        [JsonProperty("EEC_membership")]
        public bool EECMembership { get; set; }

        [Editable(true)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("sub_region_code")]
        public string SubRegionCode { get; set; }

        [JsonProperty("eea")]
        public bool Eea { get; set; }

        [JsonProperty("calling_code")]
        public string CallingCode { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("postal_code_validation")]
        public string PostalCodeValidation { get; set; }

        [JsonProperty("postal_code_format")]
        public string PostalCodeFormat { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        //[JsonProperty("updated_at")]
        //public DateTime? UpdatedAt { get; set; }

        //[JsonProperty("updated_by")]
        //public int? UpdatedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public DateTime DeletedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public int? DeletedBy { get; set; }

        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }

        [Editable(true)]
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }
}