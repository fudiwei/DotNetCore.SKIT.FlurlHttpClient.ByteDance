namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Converters.SystemTextJson
{
    internal class CSTDateTimeOffsetConverter : SKIT.JsonConv.SystemTextJson.Converters.FormattableDateTimeOffsetConverterBase
    {
        protected override string FormatString => "yyyy-MM-dd HH:mm:ss zzz CST";
    }
}
