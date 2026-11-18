namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/advertiser/query/ 接口的请求。</para>
    /// </summary>
    public class ResearchAdlibAdvertiserQueryRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<string>? FieldList { get; set; }

        /// <summary>
        /// 获取或设置搜索词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_term")]
        [System.Text.Json.Serialization.JsonPropertyName("search_term")]
        public string? SearchTerm { get; set; }

        /// <summary>
        /// 获取或设置最大返回数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_count")]
        [System.Text.Json.Serialization.JsonPropertyName("max_count")]
        public int? MaxCount { get; set; }

        public ResearchAdlibAdvertiserQueryRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("business_name");
            FieldList.Add("business_id");
            FieldList.Add("country_code");
            return this;
        }
    }
}
