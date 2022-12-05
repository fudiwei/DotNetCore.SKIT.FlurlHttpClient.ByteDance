namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/stock/sync 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsStockSyncV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Stock
            {
                /// <summary>
                /// 获取或设置总库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_qty")]
                public int? TotalStock { get; set; }

                /// <summary>
                /// 获取或设置可用库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avail_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("avail_qty")]
                public int? AvailableStock { get; set; }

                /// <summary>
                /// 获取或设置库存上限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_type")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_type")]
                public int LimitType { get; set; }
            }
        }

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
        /// 获取或设置库存信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public Types.Stock Stock { get; set; } = new Types.Stock();
    }
}
