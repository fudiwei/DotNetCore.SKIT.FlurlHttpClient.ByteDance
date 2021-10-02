using System.Collections.Generic;
using System.Linq;
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

                IList<string> tmpList = new List<string>();
                JsonSerializerOptions tmpOptions = new JsonSerializerOptions(options);
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
