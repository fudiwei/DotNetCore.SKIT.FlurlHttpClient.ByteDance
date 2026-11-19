namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Events
{
    /// <summary>
    /// <para>表示 "video.upload.failed" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.tiktok.com/doc/webhooks-events ]]>
    /// </para>
    /// </summary>
    public class VideoUploadFailedEvent : TikTokV2Event<VideoUploadFailedEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置分享 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_id")]
                [System.Text.Json.Serialization.JsonPropertyName("share_id")]
                public string? ShareId { get; set; }
            }
        }
    }
}
