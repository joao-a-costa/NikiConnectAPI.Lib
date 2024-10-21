using Newtonsoft.Json;
using System;

namespace NikiConnectAPI.Lib.Models
{
    [System.ComponentModel.DisplayName("tenantUsers")]
    public class TenantUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("salesman_id")]
        public string SalesmanId { get; set; }

        [JsonProperty("customer_group_id")]
        public string CustomerGroupId { get; set; }
    }
}