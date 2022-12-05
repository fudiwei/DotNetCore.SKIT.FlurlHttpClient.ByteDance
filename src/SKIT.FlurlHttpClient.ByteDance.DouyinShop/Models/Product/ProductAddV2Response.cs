using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/addV2 接口的响应。</para>
    /// </summary>
    public class ProductAddV2Response : DouyinShopResponse<ProductAddV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置外部 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public long OutSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 商家编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outer_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("outer_sku_id")]
                        public string OuterSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU Code。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string SKUCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置一级规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id1")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id1")]
                        public long SpecificationDetailId1 { get; set; }

                        /// <summary>
                        /// 获取或设置二级规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id2")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id2")]
                        public long SpecificationDetailId2 { get; set; }

                        /// <summary>
                        /// 获取或设置三级规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id3")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id3")]
                        public long SpecificationDetailId3 { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置外部商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public long OutProductId { get; set; }

                /// <summary>
                /// 获取或设置外部商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_product_id")]
                public string OuterProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku")]
                [System.Text.Json.Serialization.JsonPropertyName("sku")]
                public Types.SKU[] SKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }
    }
}
