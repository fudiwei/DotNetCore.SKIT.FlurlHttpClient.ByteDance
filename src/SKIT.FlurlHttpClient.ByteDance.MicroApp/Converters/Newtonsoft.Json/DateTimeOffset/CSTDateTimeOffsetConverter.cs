namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Converters.NewtonsoftJson
{
    internal class CSTDateTimeOffsetConverter : SKIT.JsonConv.NewtonsoftJson.Converters.FormattableDateTimeOffsetConverterBase
    {
        protected override string FormatString => "yyyy-MM-dd HH:mm:ss zzz CST";
    }
}
