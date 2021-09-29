using System;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualIntegerArrayWithCommaConverter : JsonConverter<int[]?>
    {
        private const char SEPARATOR = ',';

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override int[]? ReadJson(JsonReader reader, Type objectType, int[]? existingValue, bool hasExistingValue, JsonSerializer serializer)
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

                return value.Split(new char[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries).Select(e => int.Parse(e)).ToArray();
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, int[]? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(SEPARATOR.ToString(), value));
            else
                writer.WriteNull();
        }
    }
}
