namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/syncStock 接口的请求。</para>
    /// </summary>
    public class SKUSyncStockRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long SKUId { get; set; }

        /// <summary>
        /// 获取或设置外部仓 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string? OutWarehouseId { get; set; }

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
        /// 获取或设置幂等请求编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idempotent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("idempotent_id")]
        public string? IdempotentId { get; set; }

        /// <summary>
        /// 获取或设置幂等请求编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incremental")]
        [System.Text.Json.Serialization.JsonPropertyName("incremental")]
        public bool IsIncremental { get; set; }
    }
}
