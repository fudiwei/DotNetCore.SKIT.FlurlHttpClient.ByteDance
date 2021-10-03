namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /share-id 接口的响应。</para>
    /// </summary>
    public class ShareIdResponse : TikTokResponse<ShareIdResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置分享 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_id")]
                [System.Text.Json.Serialization.JsonPropertyName("share_id")]
                public string ShareId { get; set; } = default!;
            }
        }
    }
}
