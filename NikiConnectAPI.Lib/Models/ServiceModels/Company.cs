﻿using Newtonsoft.Json;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.ServiceModels
{
    [System.ComponentModel.DisplayName("companies")]
    public class Company : IBaseModel
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