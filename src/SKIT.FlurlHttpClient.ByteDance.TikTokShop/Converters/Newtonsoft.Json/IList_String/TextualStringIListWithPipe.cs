using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Newtonsoft.Json.Converters
{
    internal class TextualStringIListWithPipe : JsonConverter<IList<string>?>
    {
        private const char SEPARATOR = '|';

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override IList<string>? ReadJson(JsonReader reader, Type objectType, IList<string>? existingValue, bool hasExistingValue, JsonSerializer serializer)
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

        public override void WriteJson(JsonWriter writer, IList<string>? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(SEPARATOR.ToString(), value));
            else
                writer.WriteNull();
        }
    }
}
