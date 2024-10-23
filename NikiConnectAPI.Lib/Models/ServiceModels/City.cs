using System;
using System.ComponentModel;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [DisplayName("cities")]
    public class City : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("state_id")]
        public int? StateId { get; set; }

        [JsonProperty("iso_3166_2")]
        public string Iso31662 { get; set; }

        [JsonProperty("iso_3166_3")]
        public string Iso31663 { get; set; }

        [Editable(true)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("geography")]
        public string Geography { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }
}