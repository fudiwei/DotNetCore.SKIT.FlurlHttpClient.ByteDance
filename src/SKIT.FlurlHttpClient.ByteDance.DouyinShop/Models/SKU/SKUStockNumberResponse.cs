using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/stockNum 接口的响应。</para>
    /// </summary>
    public class SKUStockNumberResponse : DouyinShopResponse<SKUStockNumberResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
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
                [Newtonsoft.Json.JsonProperty("stock_num_map")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_num_map")]
                public IDictionary<string, int>? StockMap { get; set; }

                /// <summary>
                /// 获取或设置区域仓预占库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prehold_stock_map")]
                [System.Text.Json.Serialization.JsonPropertyName("prehold_stock_map")]
                public IDictionary<string, int>? PreholdStockMap { get; set; }

                /// <summary>
                /// 获取或设置区域仓中的发货时效或库存字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_rule_map")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_rule_map")]
                public IDictionary<string, int>? ShipRuleMap { get; set; }

                /// <summary>
                /// 获取或设置普通库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("normal_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("normal_stock_num")]
                public int NormalStockNumber { get; set; }

                /// <summary>
                /// 获取或设置渠道库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_stock_num")]
                public int ChannelStockNumber { get; set; }
            }
        }
    }
}
