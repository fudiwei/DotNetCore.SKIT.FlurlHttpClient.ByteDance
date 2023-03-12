using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualDecimalReadOnlyConverter : JsonConverter<decimal>
    {
        private readonly JsonConverter<decimal?> _converter = new TextualNullableDecimalReadOnlyConverter();

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
}
