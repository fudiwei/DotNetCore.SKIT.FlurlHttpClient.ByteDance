using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualLongIListWithComma : JsonConverter<IList<long>?>
    {
        private const char SEPARATOR = ',';

        public override IList<long>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

                return value.Split(new char[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries).Select(e => long.Parse(e)).ToList();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, IList<long>? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join(SEPARATOR.ToString(), value));
            else
                writer.WriteNullValue();
        }
    }
}
