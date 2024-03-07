using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_page_data 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryPageDataV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PageData
                    {
                        /// <summary>
                        /// 获取或设置页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page")]
                        [System.Text.Json.Serialization.JsonPropertyName("page")]
                        public string PagePath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置页面访问人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_uv")]
                        public int UV { get; set; }

                        /// <summary>
                        /// 获取或设置页面浏览次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_pv")]
                        public int PV { get; set; }

                        /// <summary>
                        /// 获取或设置次均停留时长（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_avg_stay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_avg_stay_time")]
                        public decimal AverageStayTime { get; set; }

                        /// <summary>
                        /// 获取或设置分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_share_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_share_time")]
                        public int ShareTimes { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置页面分析数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_list")]
                [System.Text.Json.Serialization.JsonPropertyName("page_list")]
                public Types.PageData[] PageDataList { get; set; } = default!;
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
