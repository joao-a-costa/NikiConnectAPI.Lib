
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NikiConnectAPI.Lib.Models.Data
{
    public class DataResultByID<T> where T : class
    {
        [JsonProperty("data")]
        public T Data { get; set; }
        [JsonProperty("meta")]
        public Meta.Meta Meta { get; set; }
    }
}
