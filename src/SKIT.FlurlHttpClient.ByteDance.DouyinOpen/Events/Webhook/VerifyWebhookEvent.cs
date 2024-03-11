namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 verify_webhook 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/event-list ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/guide/open-capabilities/webhook ]]>
    /// </para>
    /// </summary>
    public class VerifyWebhookEvent : DouyinOpenEvent<VerifyWebhookEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置验证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("challenge")]
                [System.Text.Json.Serialization.JsonPropertyName("challenge")]
                public int Challenge { get; set; }
            }
        }
    }
}
