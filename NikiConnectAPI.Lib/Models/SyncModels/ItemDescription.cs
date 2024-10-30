using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemDescriptions")]
    public class ItemDescription : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [Editable(true)]
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

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