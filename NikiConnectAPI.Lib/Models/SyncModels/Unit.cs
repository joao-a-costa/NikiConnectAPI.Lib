using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("units")]
    public class Unit : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("decimals")]
        public int Decimals { get; set; }

        [JsonProperty("unit_type_id")]
        public int? UnitTypeId { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("typeable_type_id")]
        public object TypeableTypeId { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        //[JsonProperty("created_at")]
        //public object CreatedAt { get; set; }

        //[JsonProperty("created_by")]
        //public object CreatedBy { get; set; }

        //[JsonProperty("updated_at")]
        //public DateTime UpdatedAt { get; set; }

        //[JsonProperty("updated_by")]
        //public int? UpdatedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        [Editable(true)]
        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }
    }
}