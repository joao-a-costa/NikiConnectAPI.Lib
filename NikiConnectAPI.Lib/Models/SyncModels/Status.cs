using System;
using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    public class Status
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("lft")]
        public object Lft { get; set; }

        [JsonProperty("rgt")]
        public object Rgt { get; set; }

        [JsonProperty("depth")]
        public object Depth { get; set; }

        [JsonProperty("index")]
        public object Index { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("system")]
        public int System { get; set; }
    }
}
