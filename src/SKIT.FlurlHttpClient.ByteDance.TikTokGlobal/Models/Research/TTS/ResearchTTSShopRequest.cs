namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/tts/shop/ 接口的请求。</para>
    /// </summary>
    public class ResearchTTSShopRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<string>? FieldList { get; set; }

        /// <summary>
        /// 获取或设置店铺名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
        public string? ShopName { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int PageSize { get; set; } = 10;

        public ResearchTTSShopRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("shop_name");
            FieldList.Add("shop_rating");
            FieldList.Add("shop_review_count");
            FieldList.Add("item_sold_count");
            FieldList.Add("shop_id");
            FieldList.Add("shop_performance_value");
            return this;
        }
    }
}
