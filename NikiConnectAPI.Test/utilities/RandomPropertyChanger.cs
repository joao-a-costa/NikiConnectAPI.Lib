using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NikiConnectAPI.Test.Utilities
{
    public static class RandomPropertyChanger
    {
        private static Random _random = new Random();

        public static List<PropertyInfo> GetRandomPropertiesWithAttributes(object obj, List<Type> attributeTypes)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (attributeTypes == null || !attributeTypes.Any())
                throw new ArgumentException("Attribute types cannot be null or empty.", nameof(attributeTypes));

            // Get all properties of the object that are writable, primitive, and marked with the specified attributes
            var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite && IsPrimitiveOrValueType(p.PropertyType)
                             && attributeTypes.Exists(attr => p.GetCustomAttribute(attr) != null))
                .ToList();

            // If no editable primitive properties are found, return
            if (!properties.Any())
            {
                Console.WriteLine("No editable primitive properties to change.");
                return null;
            }

            return properties;
        }

        public static object GetPrimitiveValue(PropertyInfo propertyInfo, object obj)
        {
            return propertyInfo.GetValue(obj);
        }

        public static void SetPrimitiveProperty(PropertyInfo propertyInfo, object obj, object value)
        {
            // Set the random value to the selected property
            propertyInfo.SetValue(obj, value);

            Console.WriteLine($"Changed property {propertyInfo.Name} to {value}");
        }

        // Check if the type is a primitive or a value type
        private static bool IsPrimitiveOrValueType(Type type)
        {
            return type.IsPrimitive || type.IsValueType || type == typeof(string);
        }

        // Generate a random value for a given type
        public static object GetRandomValue(PropertyInfo propertyInfo)
        {
            // Generate a random value for the selected property's type
            object randomValue = null;

            while (randomValue == null)
            {
                if (propertyInfo.PropertyType == typeof(int))
                    randomValue = _random.Next(1, 100);
                if (propertyInfo.PropertyType == typeof(float))
                    randomValue = (float)_random.NextDouble() * 100;
                if (propertyInfo.PropertyType == typeof(double))
                    randomValue = _random.NextDouble() * 100;
                if (propertyInfo.PropertyType == typeof(bool))
                    randomValue = _random.Next(2) == 0;
                if (propertyInfo.PropertyType == typeof(char))
                    randomValue = (char)_random.Next('A', 'Z');
                if (propertyInfo.PropertyType == typeof(string))
                    randomValue = Guid.NewGuid().ToString().Substring(0, 8); // Generate random string
            }

            return randomValue;
        }

    }
}
