using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("documentDetails")]
    public class DocumentDetail : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("transaction_uuid")]
        public string TransactionUuid { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("address_id")]
        public int AddressId { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("warehouse_destination_id")]
        public object WarehouseDestinationId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [Editable(true)]
        [JsonProperty("observations")]
        public string Observations { get; set; }

        [JsonProperty("unit_code")]
        public string UnitCode { get; set; }

        [JsonProperty("unit_code_2")]
        public object UnitCode2 { get; set; }

        [JsonProperty("unit_code_3")]
        public object UnitCode3 { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("quantity_2")]
        public object Quantity2 { get; set; }

        [JsonProperty("quantity_3")]
        public object Quantity3 { get; set; }

        [JsonProperty("coefficient")]
        public int Coefficient { get; set; }

        [JsonProperty("coefficient_2")]
        public object Coefficient2 { get; set; }

        [JsonProperty("coefficient_3")]
        public object Coefficient3 { get; set; }

        [JsonProperty("last_cost_price")]
        public double LastCostPrice { get; set; }

        [JsonProperty("average_cost_price")]
        public double AverageCostPrice { get; set; }

        [JsonProperty("original_unit_price")]
        public double OriginalUnitPrice { get; set; }

        [JsonProperty("original_tax_included_price")]
        public double OriginalTaxIncludedPrice { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("tax_included_price")]
        public double TaxIncludedPrice { get; set; }

        [JsonProperty("tax_id")]
        public int TaxId { get; set; }

        [JsonProperty("tax_percentage")]
        public int TaxPercentage { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }

        [JsonProperty("discount_percentage")]
        public int DiscountPercentage { get; set; }

        [JsonProperty("discount_amount")]
        public int DiscountAmount { get; set; }

        [JsonProperty("total_gross_amount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("total_net_discount")]
        public int TotalNetDiscount { get; set; }

        [JsonProperty("transaction_total_net_discount")]
        public int TransactionTotalNetDiscount { get; set; }

        [JsonProperty("total_net_amount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("total_tax_amount")]
        public double TotalTaxAmount { get; set; }

        [JsonProperty("total_additional_tax_amount")]
        public int TotalAdditionalTaxAmount { get; set; }

        [JsonProperty("total_additional_cost_amount")]
        public int TotalAdditionalCostAmount { get; set; }

        [JsonProperty("total_tax_included_amount")]
        public double TotalTaxIncludedAmount { get; set; }

        [JsonProperty("warehouse_origin_id")]
        public int WarehouseOriginId { get; set; }

        [JsonProperty("stock_date")]
        public string StockDate { get; set; }

        [JsonProperty("detail_closed")]
        public int DetailClosed { get; set; }

        [JsonProperty("sync")]
        public bool Sync { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("closed_by")]
        public object ClosedBy { get; set; }

        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
    }
}