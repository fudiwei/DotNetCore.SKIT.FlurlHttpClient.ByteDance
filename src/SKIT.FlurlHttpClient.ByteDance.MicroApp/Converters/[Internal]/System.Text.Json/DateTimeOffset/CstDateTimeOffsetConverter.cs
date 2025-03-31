namespace System.Text.Json.Serialization.Internal
{
    internal class CstDateTimeOffsetConverter : Common.FormattedDateTimeOffsetConverterBase
    {
        protected override string FormatString => "yyyy-MM-dd HH:mm:ss zzz CST";
    }
}
