namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerOrderList 接口的请求。</para>
    /// </summary>
    public class IOPSellerOrderListRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置更新时间开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_update_time")]
        public long StartUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置更新时间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_update_time")]
        public long EndUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单成交开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_deal_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_deal_time")]
        public long? StartDealTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单成交结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_deal_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_deal_time")]
        public long? EndDealTimestamp { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 获取或设置店铺订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        public string? ShopOrderId { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置代打订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
        public string? DistributeOrderId { get; set; }

        /// <summary>
        /// 获取或设置分配状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_status")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_status")]
        public int? DistributeStatus { get; set; }

        /// <summary>
        /// 获取或设置售后状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_status")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_status")]
        public int? AftersaleStatus { get; set; }

        /// <summary>
        /// 获取或设置厂商店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_id")]
        public long? SupplierShopId { get; set; }

        /// <summary>
        /// 获取或设置省份 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_id")]
        [System.Text.Json.Serialization.JsonPropertyName("province_id")]
        public int? ProvinceId { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int PageSize { get; set; } = 10;
    }
}
