namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/source 接口的响应。</para>
    /// </summary>
    public class VideoSourceResponse : DouyinOpenResponse<VideoSourceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
