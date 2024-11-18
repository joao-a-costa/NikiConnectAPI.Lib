using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class PimItemDetail
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pim_id")]
        public long PimId { get; set; }

        [JsonProperty("sync_id")]
        public object SyncId { get; set; }

        [JsonProperty("version_id")]
        public int VersionId { get; set; }

        [JsonProperty("version_matchcode")]
        public string VersionMatchcode { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("gtin_type_id")]
        public int GtinTypeId { get; set; }

        [JsonProperty("hs_code")]
        public object HsCode { get; set; }

        [JsonProperty("brick_code")]
        public string BrickCode { get; set; }

        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("pim_item_category_id")]
        public object PimItemCategoryId { get; set; }

        [JsonProperty("pim_item_family_id")]
        public int PimItemFamilyId { get; set; }

        [JsonProperty("pim_brand_id")]
        public int PimBrandId { get; set; }

        [JsonProperty("pim_tenant_item_number")]
        public long PimTenantItemNumber { get; set; }

        [JsonProperty("pim_unit_id")]
        public object PimUnitId { get; set; }

        [JsonProperty("pim_height")]
        public int PimHeight { get; set; }

        [JsonProperty("pim_width")]
        public int PimWidth { get; set; }

        [JsonProperty("pim_length")]
        public int PimLength { get; set; }

        [JsonProperty("pim_netweight")]
        public int PimNetweight { get; set; }

        [JsonProperty("pim_grossweight")]
        public int PimGrossweight { get; set; }

        [JsonProperty("pim_release_date")]
        public object PimReleaseDate { get; set; }
    }
}