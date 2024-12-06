using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace NikiConnectAPI.Lib.Helpers
{
    public static class DynamicToStringHelper
    {
        public static Dictionary<string, string> ToDictionary<T>(T obj,
            List<string> listFieldsNotToInclude = null,
            List<string> listFieldsToInclude = null,
            int index = 0,
            string keyName = "list",
            bool addSlug = true)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            var dictionary = new Dictionary<string, string>();

            // Retrieve DisplayName attribute from the class
            var displayNameAttribute = type.GetCustomAttribute<DisplayNameAttribute>();
            string slugValue = displayNameAttribute != null ? displayNameAttribute.DisplayName : type.Name.ToLower();

            // Add slug key-value pair to the dictionary
            if (addSlug)
                dictionary.Add(App._FieldSlug, slugValue);

            // Iterate over all properties and construct key-value pairs
            foreach (PropertyInfo property in properties)
            {
                // Skip property if not in the inclusion list (if provided)
                if (listFieldsToInclude != null && !listFieldsToInclude.Contains(property.Name))
                    continue;

                // Skip property if in the exclusion list
                if (listFieldsNotToInclude != null && listFieldsNotToInclude.Contains(property.Name))
                    continue;

                // Get the JsonProperty attribute
                var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                string key = jsonPropertyAttribute != null ? jsonPropertyAttribute.PropertyName : property.Name.ToLower();

                // Get the value of the property
                object value = property.GetValue(obj);

                // Add key-value pair to the dictionary
                if (value != null)
                {
                    if (property.PropertyType == typeof(DateTime))
                    {
                        dictionary.Add($"{keyName}[{index}][{key}]", Convert.ToDateTime(value).ToString(App._DateTimeFormat) ?? string.Empty);
                    }
                    else
                    {
                        dictionary.Add($"{keyName}[{index}][{key}]", string.IsNullOrEmpty(value.ToString()) ? $"\"\"" : value.ToString());
                    }
                }
            }

            return dictionary;
        }
    }
}
