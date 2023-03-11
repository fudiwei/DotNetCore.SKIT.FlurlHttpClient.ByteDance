namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /share/video/upload/ 接口的响应。</para>
    /// </summary>
    public class ShareVideoUploadResponse : TikTokResponse<ShareVideoUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResponseData
            {
                /// <summary>
                /// 获取或设置分享标识符。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_id")]
                [System.Text.Json.Serialization.JsonPropertyName("share_id")]
                public string ShareId { get; set; } = default!;
            }
        }
    }
}
