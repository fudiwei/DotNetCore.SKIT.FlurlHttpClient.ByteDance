namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /opptyProduct/getApplyProgress 接口的请求。</para>
    /// </summary>
    public class OpportunityProductGetApplyProgressRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置机会品来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origin")]
        [System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string Origin { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置机会品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}
