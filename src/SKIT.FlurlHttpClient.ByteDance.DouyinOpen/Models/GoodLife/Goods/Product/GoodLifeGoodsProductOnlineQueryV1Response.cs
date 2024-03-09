using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/product/online/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsProductOnlineQueryV1Response : DouyinOpenResponse<GoodLifeGoodsProductOnlineQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class ProductInfo
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                public static class Types
                                {
                                    public class POI : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft.Types.Product.Types.POI
                                    {
                                    }
                                }
                                
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品外部 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_id")]
                                public string OutProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

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
                                /// 获取或设置创建者商家 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("creator_account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("creator_account_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string? CreatorAccountId { get; set; }

                                /// <summary>
                                /// 获取或设置所有者商家 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("owner_account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("owner_account_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string? OwnerAccountId { get; set; }

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
                                public Types.POI[] POIList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性键值对字典。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attr_key_value_map")]
                                [System.Text.Json.Serialization.JsonPropertyName("attr_key_value_map")]
                                public IDictionary<string, string>? AttributeKeyValueMap { get; set; }

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }

                            public class SKU
                            {
                                public static class Types
                                {
                                    public class Stock : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft.Types.SKU.Types.Stock
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 外部 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                                public string OutSKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                                public string SKUName { get; set; } = default!;

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
                                public Types.Stock Stock { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置原价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("origin_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("origin_amount")]
                                public int OriginalAmount { get; set; }

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

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }

                            public class Commission
                            {
                                /// <summary>
                                /// 获取或设置平台分佣率（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_take_rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_take_rate")]
                                public decimal PlatformTakeRate { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置上线状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("online_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("online_status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product")]
                        [System.Text.Json.Serialization.JsonPropertyName("product")]
                        public Types.Product Product { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU? SKU { get; set; }

                        /// <summary>
                        /// 获取或设置分佣信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                        public Types.Commission? Commission { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.ProductInfo[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
                public string? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
