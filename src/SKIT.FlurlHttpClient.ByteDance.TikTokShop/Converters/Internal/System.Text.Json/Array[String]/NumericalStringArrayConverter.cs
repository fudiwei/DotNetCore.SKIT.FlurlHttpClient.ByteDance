using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class NumericalStringArrayConverter : JsonConverter<string[]?>
    {
        public override string[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                reader.Read();

                var tmpList = new List<string>();
                var tmpOptions = new JsonSerializerOptions(options);
                tmpOptions.Converters.Add(new NumericalStringConverter());

                while (reader.TokenType != JsonTokenType.EndArray)
                {
                    string? value = JsonSerializer.Deserialize<string>(ref reader, tmpOptions);
                    if (value != null)
                        tmpList.Add(value);

                    reader.Read();
                }

                return tmpList.ToArray();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartArray();

                foreach (string item in value)
                {
                    JsonSerializer.Serialize(writer, item, options);
                }

                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
