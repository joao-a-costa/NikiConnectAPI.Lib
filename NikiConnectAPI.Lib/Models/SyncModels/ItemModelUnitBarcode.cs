using System;
using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("item_model_unit_barcode")]
    public class ItemModelUnitBarcode
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("barcode_type_id")]
        public int BarcodeTypeId { get; set; }

        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("coefficient")]
        public double Coefficient { get; set; }

        [JsonProperty("gross_weight")]
        public double GrossWeight { get; set; }

        [JsonProperty("net_weight")]
        public double NetWeight { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public int UpdatedBy { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }
    }
}
