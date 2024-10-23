using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Meta
{
    public class Pagination
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("per_page")]
        public long PerPage { get; set; }
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}
