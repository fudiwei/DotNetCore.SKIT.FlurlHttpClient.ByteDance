namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/getCateProperty 接口的请求。</para>
    /// </summary>
    public class ProductGetCategoryPropertyRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置叶子类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_leaf_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("category_leaf_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int CategoryLeafId { get; set; }

        /// <summary>
        /// 获取或设置版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }
    }
}
