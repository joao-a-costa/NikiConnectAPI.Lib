using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("addresses")]
    public class Address : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("address_type_id")]
        public int AddressTypeId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [Editable(true)]
        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        [JsonProperty("street_number")]
        public object StreetNumber { get; set; }

        [JsonProperty("gln")]
        public object Gln { get; set; }

        [JsonProperty("state_id")]
        public int? StateId { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("lat")]
        public double? Lat { get; set; }

        [JsonProperty("lng")]
        public object Lng { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }

        [JsonProperty("entity_type_id")]
        public int EntityTypeId { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
    }
}