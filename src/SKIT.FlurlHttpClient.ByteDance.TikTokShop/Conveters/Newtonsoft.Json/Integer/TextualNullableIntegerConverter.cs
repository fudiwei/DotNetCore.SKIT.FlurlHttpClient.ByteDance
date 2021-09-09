using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class TextualNullableIntegerConverter : JsonConverter<int?>
    {
        public override bool CanRead 
        { 
            get { return true; } 
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override int? ReadJson(JsonReader reader, Type objectType, int? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                int value = serializer.Deserialize<int>(reader);
                return value;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? str = serializer.Deserialize<string>(reader);
                if (str == null)
                    return existingValue;

                if (int.TryParse(str, out int value))
                    return Convert.ToInt32(value);
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, int? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value);
            else
                writer.WriteNull();
        }
    }
}
