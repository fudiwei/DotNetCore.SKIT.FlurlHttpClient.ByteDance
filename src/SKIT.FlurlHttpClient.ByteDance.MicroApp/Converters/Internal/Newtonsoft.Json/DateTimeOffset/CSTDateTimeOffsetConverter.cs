using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
    internal class CSTDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        internal const string DATETIME_FORMAT = "yyyy-MM-dd HH:mm:ss zzz CST";

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override DateTimeOffset ReadJson(JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? value = serializer.Deserialize<string>(reader);
                if (string.IsNullOrEmpty(value))
                    return existingValue;

                if (DateTimeOffset.TryParseExact(value, DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTimeOffset d))
                    return d;

                if (DateTimeOffset.TryParse(value, out d))
                    return d;

                throw new JsonSerializationException($"Could not parse String '{value}' to DateTimeOffset.");
            }
            else if (reader.TokenType == JsonToken.Date)
            {
                reader.DateFormatString = DATETIME_FORMAT;
                return serializer.Deserialize<DateTimeOffset>(reader);
            }

            throw new JsonSerializationException($"Unexpected token type '{reader.TokenType}' when deserializing. Path '{reader.Path}'.");
        }

        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString(DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo));
        }
    }
}
