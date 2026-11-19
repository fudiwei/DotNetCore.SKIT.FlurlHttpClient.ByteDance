namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 "life_member_leave" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/member.join ]]>
    /// </para>
    /// </summary>
    public class LifeMemberLeaveEvent : DouyinOpenEvent<LifeMemberLeaveEvent.Types.Content>
    {
        public static class Types
        {
            public class Content : LifeMemberJoinEvent.Types.Content
            {
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
        public override Types.Content? EventContent { get; set; }
    }
}
