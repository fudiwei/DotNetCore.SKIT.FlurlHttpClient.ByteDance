namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 authorize 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/event-list </para>
    /// </summary>
    public class AuthorizeEvent : TikTokEvent<AuthorizeEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置授权列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scopes")]
                [System.Text.Json.Serialization.JsonPropertyName("scopes")]
                public string[] ScopeList { get; set; } = default!;
            }
        }
    }
}
