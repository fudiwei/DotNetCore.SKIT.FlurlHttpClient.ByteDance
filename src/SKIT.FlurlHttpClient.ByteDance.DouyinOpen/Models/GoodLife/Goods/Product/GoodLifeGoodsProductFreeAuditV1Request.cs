namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/product/free_audit 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsProductFreeAuditV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

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
        /// 获取或设置售卖结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sold_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("sold_end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置库存数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_qty")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_qty")]
        public int? StockQuantity { get; set; }
    }
}
