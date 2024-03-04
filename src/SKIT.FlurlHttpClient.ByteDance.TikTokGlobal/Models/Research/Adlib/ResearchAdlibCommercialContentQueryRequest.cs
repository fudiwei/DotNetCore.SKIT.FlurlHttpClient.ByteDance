using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/commercial_content/query/ 接口的请求。</para>
    /// </summary>
    public class ResearchAdlibCommercialContentQueryRequest : TikTokV2Request
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
                /// 获取或设置内容发布日期范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_published_date_range")]
                [System.Text.Json.Serialization.JsonPropertyName("content_published_date_range")]
                public Types.Range? ContentPublishedDateRange { get; set; }

                /// <summary>
                /// 获取或设置创作者国家代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_country_code")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_country_code")]
                public string? CreatorCountryCode { get; set; }

                /// <summary>
                /// 获取或设置创作者用户名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_usernames")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_usernames")]
                public IList<string>? CreatorUsernameList { get; set; }
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

        /// <summary>
        /// 获取或设置搜索结果标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_id")]
        [System.Text.Json.Serialization.JsonPropertyName("search_id")]
        public string? SearchId { get; set; }

        /// <summary>
        /// 获取或设置最大返回数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_count")]
        [System.Text.Json.Serialization.JsonPropertyName("max_count")]
        public int? MaxCount { get; set; }

        public ResearchAdlibCommercialContentQueryRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("id");
            FieldList.Add("create_timestamp");
            FieldList.Add("create_date");
            FieldList.Add("label");
            FieldList.Add("brand_names");
            FieldList.Add("creator");
            FieldList.Add("videos");
            return this;
        }
    }
}
