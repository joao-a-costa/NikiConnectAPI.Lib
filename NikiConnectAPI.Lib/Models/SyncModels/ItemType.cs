using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;
using System;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemTypes")]
    public class ItemType : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        //[JsonProperty("created_by")]
        //public int CreatedBy { get; set; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("updated_at")]
        //public object UpdatedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }

        [JsonProperty("module_comments")]
        public object ModuleComments { get; set; }
    }
}