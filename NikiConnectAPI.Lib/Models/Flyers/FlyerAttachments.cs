using System.Collections.Generic;
using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class FlyerAttachments
    {
        [JsonProperty("data")]
        public List<FlyerAttachmentDetail> Data { get; set; }
    }
}
