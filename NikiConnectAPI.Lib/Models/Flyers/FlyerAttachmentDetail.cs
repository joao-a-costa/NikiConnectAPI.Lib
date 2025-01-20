using Newtonsoft.Json;
using System.Collections.Generic;

namespace NikiConnectAPI.Lib.Models.Flyers
{
    public class FlyerAttachmentDetail
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("attachable_id")]
        public int AttachableId { get; set; }

        [JsonProperty("attachable_type")]
        public string AttachableType { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("favorite")]
        public int Favorite { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("is_public")]
        public bool Public { get; set; }

        [JsonProperty("image")]
        public bool Image { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("url")]
        public FlyerAttachmentDetailUrl Url { get; set; }

        [JsonProperty("mime")]
        public string Mime { get; set; }

        [JsonProperty("meta_data")]
        public object MetaData { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        //[JsonProperty("created_by")]
        //public int CreatedBy { get; set; }

        //[JsonProperty("updated_by")]
        //public int UpdatedBy { get; set; }

        //[JsonProperty("created_at")]
        //public string CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public string UpdatedAt { get; set; }

        [JsonProperty("awsImageUrl")]
        public string AwsImageUrl { get; set; }
    }
}