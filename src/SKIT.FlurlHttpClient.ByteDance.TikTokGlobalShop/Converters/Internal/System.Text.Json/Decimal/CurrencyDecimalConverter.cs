using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class CurrencyDecimalConverter : JsonConverterFactory
    {
        private sealed class InnerCurrencyNullableDecimalConverter : JsonConverter<decimal?>
        {
            public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return default;
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    string? str = reader.GetString();
                    if (string.IsNullOrEmpty(str))
                        return default;

                    if (decimal.TryParse(str, out decimal value))
                        return value;

                    throw new JsonException($"Could not parse String '{str}' to Decimal.");
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    return reader.GetDecimal();
                }

                throw new JsonException();
            }

            public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
            {
                if (value != null)
                    writer.WriteNumberValue(value.Value);
                else
                    writer.WriteNullValue();
            }
        }

        private sealed class InnerCurrencyDecimalConverter : JsonConverter<decimal>
        {
            private readonly JsonConverter<decimal?> _converter = new InnerCurrencyNullableDecimalConverter();

            public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                decimal? result = _converter.Read(ref reader, typeToConvert, options);
                return result.GetValueOrDefault();
            }

            public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value, options);
            }
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(decimal) == typeToConvert ||
                   typeof(decimal?) == typeToConvert;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeof(decimal?) == typeToConvert)
                return new InnerCurrencyNullableDecimalConverter();
            else if (typeof(decimal) == typeToConvert)
                return new InnerCurrencyDecimalConverter();

            throw new NotSupportedException();
        }
    }
}
