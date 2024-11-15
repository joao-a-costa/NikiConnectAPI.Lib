using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemStocks")]
    public class ItemStock : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("matchcode")]
        public object Matchcode { get; set; }

        [JsonProperty("status_id")]
        public object StatusId { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("warehouse_id")]
        public string WarehouseId { get; set; }

        [JsonProperty("stock_unit_id")]
        public object StockUnitId { get; set; }

        [JsonProperty("sale_unit_id")]
        public int SaleUnitId { get; set; }

        [JsonProperty("purchase_unit_id")]
        public int PurchaseUnitId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("min_stock")]
        public int MinStock { get; set; }

        [JsonProperty("reorder_stock")]
        public int ReorderStock { get; set; }

        [JsonProperty("physical")]
        public int Physical { get; set; }

        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("last_in")]
        public object LastIn { get; set; }

        [JsonProperty("last_out")]
        public object LastOut { get; set; }

        [JsonProperty("expected_reception")]
        public object ExpectedReception { get; set; }

        [JsonProperty("expected_delivery")]
        public object ExpectedDelivery { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        [JsonProperty("module_comments")]
        public object ModuleComments { get; set; }

        //[JsonProperty("created_by")]
        //public object CreatedBy { get; set; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public object UpdatedAt { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }
    }

}