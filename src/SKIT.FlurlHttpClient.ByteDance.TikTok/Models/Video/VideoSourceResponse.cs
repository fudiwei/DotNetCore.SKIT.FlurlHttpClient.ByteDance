namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/source 接口的响应。</para>
    /// </summary>
    public class VideoSourceResponse : TikTokResponse<VideoSourceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置视频来源列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string[] SourceList { get; set; } = default!;
            }
        }
    }
}
