using Newtonsoft.Json;
using System;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    public class Type
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("system")]
        public int System { get; set; }

        [JsonProperty("type")]
        public string TypeName { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public int UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("module_comments")]
        public object ModuleComments { get; set; }

        [JsonProperty("price_list_id")]
        public object PriceListId { get; set; }

        [JsonProperty("recommended_price_line_id")]
        public object RecommendedPriceLineId { get; set; }

        [JsonProperty("cost_center_id")]
        public object CostCenterId { get; set; }

        [JsonProperty("profit_center_id")]
        public object ProfitCenterId { get; set; }

        [JsonProperty("tax_region_id")]
        public object TaxRegionId { get; set; }

        [JsonProperty("payment_type_id")]
        public object PaymentTypeId { get; set; }

        [JsonProperty("payment_condition_id")]
        public object PaymentConditionId { get; set; }

        [JsonProperty("entity_entity_type")]
        public EntityEntityType EntityEntityType { get; set; }
    }
}
