namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/applyLogisticsIntercept 接口的响应。</para>
    /// </summary>
    public class AftersaleApplyLogisticsInterceptResponse : DouyinShopResponse<AftersaleApplyLogisticsInterceptResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class InterceptResult
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string ProductOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_image")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_image")]
                                public string ProductImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品规格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_spec")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_spec")]
                                public string ProductSpecification { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品标签列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tags")]
                                [System.Text.Json.Serialization.JsonPropertyName("tags")]
                                public string[]? TagList { get; set; }

                                /// <summary>
                                /// 获取或设置单价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int Price { get; set; }

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public int Count { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置物流公司编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                        public string CompanyCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物流公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                        public string CompanyName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tracking_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                        public string LogisticsNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹价值（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_amount")]
                        public int ValueAmount { get; set; }

                        /// <summary>
                        /// 获取或设置是否可拦截。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_intercept")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_intercept")]
                        public bool? CanIntercept { get; set; }

                        /// <summary>
                        /// 获取或设置是否拦截成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_success")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_success")]
                        public bool? IsSuccessful { get; set; }

                        /// <summary>
                        /// 获取或设置不可拦截编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unavailable_reason_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("unavailable_reason_code")]
                        public int UnavailableReasonCode { get; set; }

                        /// <summary>
                        /// 获取或设置不可拦截编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unavailable_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("unavailable_reason")]
                        public string? UnavailableReason { get; set; }

                        /// <summary>
                        /// 获取或设置拦截费用（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intercept_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("intercept_cost")]
                        public int? InterceptCost { get; set; }

                        /// <summary>
                        /// 获取或设置当前售后商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cur_product")]
                        [System.Text.Json.Serialization.JsonPropertyName("cur_product")]
                        public Types.Product CurrentProduct { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置其它商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("other_products")]
                        [System.Text.Json.Serialization.JsonPropertyName("other_products")]
                        public Types.Product[]? OtherProduct { get; set; }

                        /// <summary>
                        /// 获取或设置其他商品件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("other_product_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("other_product_amount")]
                        public int OtherProductCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置物流拦截结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intercept_results")]
                [System.Text.Json.Serialization.JsonPropertyName("intercept_results")]
                public Types.InterceptResult[] InterceptResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置拦截成功次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_count")]
                [System.Text.Json.Serialization.JsonPropertyName("success_count")]
                public int SuccessCount { get; set; }

                /// <summary>
                /// 获取或设置拦截失败次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_count")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_count")]
                public int FailCount { get; set; }

                /// <summary>
                /// 获取或设置不可拦截编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unavailable_reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("unavailable_reason_code")]
                public int UnavailableReasonCode { get; set; }

                /// <summary>
                /// 获取或设置不可拦截编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unavailable_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("unavailable_reason")]
                public string? UnavailableReason { get; set; }

                /// <summary>
                /// 获取或设置售后单退款总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }
            }
        }
    }
}
