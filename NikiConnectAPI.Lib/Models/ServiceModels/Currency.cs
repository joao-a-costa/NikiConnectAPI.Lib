using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("currencies")]
    public class Currency : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("symbol_left")]
        public string SymbolLeft { get; set; }

        [JsonProperty("symbol_right")]
        public string SymbolRight { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("decimal_place")]
        public int DecimalPlace { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("rounding")]
        public object Rounding { get; set; }

        [JsonProperty("decimal_point")]
        public string DecimalPoint { get; set; }

        [JsonProperty("thousand_point")]
        public string ThousandPoint { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        //[JsonProperty("updated_at")]
        //public DateTime? UpdatedAt { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public DateTime? DeletedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        [Editable(true)]
        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }
    }


}