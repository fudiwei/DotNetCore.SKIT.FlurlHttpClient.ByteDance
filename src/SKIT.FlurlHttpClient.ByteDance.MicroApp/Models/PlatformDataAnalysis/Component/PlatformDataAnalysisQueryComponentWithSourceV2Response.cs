namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_component_with_source/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryComponentWithSourceV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ComponentData
                    {
                        public static class Types
                        {
                            public class Statistics
                            {
                                /// <summary>
                                /// 获取或设置组件点击次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ComponentClickPv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ComponentClickPv")]
                                public int ComponentClickPV { get; set; }

                                /// <summary>
                                /// 获取或设置组件点击人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ComponentClickUv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ComponentClickUv")]
                                public int ComponentClickUV { get; set; }

                                /// <summary>
                                /// 获取或设置组件留资次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ComponentReportPv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ComponentReportPv")]
                                public int ComponentReportPV { get; set; }

                                /// <summary>
                                /// 获取或设置组件留资人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ComponentReportUv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ComponentReportUv")]
                                public int ComponentReportUV { get; set; }

                                /// <summary>
                                /// 获取或设置组件曝光次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ComponentShowPv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ComponentShowPv")]
                                public int ComponentShowPV { get; set; }

                                /// <summary>
                                /// 获取或设置组件曝光人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ComponentShowUv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ComponentShowUv")]
                                public int ComponentShowUV { get; set; }
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
                        [Newtonsoft.Json.JsonProperty("Data")]
                        [System.Text.Json.Serialization.JsonPropertyName("Data")]
                        public Types.Statistics Statistics { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置组件流量来源数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ScenesDataList")]
                [System.Text.Json.Serialization.JsonPropertyName("ScenesDataList")]
                public Types.ComponentData[] ComponentDataList { get; set; } = default!;
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
