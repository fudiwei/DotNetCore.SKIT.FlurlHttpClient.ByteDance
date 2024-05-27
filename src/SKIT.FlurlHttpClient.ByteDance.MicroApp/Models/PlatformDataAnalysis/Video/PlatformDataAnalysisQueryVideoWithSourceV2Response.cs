namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_video_with_source/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryVideoWithSourceV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class VideoData
                    {
                        public static class Types
                        {
                            public class CommonData
                            {
                                /// <summary>
                                /// 获取或设置小程序曝光次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("MpShowPv")]
                                [System.Text.Json.Serialization.JsonPropertyName("MpShowPv")]
                                public int MicroAppShowPV { get; set; }

                                /// <summary>
                                /// 获取或设置小程序曝光人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("MpShowUv")]
                                [System.Text.Json.Serialization.JsonPropertyName("MpShowUv")]
                                public int MicroAppShowUV { get; set; }

                                /// <summary>
                                /// 获取或设置进入小程序次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("MpDrainagePv")]
                                [System.Text.Json.Serialization.JsonPropertyName("MpDrainagePv")]
                                public int MicroAppDrainagePV { get; set; }

                                /// <summary>
                                /// 获取或设置进入小程序人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("MpDrainageUv")]
                                [System.Text.Json.Serialization.JsonPropertyName("MpDrainageUv")]
                                public int MicroAppDrainageUV { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置场景值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Scenes")]
                        [System.Text.Json.Serialization.JsonPropertyName("Scenes")]
                        public string Scene { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置场景名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ScenesName")]
                        [System.Text.Json.Serialization.JsonPropertyName("ScenesName")]
                        public string SceneName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置统计数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CommonData")]
                        [System.Text.Json.Serialization.JsonPropertyName("CommonData")]
                        public Types.CommonData CommonData { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频播放次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("VideoPlayCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("VideoPlayCount")]
                        public int VideoPlayCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置短视频流量来源数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("DataList")]
                [System.Text.Json.Serialization.JsonPropertyName("DataList")]
                public Types.VideoData[] VideoDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
