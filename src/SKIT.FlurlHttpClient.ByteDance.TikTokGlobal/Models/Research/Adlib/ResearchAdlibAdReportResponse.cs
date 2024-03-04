using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/ad/report/ 接口的响应。</para>
    /// </summary>
    public class ResearchAdlibAdReportResponse : TikTokV2Response<ResearchAdlibAdReportResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DateCount
                    {
                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public long Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置各国家的广告统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count_time_series_by_country")]
                [System.Text.Json.Serialization.JsonPropertyName("count_time_series_by_country")]
                public IDictionary<string, Types.DateCount[]> CountTimeSeriesByCountry { get; set; } = default!;
            }
        }
    }
}
