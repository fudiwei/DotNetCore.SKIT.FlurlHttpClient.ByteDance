using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/list 接口的响应。</para>
    /// </summary>
    public class SKUListResponse : DouyinShopResponse<SKUListResponse.Types.SKU[]>
    {
        public static class Types
        {
            public class SKU
            {
                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置外部 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                public long OutSKUId { get; set; }

                /// <summary>
                /// 获取或设置 SKU Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string SKUCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_type")]
                public int SKUType { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id_str")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id_str")]
                public string ProductIdString { get; set; } = default!;

                /// <summary>
                /// 获取或设置规格组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_id")]
                public int SpecificationId { get; set; }

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

                /// <summary>
                /// 获取或设置一级规格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_detail_name1")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_detail_name1")]
                public string SpecificationDetailName1 { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级规格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_detail_name2")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_detail_name2")]
                public string SpecificationDetailName2 { get; set; } = default!;

                /// <summary>
                /// 获取或设置三级规格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_detail_name3")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_detail_name3")]
                public string SpecificationDetailName3 { get; set; } = default!;

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                public int? StockNumber { get; set; }

                /// <summary>
                /// 获取或设置阶梯库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("step_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("step_stock_num")]
                public int? StepStockNumber { get; set; }

                /// <summary>
                /// 获取或设置预占库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prehold_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("prehold_stock_num")]
                public int? PreholdStockNumber { get; set; }

                /// <summary>
                /// 获取或设置阶梯预占库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prehold_step_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("prehold_step_stock_num")]
                public int? PreholdStepStockNumber { get; set; }

                /// <summary>
                /// 获取或设置活动库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prom_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("prom_stock_num")]
                public int? PromotionStockNumber { get; set; }

                /// <summary>
                /// 获取或设置活动阶梯库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prom_step_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("prom_step_stock_num")]
                public int? PromotionStepStockNumber { get; set; }

                /// <summary>
                /// 获取或设置区域仓库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_map")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_map")]
                public IDictionary<string, int>? StockMap { get; set; }

                /// <summary>
                /// 获取或设置区域仓预占库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prehold_stock_map")]
                [System.Text.Json.Serialization.JsonPropertyName("prehold_stock_map")]
                public IDictionary<string, int>? PreholdStockMap { get; set; }

                /// <summary>
                /// 获取或设置价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置供应商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string? SupplierId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }
    }
}
