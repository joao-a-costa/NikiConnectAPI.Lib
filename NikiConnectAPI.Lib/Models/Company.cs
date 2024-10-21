using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models
{
    [System.ComponentModel.DisplayName("companies")]
    public class Company
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("CompanyID")]
        public int CompanyID { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }
    }
}