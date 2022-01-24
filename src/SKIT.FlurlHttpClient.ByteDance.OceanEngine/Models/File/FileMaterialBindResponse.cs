namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/material/bind 接口的响应。</para>
    /// </summary>
    public class FileMaterialBindResponse : OceanEngineResponse<FileMaterialBindResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Failure
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        public string VideoId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推送的广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("target_advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("target_advertiser_id")]
                        public long TargetAdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置失败列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
                public Types.Failure[] FailureList { get; set; } = default!;
            }
        }
    }
}
