using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NikiConnectAPI.Lib.Models.Flyers;

namespace NikiConnectAPI.Lib.Converters
{
    public class FlyerAttachmentDetailUrlConverter : JsonConverter<FlyerAttachmentDetailUrl>
    {
        public override FlyerAttachmentDetailUrl ReadJson(JsonReader reader, Type objectType, FlyerAttachmentDetailUrl existingValue,
            bool hasExistingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);

            // If the "url" field is a string, set it as "original"
            if (token.Type == JTokenType.String)
            {
                return new FlyerAttachmentDetailUrl
                {
                    Original = token.ToString()
                };
            }

            // If the "url" field is an object, deserialize as usual
            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<FlyerAttachmentDetailUrl>();
            }

            // Default to null if unexpected type
            return null;
        }

        public override void WriteJson(JsonWriter writer, FlyerAttachmentDetailUrl value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            // Serialize as object
            serializer.Serialize(writer, value);
        }
    }
}
