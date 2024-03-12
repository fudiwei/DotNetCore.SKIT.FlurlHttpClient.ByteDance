namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 enter_group_audit_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/group-fans-webhook/add-group-audit-webhook ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/group-fans-webhook/enter-group-audit-change-webhook ]]>
    /// </para>
    /// </summary>
    public class EnterGroupAuditChangeEvent : DouyinOpenEvent<EnterGroupAuditChangeEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string GroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置入群申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                public string ApplyId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_status")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_status")]
                public int ApplyStatus { get; set; }

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_nicker")]
                [System.Text.Json.Serialization.JsonPropertyName("user_nicker")]
                public string UserNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("user_avatar")]
                public string UserAvatarUrl { get; set; } = default!;

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
