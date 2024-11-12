using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fbt/{version}/inventory/search 接口的请求。</para>
    /// </summary>
    public class FBTGetInventoriesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202408</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202408;

        /// <summary>
        /// 获取或设置货物 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_ids")]
        public IList<string>? GoodsIdList { get; set; }

        /// <summary>
        /// 获取或设置 FBT 仓库 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fbt_warehouse_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("fbt_warehouse_ids")]
        public IList<string>? FBTWarehouseIdList { get; set; }

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
