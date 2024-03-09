namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 enter_im 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/event-list ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/message-management-enterprise/accept-message-event ]]>
    /// </para>
    /// </summary>
    public class EnterIMEvent : DouyinOpenEvent<EnterIMEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置进入对话来源场景值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public string Scene { get; set; } = default!;

                /// <summary>
                /// 获取或设置来源场景对应 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object")]
                [System.Text.Json.Serialization.JsonPropertyName("object")]
                public string? Object { get; set; }
            }
        }
    }
}
