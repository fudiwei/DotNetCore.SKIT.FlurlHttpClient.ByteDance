using System;

namespace Newtonsoft.Json.Converters
{
    internal class CurrencyDecimalConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(decimal) == objectType ||
                   typeof(decimal?) == objectType;
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
                string? str = serializer.Deserialize<string>(reader);
                if (string.IsNullOrEmpty(str))
                    return existingValue;

                if (decimal.TryParse(str, out decimal value))
                    return value;

                throw new JsonSerializationException($"Could not parse String '{str}' to Decimal.");
            }
            else if (reader.TokenType == JsonToken.Float || reader.TokenType == JsonToken.Integer)
            {
                return serializer.Deserialize<decimal>(reader);
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue((decimal)value);
            else
                writer.WriteNull();
        }
    }
}
