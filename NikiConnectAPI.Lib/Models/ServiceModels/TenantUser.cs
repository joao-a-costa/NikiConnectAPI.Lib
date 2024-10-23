using Newtonsoft.Json;
using NikiConnectAPI.Lib.Interfaces;
using System;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("tenantUsers")]
    public class TenantUser : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("salesman_id")]
        public string SalesmanId { get; set; }

        [JsonProperty("customer_group_id")]
        public string CustomerGroupId { get; set; }
    }
}