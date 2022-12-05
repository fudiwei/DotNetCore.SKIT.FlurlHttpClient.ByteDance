namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/stockNum 接口的请求。</para>
    /// </summary>
    public class SKUStockNumberRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置 SKU ID。与字段 <see cref="SKUCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }

        /// <summary>
        /// 获取或设置 SKU Code。与字段 <see cref="SKUId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? SKUCode { get; set; }

        /// <summary>
        /// 获取或设置外部仓 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string? OutWarehouseId { get; set; }
    }
}
