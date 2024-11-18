using System.Collections.Generic;
using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class FlyerItem
    {
        [JsonProperty("data")]
        public List<FlyerItemDetail> Data { get; set; }
    }
}
