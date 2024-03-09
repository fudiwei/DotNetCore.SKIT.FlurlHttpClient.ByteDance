using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/sku/batch_save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsSKUBatchSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class SKU
            {
                public static class Types
                {
                    public class Stock : GoodLifeGoodsProductSaveV1Request.Types.SKU.Types.Stock
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public string? SKUId { get; set; }

                /// <summary>
                /// 获取或设置 SKU 外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                public string? OutSKUId { get; set; }

                /// <summary>
                /// 获取或设置 SKU 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_name")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                public string SKUName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock")]
                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                public Types.Stock Stock { get; set; } = new Types.Stock();

                /// <summary>
                /// 获取或设置原价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("origin_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("origin_amount")]
                public int? OriginalAmount { get; set; }

                /// <summary>
                /// 获取或设置实际价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_amount")]
                public int ActualAmount { get; set; }

                /// <summary>
                /// 获取或设置属性键值对字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_key_value_map")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_key_value_map")]
                public IDictionary<string, string>? AttributeKeyValueMap { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。与字段 <see cref="OutProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品外部 ID。与字段 <see cref="ProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_id")]
        public string? OutProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
