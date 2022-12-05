using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/product/save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsProductSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class POI
                    {
                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string? POIId { get; set; }

                        /// <summary>
                        /// 获取或设置门店外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string? SupplierExternalId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_id")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int ProductType { get; set; }

                /// <summary>
                /// 获取或设置品类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                public int? CategoryId { get; set; }

                /// <summary>
                /// 获取或设置品类全名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_full_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_full_name")]
                public string? CategoryFullName { get; set; }

                /// <summary>
                /// 获取或设置业务线类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_line")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_line")]
                public int BusinessLineType { get; set; }

                /// <summary>
                /// 获取或设置商家名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string? AccountName { get; set; }

                /// <summary>
                /// 获取或设置售卖开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sold_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("sold_start_time")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置售卖结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sold_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("sold_end_time")]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_url")]
                [System.Text.Json.Serialization.JsonPropertyName("out_url")]
                public string? OutUrl { get; set; }

                /// <summary>
                /// 获取或设置门店列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pois")]
                [System.Text.Json.Serialization.JsonPropertyName("pois")]
                public IList<Types.POI> POIList { get; set; } = new List<Types.POI>();

                /// <summary>
                /// 获取或设置属性键值对字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_key_value_map")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_key_value_map")]
                public IDictionary<string, string>? AttributeKeyValueMap { get; set; }
            }

            public class SKU
            {
                public static class Types
                {
                    public class Stock : GoodLifeGoodsStockSyncV1Request.Types.Stock
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
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = new Types.Product();

        /// <summary>
        /// 获取或设置 SKU 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku")]
        [System.Text.Json.Serialization.JsonPropertyName("sku")]
        public Types.SKU? SKU { get; set; }
    }
}
