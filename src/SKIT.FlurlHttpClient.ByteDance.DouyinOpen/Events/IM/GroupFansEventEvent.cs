namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 group_fans_event 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/group-fans-webhook/group-fans-join ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/group-fans-webhook/join-group-event ]]>
    /// </para>
    /// </summary>
    public class GroupFansEventEvent : DouyinOpenEvent<GroupFansEventEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("im_group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("im_group_id")]
                public string GroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置群主的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OwnerOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置群类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("create_group_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? GroupType { get; set; }

                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("group_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ActionType { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
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
