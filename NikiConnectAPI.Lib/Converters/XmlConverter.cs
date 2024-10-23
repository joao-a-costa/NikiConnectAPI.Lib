using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NikiConnectAPI.Lib.Converters
{
    internal static class XmlConverter
    {
        public static string SerializeObject<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static string SerializeToString<T>(T value, string defaultNamespace = null, Dictionary<string, char> replacements = null)
        {
            var res = string.Empty;

            XmlSerializer serializer = null;

            if (defaultNamespace != null)
                serializer = new XmlSerializer(value.GetType(), defaultNamespace);
            else
                serializer = new XmlSerializer(value.GetType());

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                Encoding = Encoding.UTF8
            };

            using (StringWriter stream = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, value);

                    res = replacements == null ? stream.ToString() : ReplaceCharacters(stream.ToString(), replacements);

                    writer.Close();
                }

                stream.Close();
            }

            return res;
        }

        public static T DeserializeXml<T>(string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StringReader reader = new StringReader(xmlString))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static string ReplaceCharacters(string input, Dictionary<string, char> replacements)
        {
            // Normalize the string and filter out diacritic marks
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            char[] filteredChars = normalizedString
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray();

            // Create a new string without diacritic marks
            var res = new string(filteredChars);

            // Replace strings based on the dictionary
            if (replacements != null)
            {
                foreach (var replacement in replacements)
                {
                    res = res.Replace(replacement.Key, replacement.Value.ToString());
                }
            }

            return res;
        }
    }
}
