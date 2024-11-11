using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /promotion/{version}/activities/{activity_id}/products 接口的请求。</para>
    /// </summary>
    public class PromotionDeleteActivityProductsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<string>? ProductIdList { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_ids")]
        public IList<string>? SKUIdList { get; set; }
    }
}
