namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 life_member_leave 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/member.join </para>
    /// </summary>
    public class LifeMemberLeaveEvent : DouyinOpenEvent<LifeMemberLeaveEvent.Types.Content>
    {
        public static class Types
        {
            public class Content : LifeMemberJoinEvent.Types.Content
            {
            }
        }

        internal static class Converters
        {
            internal class EventPropertyContentNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Content?>
            {
            }

            internal class EventPropertyContentSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Content?>
            {
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.EventPropertyContentNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.EventPropertyContentSystemTextJsonConverter))]
        public override Types.Content EventContent { get; set; } = default!;
    }
}
