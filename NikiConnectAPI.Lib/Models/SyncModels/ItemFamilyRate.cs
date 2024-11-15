using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemFamilyRates")]
    public class ItemFamilyRate : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("item_family_id")]
        public int ItemFamilyId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("priceline_id")]
        public int PricelineId { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        //[JsonProperty("created_by")]
        //public int CreatedBy { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public DateTime UpdatedAt { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }
    }

}