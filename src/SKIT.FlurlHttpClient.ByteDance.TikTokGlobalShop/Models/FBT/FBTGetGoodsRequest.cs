using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fbt/{version}/goods/search 接口的请求。</para>
    /// </summary>
    public class FBTGetGoodsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202409</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202409;

        /// <summary>
        /// 获取或设置货物 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_ids")]
        public IList<string>? GoodsIdList { get; set; }

        /// <summary>
        /// 获取或设置商家自定义货物标识符列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reference_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("reference_codes")]
        public IList<string>? ReferenceCodeList { get; set; }

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

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PageToken { get; set; }
    }
}
