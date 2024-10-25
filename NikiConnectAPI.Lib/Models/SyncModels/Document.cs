using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("documents")]
    public class Document : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [Editable(true)]
        [JsonProperty("header_message")]
        public string HeaderMessage { get; set; }

        [JsonProperty("footer_message")]
        public string FooterMessage { get; set; }

        [JsonProperty("unload_at")]
        public DateTime UnloadAt { get; set; }

        [JsonProperty("load_at")]
        public DateTime LoadAt { get; set; }

        [JsonProperty("payment_at")]
        public DateTime PaymentAt { get; set; }

        [JsonProperty("discount_percent")]
        public double DiscountPercent { get; set; }

        [JsonProperty("entity_account_id")]
        public int EntityAccountId { get; set; }

        [JsonProperty("currency_code")]
        public object CurrencyCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("load_street")]
        public string LoadStreet { get; set; }

        [JsonProperty("load_city")]
        public object LoadCity { get; set; }

        [JsonProperty("load_postal_code")]
        public string LoadPostalCode { get; set; }

        [JsonProperty("load_country_code")]
        public string LoadCountryCode { get; set; }

        [JsonProperty("unload_street")]
        public string UnloadStreet { get; set; }

        [JsonProperty("unload_city")]
        public object UnloadCity { get; set; }

        [JsonProperty("unload_postal_code")]
        public string UnloadPostalCode { get; set; }

        [JsonProperty("unload_country_code")]
        public string UnloadCountryCode { get; set; }

        [JsonProperty("warehouse_original_id")]
        public int WarehouseOriginalId { get; set; }

        [JsonProperty("salesman_id")]
        public string SalesmanId { get; set; }

        [JsonProperty("carrier_id")]
        public object CarrierId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("external_account_id")]
        public int ExternalAccountId { get; set; }

        [JsonProperty("documentDetails")]
        public List<DocumentDocumentDetail> DocumentDetails { get; set; }
    }
}