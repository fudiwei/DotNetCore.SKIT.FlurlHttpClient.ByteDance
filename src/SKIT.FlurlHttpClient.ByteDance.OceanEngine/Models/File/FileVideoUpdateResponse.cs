namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/video/update 接口的响应。</para>
    /// </summary>
    public class FileVideoUpdateResponse : OceanEngineResponse<FileVideoUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        public string VideoId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置更新状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("status_code")]
                        public string Status { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("videos")]
                [System.Text.Json.Serialization.JsonPropertyName("videos")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
