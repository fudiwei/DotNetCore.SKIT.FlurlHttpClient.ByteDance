using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_products/{global_product_id}/inventory/update 接口的请求。</para>
    /// </summary>
    public class ProductUpdateGlobalProductInventoryRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class SKU
            {
                public static class Types
                {
                    public class Inventory : ProductCreateGlobalProductRequest.Types.SKU.Types.Inventory
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string SKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory")]
                public IList<Types.Inventory> InventoryList { get; set; } = new List<Types.Inventory>();
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("global_skus")]
        [System.Text.Json.Serialization.JsonPropertyName("global_skus")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
