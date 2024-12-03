using Newtonsoft.Json;
using System.Collections.Generic;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class FlyerAttachmentDetail
    {
        public string @object { get; set; }
        public int id { get; set; }
        public int attachable_id { get; set; }
        public string attachable_type { get; set; }
        public string original_name { get; set; }
        public string name { get; set; }
        public int favorite { get; set; }
        public List<object> tags { get; set; }
        public bool @public { get; set; }
        public bool image { get; set; }
        public bool video { get; set; }
        public FlyerAttachmentDetailUrl url { get; set; }
        public string mime { get; set; }
        public object meta_data { get; set; }
        public string extension { get; set; }
        public int size { get; set; }
        public int created_by { get; set; }
        public int updated_by { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string awsImageUrl { get; set; }
    }
}