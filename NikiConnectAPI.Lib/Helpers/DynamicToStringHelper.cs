using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace NikiConnectAPI.Lib.Helpers
{
    public static class DynamicToStringHelper
    {
        public static string ToDynamicString<T>(T obj, int index = 0)
        {
            obj = default;

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            List<string> keyValuePairs = new List<string>();

            // Construct list[0]["id"] part
            string result = $"list[{index}][\"id\"]: {type.GetProperty("Id")?.GetValue(obj)}";

            // Iterate over all properties and construct key-value pairs
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                string key = property.Name;

                // Add key-value pair to the list in the specified format
                keyValuePairs.Add($"{{\"key\":\"list[{index}][\\\"{key.ToLower()}\\\"]\",\"value\":\"{value}\",\"type\":\"text\",\"enabled\":false}}");
            }

            // Join key-value pairs and append them to the result
            result += " [" + string.Join(", ", keyValuePairs) + "]";

            return result;
        }

        public static Dictionary<string, string> ToDictionary<T>(T obj, List<string> listFieldsNotToInclude = null, int index = 0)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            var dictionary = new Dictionary<string, string>();

            // Retrieve DisplayName attribute from the class
            var displayNameAttribute = type.GetCustomAttribute<DisplayNameAttribute>();
            string slugValue = displayNameAttribute != null ? displayNameAttribute.DisplayName : type.Name.ToLower();

            // Add slug key-value pair to the dictionary
            dictionary.Add(App._FieldSlug, slugValue);

            // Iterate over all properties and construct key-value pairs
            foreach (PropertyInfo property in properties)
            {
                // Skip if the property name is in the exclusion list
                if (listFieldsNotToInclude != null && listFieldsNotToInclude.Contains(property.Name))
                    continue;

                // Get the JsonProperty attribute
                var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                string key = jsonPropertyAttribute != null ? jsonPropertyAttribute.PropertyName : property.Name.ToLower();

                // Get the value of the property
                object value = property.GetValue(obj);

                // Add key-value pair to the dictionary
                if (value != null && !string.IsNullOrEmpty(value.ToString()))
                {
                    if (property.PropertyType == typeof(DateTime))
                    {
                        dictionary.Add($"list[{index}][{key}]", Convert.ToDateTime(value).ToString(App._DateTimeFormat) ?? string.Empty);
                    }
                    else
                        dictionary.Add($"list[{index}][{key}]", value.ToString() ?? string.Empty);
                }
            }

            return dictionary;
        }
    }
}
