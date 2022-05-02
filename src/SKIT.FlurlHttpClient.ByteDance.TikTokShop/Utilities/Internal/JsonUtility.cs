using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Utilities
{
    internal static class JsonUtility
    {
        private class MarshalJObjectConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(JObject);
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                writer.WriteStartObject();

                var jObject = (JObject)value!;
                var props = jObject.Properties().OrderBy(i => i.Name).ToList();
                foreach (var prop in props)
                {
                    writer.WritePropertyName(prop.Name);
                    serializer.Serialize(writer, prop.Value);
                }

                writer.WriteEndObject();
            }

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize(reader, objectType) ?? existingValue;
            }
        }

        private class MarshalJValueConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(JValue);
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                var jVal = (JValue)value!;
                if (jVal.Type == JTokenType.Float ||
                    jVal.Type == JTokenType.String)
                {
                    double d;

                    if (jVal.Type == JTokenType.String)
                    {
                        if (!double.TryParse(jVal.Value?.ToString(), out d))
                        {
                            writer.WriteValue(value);
                            return;
                        }
                    }
                    else
                    {
                        d = Convert.ToDouble(jVal.Value);
                    }

                    long i = (long)d;
                    if (Math.Abs(i - d) == 0)
                    {
                        writer.WriteValue(i);
                        return;
                    }
                }

                writer.WriteValue(value);
            }

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize(reader, objectType) ?? existingValue;
            }
        }

        internal static string Format(string json)
        {
            // 1. 确保所有层级上 Key 的有序性
            // 2. 确保所有数值不带多余的小数点（即 1.0 → 1）

            if (string.IsNullOrEmpty(json))
                return string.Empty;

            var jObject = JsonConvert.DeserializeObject(json);
            var settings = new JsonSerializerSettings();
            settings.Converters = new List<JsonConverter> { new MarshalJObjectConverter(), new MarshalJValueConverter() };
            return JsonConvert.SerializeObject(jObject, Formatting.None, settings);
        }
    }
}
