﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Newtonsoft.Json.Converters
{
    internal class TextualLongIListWithComma : JsonConverter<IList<long>?>
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

        public override IList<long>? ReadJson(JsonReader reader, Type objectType, IList<long>? existingValue, bool hasExistingValue, JsonSerializer serializer)
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

                return value.Split(new char[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries).Select(e => long.Parse(e)).ToList();
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, IList<long>? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(SEPARATOR.ToString(), value));
            else
                writer.WriteNull();
        }
    }
}
