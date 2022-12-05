namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /alliance/getOrderList 接口的响应。</para>
    /// </summary>
    public class AllianceGetOrderListResponse : DouyinShopResponse<AllianceGetOrderListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置产品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置达人账户。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("author_account")]
                        public string AuthorAccount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置达人 ShortId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("short_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("short_id")]
                        public string AuthorShortId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_pay_amount")]
                        public int TotalPayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置佣金率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                        public int CommissionRate { get; set; }

                        /// <summary>
                        /// 获取或设置预估佣金（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("estimated_comission")]
                        [System.Text.Json.Serialization.JsonPropertyName("estimated_comission")]
                        public int EstimatedComission { get; set; }

                        /// <summary>
                        /// 获取或设置真实佣金（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("real_comission")]
                        [System.Text.Json.Serialization.JsonPropertyName("real_comission")]
                        public int ActualComission { get; set; }

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public string OrderStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置阶段单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phase_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("phase_id")]
                        public int PhaseId { get; set; }

                        /// <summary>
                        /// 获取或设置业务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("alliance_biz_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("alliance_biz_type")]
                        public string AllianceBusinessType { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置返回编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string ReturnCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置返回信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("code_msg")]
                public string? ReturnMessage { get; set; }

                /// <summary>
                /// 获取或设置订单明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datas")]
                [System.Text.Json.Serialization.JsonPropertyName("datas")]
                public Types.Order[] OrderList { get; set; } = default!;
            }
        }
    }
}
