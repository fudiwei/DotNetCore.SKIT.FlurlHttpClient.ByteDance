namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /share-id 接口的响应。</para>
    /// </summary>
    public class ShareIdResponse : DouyinOpenResponse<ShareIdResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
