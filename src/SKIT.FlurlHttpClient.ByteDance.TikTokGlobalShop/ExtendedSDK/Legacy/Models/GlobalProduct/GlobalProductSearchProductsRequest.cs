using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/global_products/search 接口的请求。</para>
    /// </summary>
    public class GlobalProductSearchProductsRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置创建时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_from")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_from")]
        public long? CreateTimestampFrom { get; set; }

        /// <summary>
        /// 获取或设置创建时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_to")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_to")]
        public long? CreateTimestampTo { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_from")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_from")]
        public long? UpdateTimestampFrom { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_to")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_to")]
        public long? UpdateTimestampTo { get; set; }

        /// <summary>
        /// 获取或设置商品状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? ProductStatus { get; set; }

        /// <summary>
        /// 获取或设置卖家 SKU 信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_sku_list")]
        public IList<string>? SellerSKUList { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_number")]
        [System.Text.Json.Serialization.JsonPropertyName("page_number")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
