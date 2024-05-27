namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_component_with_overview/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryComponentWithOverviewV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ComponentOverviewData
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

                        /// <summary>
                        /// 获取或设置当日线索数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ClueCnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("ClueCnt")]
                        public int ClueCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日线索用户数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ClueUcnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("ClueUcnt")]
                        public int ClueUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日有效线索数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ValidClueCnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("ValidClueCnt")]
                        public int ValidClueCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日有效线索用户数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ValidClueUcnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("ValidClueUcnt")]
                        public int ValidClueUserCount { get; set; }
                    }

                    public class ComponentData : ComponentOverviewData
                    {
                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Date")]
                        [System.Text.Json.Serialization.JsonPropertyName("Date")]
                        public string? DateString { get; set; }

                        /// <summary>
                        /// 获取或设置小时字符串（格式：HH）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Hour")]
                        [System.Text.Json.Serialization.JsonPropertyName("Hour")]
                        public string? HourString { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置组件使用总览数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ComponentOverviewData")]
                [System.Text.Json.Serialization.JsonPropertyName("ComponentOverviewData")]
                public Types.ComponentOverviewData ComponentOverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置组件使用数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ComponentDataInfoList")]
                [System.Text.Json.Serialization.JsonPropertyName("ComponentDataInfoList")]
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
