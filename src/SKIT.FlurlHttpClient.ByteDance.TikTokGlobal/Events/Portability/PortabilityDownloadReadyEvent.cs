namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Events
{
    /// <summary>
    /// <para>表示 "portability.download.ready" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.tiktok.com/doc/webhooks-events ]]>
    /// </para>
    /// </summary>
    public class PortabilityDownloadReadyEvent : TikTokV2Event<PortabilityDownloadReadyEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置请求 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_id")]
                [System.Text.Json.Serialization.JsonPropertyName("request_id")]
                public long RequestId { get; set; }
            }
        }
    }
}
