using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualStringListWithPipeSplitConverter : JsonConverter
    {
        private const char SEPARATOR = '|';

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(objectType.GetGenericTypeDefinition()) &&
                   typeof(string) == objectType.GetGenericArguments()[0];
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? value = serializer.Deserialize<string>(reader);
                if (value == null)
                    return existingValue;

                return value.Split(new char[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(SEPARATOR.ToString(), value));
            else
                writer.WriteNull();
        }
    }
}
