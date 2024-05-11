using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_products/search 接口的请求。</para>
    /// </summary>
    public class ProductSearchGlobalProductsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202312</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202312;

        /// <summary>
        /// 获取或设置创建时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_ge")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_ge")]
        public long? CreateTimestampGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置创建时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_le")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_le")]
        public long? CreateTimestampLessThan { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_ge")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_ge")]
        public long? UpdateTimestampGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_le")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_le")]
        public long? UpdateTimestampLessThan { get; set; }

        /// <summary>
        /// 获取或设置商品状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? ProductStatus { get; set; }

        /// <summary>
        /// 获取或设置卖家 SKU 信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_skus")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_skus")]
        public IList<string>? SellerSKUList { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PageToken { get; set; }
    }
}
