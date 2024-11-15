using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("itemPrices")]
    public class ItemPrice : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("price_line_id")]
        public int PriceLineId { get; set; }

        [JsonProperty("currency_id")]
        public int CurrencyId { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("tax_included_price")]
        public double TaxIncludedPrice { get; set; }

        [JsonProperty("fixed_profit_rate")]
        public int FixedProfitRate { get; set; }

        [JsonProperty("tax_rate")]
        public int TaxRate { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        //[JsonProperty("created_by")]
        //public object CreatedBy { get; set; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get; set; }

        //[JsonProperty("updated_by")]
        //public object UpdatedBy { get; set; }

        //[JsonProperty("updated_at")]
        //public object UpdatedAt { get; set; }

        //[JsonProperty("deleted_by")]
        //public object DeletedBy { get; set; }

        //[JsonProperty("deleted_at")]
        //public object DeletedAt { get; set; }
    }

}