namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Events
{
    /// <summary>
    /// <para>表示 "authorization.removed" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.tiktok.com/doc/webhooks-events ]]>
    /// </para>
    /// </summary>
    public class AuthorizationRemovedEvent : TikTokV2Event<AuthorizationRemovedEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ReasonType { get; set; }
            }
        }
    }
}
