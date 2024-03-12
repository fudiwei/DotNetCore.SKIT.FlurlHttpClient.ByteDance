namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 new_video_digg 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/intention-user/item-digg ]]>
    /// </para>
    /// </summary>
    public class NewVideoDiggEvent : DouyinOpenEvent<NewVideoDiggEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string ItemId { get; set; } = default!;

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
