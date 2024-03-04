using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/ad/report/ 接口的请求。</para>
    /// </summary>
    public class ResearchAdlibAdReportRequest : TikTokV2Request
    {
        public static class Types
        {
            public class Filter
            {
                public static class Types
                {
                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置最小值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min")]
                        [System.Text.Json.Serialization.JsonPropertyName("min")]
                        public string Min { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置最大值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max")]
                        [System.Text.Json.Serialization.JsonPropertyName("max")]
                        public string Max { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置广告发布日期范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_published_date_range")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_published_date_range")]
                public Types.Range? AdPublishedDateRange { get; set; }

                /// <summary>
                /// 获取或设置国家代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country_code")]
                [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                public string? CountryCode { get; set; }

                /// <summary>
                /// 获取或设置广告商 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser_business_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser_business_ids")]
                public IList<long>? AdvertiserBusinessIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置过滤条件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters")]
        [System.Text.Json.Serialization.JsonPropertyName("filters")]
        public Types.Filter Filter { get; set; } = new Types.Filter();

        public ResearchAdlibAdReportRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("count_time_series_by_country");
            return this;
        }
    }
}
