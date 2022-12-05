namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerOrderList 接口的响应。</para>
    /// </summary>
    public class IOPSellerOrderListResponse : DouyinShopResponse<IOPSellerOrderListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DistributeOrder
                    {
                        /// <summary>
                        /// 获取或设置厂商店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_id")]
                        public long SupplierShopId { get; set; }

                        /// <summary>
                        /// 获取或设置厂商店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_shop_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_name")]
                        public string SupplierShopName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置代打订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distr_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
                        public string DistributeOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_words")]
                        public string? SellerWords { get; set; }

                        /// <summary>
                        /// 获取或设置店铺订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
                        public string ShopOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        public long PayTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置分配时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distr_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("distr_time")]
                        public long DistributeTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置分配状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distr_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("distr_status")]
                        public int DistributeStatus { get; set; }

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public int OrderStatus { get; set; }

                        /// <summary>
                        /// 获取或设置售后状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_status")]
                        public int AftersaleStatus { get; set; }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string ProductName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_count")]
                        public int ProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                        public int ProductPrice { get; set; }

                        /// <summary>
                        /// 获取或设置商家 SKU 编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string? OuterSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 规格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_spec")]
                        public string? SKUSpecification { get; set; }

                        /// <summary>
                        /// 获取或设置收件人 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_id")]
                        public string ReceiverId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置省份 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("province_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ProvinceId { get; set; }

                        /// <summary>
                        /// 获取或设置省份名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string ProvinceName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CityId { get; set; }

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string CityName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("district_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("district_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int DistrictId { get; set; }

                        /// <summary>
                        /// 获取或设置区县名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("district")]
                        [System.Text.Json.Serialization.JsonPropertyName("district")]
                        public string DistrictName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置街道 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("street_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("street_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? StreetId { get; set; }

                        /// <summary>
                        /// 获取或设置街道名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("street")]
                        [System.Text.Json.Serialization.JsonPropertyName("street")]
                        public string? StreetName { get; set; }

                        /// <summary>
                        /// 获取或设置承诺发货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exp_ship_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("exp_ship_time")]
                        public long? ExpectedShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tracking_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                        public string? LogisticsNumber { get; set; }

                        /// <summary>
                        /// 获取或设置物流公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                        public string? LogisticsCompanyName { get; set; }

                        /// <summary>
                        /// 获取或设置取消原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distr_cancel_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("distr_cancel_reason")]
                        public string? CancelReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置代打订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distr_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("distr_order_list")]
                public Types.DistributeOrder[] DistributeOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int PageSize { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
