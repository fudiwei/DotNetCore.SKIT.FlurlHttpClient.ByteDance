namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/douyin/v1/video/get_iframe_by_video 接口的响应。</para>
    /// </summary>1
    public class DouyinVideoGetIframeByVideoV1Response : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 iFrame 代码片段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("iframe_code")]
                [System.Text.Json.Serialization.JsonPropertyName("iframe_code")]
                public string IframeCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_title")]
                [System.Text.Json.Serialization.JsonPropertyName("video_title")]
                public string VideoTitle { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_width")]
                [System.Text.Json.Serialization.JsonPropertyName("video_width")]
                public int VideoWidth { get; set; }

                /// <summary>
                /// 获取或设置视频高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_height")]
                [System.Text.Json.Serialization.JsonPropertyName("video_height")]
                public int VideoHeight { get; set; }
            }
        }

        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
