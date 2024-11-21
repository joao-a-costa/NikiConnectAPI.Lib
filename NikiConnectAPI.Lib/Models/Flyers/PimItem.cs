using Newtonsoft.Json;
namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class PimItem
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
        public object VersionMatchcode { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("gtin_type_id")]
        public string GtinTypeId { get; set; }

        [JsonProperty("hs_code")]
        public object HsCode { get; set; }

        [JsonProperty("brick_code")]
        public object BrickCode { get; set; }

        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("pim_item_category_id")]
        public object PimItemCategoryId { get; set; }

        [JsonProperty("pim_item_family_id")]
        public object PimItemFamilyId { get; set; }

        [JsonProperty("pim_brand_id")]
        public object PimBrandId { get; set; }

        [JsonProperty("origin_country_id")]
        public object OriginCountryId { get; set; }

        [JsonProperty("pim_unit_id")]
        public object PimUnitId { get; set; }

        [JsonProperty("pim_height")]
        public double PimHeight { get; set; }

        [JsonProperty("pim_width")]
        public double PimWidth { get; set; }

        [JsonProperty("pim_length")]
        public double PimLength { get; set; }

        [JsonProperty("pim_netweight")]
        public double PimNetweight { get; set; }

        [JsonProperty("pim_grossweight")]
        public double PimGrossweight { get; set; }

        [JsonProperty("pim_release_date")]
        public object PimReleaseDate { get; set; }
    }

}