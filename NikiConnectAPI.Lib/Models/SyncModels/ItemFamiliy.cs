using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;
using System;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemFamilies")]
    public class ItemFamily : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("attachment_id")]
        public int AttachmentId { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("used_by_pim")]
        public int UsedByPim { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("lft")]
        public object Lft { get; set; }

        [JsonProperty("rgt")]
        public object Rgt { get; set; }

        [JsonProperty("index")]
        public object Index { get; set; }

        [JsonProperty("depth")]
        public object Depth { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [Editable(true)]
        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        //[JsonProperty("created_by")]
        //public int CreatedBy { get; set; }

        //[JsonProperty("updated_by")]
        //public int UpdatedBy { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public DateTime UpdatedAt { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }

        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }
    }

}