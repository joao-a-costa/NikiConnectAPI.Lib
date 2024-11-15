using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemPriceLines")]
    public class ItemPriceLine : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("price_type_id")]
        public int PriceTypeId { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public object UpdatedAt { get; set; }

        //[JsonProperty("created_by")]
        //public int CreatedBy { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        [JsonProperty("module_comments")]
        public object ModuleComments { get; set; }
    }
}