using System;
using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Converters
{
    public class SafeDateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string[] _formats = {
            "MM/dd/yyyy HH:mm:ss",
            "dd-MM-yyyy HH:mm:ss",
            "dd/MM/yyyy HH:mm:ss",
            "MM/dd/yyyy",
            "dd-MM-yyyy"
        };
        private readonly IFormatProvider _formatProvider = System.Globalization.CultureInfo.InvariantCulture;

        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            writer.WriteValue(value?.ToString("o")); // outputs in ISO 8601 format
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (DateTime.TryParseExact(reader.Value?.ToString(), _formats, _formatProvider, System.Globalization.DateTimeStyles.AdjustToUniversal, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
    }
}
