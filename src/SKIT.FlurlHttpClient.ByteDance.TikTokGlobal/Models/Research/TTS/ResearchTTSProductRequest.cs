namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/tts/product/ 接口的请求。</para>
    /// </summary>
    public class ResearchTTSProductRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<string>? FieldList { get; set; }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
        public string? ShopId { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_start")]
        [System.Text.Json.Serialization.JsonPropertyName("page_start")]
        public int Page { get; set; } = 1;
        
        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        public ResearchTTSProductRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("product_id");
            FieldList.Add("product_sold_count");
            FieldList.Add("product_description");
            FieldList.Add("product_price");
            FieldList.Add("product_review_count");
            FieldList.Add("product_name");
            FieldList.Add("product_rating_1_count");
            FieldList.Add("product_rating_2_count");
            FieldList.Add("product_rating_3_count");
            FieldList.Add("product_rating_4_count");
            FieldList.Add("product_rating_5_count");
            return this;
        }
    }
}
