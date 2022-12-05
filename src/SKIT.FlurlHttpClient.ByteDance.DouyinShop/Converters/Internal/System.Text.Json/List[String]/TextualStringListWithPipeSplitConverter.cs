using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualStringListWithPipeSplitConverter : JsonConverterFactory
    {
        private sealed class InnerTextualStringListWithPipeSplitConverter : JsonConverter<IList<string>?>
        {
            private const char SEPARATOR = '|';

            public override IList<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    string? value = reader.GetString();
                    if (value == null)
                        return null;

                    return value.Split(new char[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                throw new JsonException();
            }

            public override void Write(Utf8JsonWriter writer, IList<string>? value, JsonSerializerOptions options)
            {
                if (value != null)
                    writer.WriteStringValue(string.Join(SEPARATOR.ToString(), value));
                else
                    writer.WriteNullValue();
            }
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(typeToConvert.GetGenericTypeDefinition()) &&
                   typeof(string) == typeToConvert.GetGenericArguments()[0];
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return new InnerTextualStringListWithPipeSplitConverter();
        }
    }
}
