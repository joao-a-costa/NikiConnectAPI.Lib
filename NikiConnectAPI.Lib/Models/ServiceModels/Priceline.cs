using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;
using System;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("priceLines")]
    public class Priceline : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("source_price_id")]
        public string SourcePriceId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [Editable(true)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }
    }

}