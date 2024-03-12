namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 new_follow_action 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/intention-user/user-follow ]]>
    /// </para>
    /// </summary>
    public class NewFollowActionEvent : DouyinOpenEvent<NewFollowActionEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置动作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action_type")]
                [System.Text.Json.Serialization.JsonPropertyName("action_type")]
                public int ActionType { get; set; }

                /// <summary>
                /// 获取或设置动作时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action_time")]
                [System.Text.Json.Serialization.JsonPropertyName("action_time")]
                public long ActionTimestamp { get; set; }
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public override Types.Content EventContent { get; set; } = default!;
    }
}
