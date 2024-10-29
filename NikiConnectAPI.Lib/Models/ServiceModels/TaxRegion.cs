using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;
using System;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("taxRegions")]
    public class TaxRegion : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;

        [JsonProperty("group_id")]
        public int GroupId { get; set; } = 1;

        [JsonProperty("typeable_type_id")]
        public int? TypeableTypeId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [Editable(true)]
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}