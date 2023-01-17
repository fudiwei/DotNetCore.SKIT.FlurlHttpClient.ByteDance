namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_deal_overview_data 接口的响应。</para>
    /// </summary>
    public class AppsDataAnalysisQueryDealOverviewDataV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DealOverviewData
                    {
                        /// <summary>
                        /// 获取或设置创建订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_count")]
                        public int CreateOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_count")]
                        public int PayOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_amount")]
                        public long CreateOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_amount")]
                        public long PayOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("success_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("success_user_cnt")]
                        public int SuccessUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_order_cnt")]
                        public int RefundOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置动销商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_product_cnt")]
                        public int SaleProductCount { get; set; }
                    }

                    public class DealData : DealOverviewData
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
                /// 获取或设置交易分析总览数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_overview_data")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_overview_data")]
                public Types.DealOverviewData DealOverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置交易分析每日数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_data_list")]
                public Types.DealData[] DealDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
