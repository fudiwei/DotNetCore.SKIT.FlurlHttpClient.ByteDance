namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_live_deal_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryLiveDealDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LiveDealOverviewData
                    {
                        /// <summary>
                        /// 获取或设置点击次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("click_count")]
                        public int ClickCount { get; set; }

                        /// <summary>
                        /// 获取或设置曝光次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("show_count")]
                        public int ShowCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_count")]
                        public int CreateOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_user_count")]
                        public int CreateUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_amount")]
                        public long CreateOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_count")]
                        public int PayOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("success_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("success_user_cnt")]
                        public int PayUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_amount")]
                        public long PayOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_order_cnt")]
                        public int RefundOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_order_amount")]
                        public long RefundOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_success_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_success_order_cnt")]
                        public int RefundSuccessOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_success_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_success_user_cnt")]
                        public int RefundSuccessUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_success_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_success_order_amount")]
                        public long RefundSuccessOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置动销商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_product_cnt")]
                        public int SaleProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置客单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_once_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_once_price")]
                        public long CustomerOncePrice { get; set; }

                        /// <summary>
                        /// 获取或设置单均价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_once_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_once_price")]
                        public long OrderOncePrice { get; set; }
                    }

                    public class LiveDealData : LiveDealOverviewData
                    {
                        /// <summary>
                        /// 获取或设置时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public string TimeString { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置直播交易总览数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_overview_data")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_overview_data")]
                public Types.LiveDealOverviewData LiveDealOverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播交易数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_data_list")]
                public Types.LiveDealData[] LiveDealDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
