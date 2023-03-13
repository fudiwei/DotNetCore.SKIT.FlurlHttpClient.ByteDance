using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/items/remove 接口的请求。</para>
    /// </summary>
    public class PromotionRemoveActivityItemsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial_no")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial_no")]
        public string RequestSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置促销 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SPU ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_list")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_list")]
        public IList<string>? SPUIdList { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
        public IList<string>? SKUIdList { get; set; }
    }
}
