namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/getKeyPropertyByCid 接口的请求。</para>
    /// </summary>
    public class SPUGetKeyPropertyByCategoryIdRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int PageSize { get; set; } = 10;
    }
}
