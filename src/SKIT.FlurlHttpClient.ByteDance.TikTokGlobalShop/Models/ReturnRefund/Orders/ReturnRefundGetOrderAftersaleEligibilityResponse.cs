namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /return_refund/{version}/orders/{order_id}/aftersale_eligibility 接口的响应。</para>
    /// </summary>
    public class ReturnRefundGetOrderAftersaleEligibilityResponse : TikTokShopResponse<ReturnRefundGetOrderAftersaleEligibilityResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SKUEligibility
                    {
                        public static class Types
                        {
                            public class LineItemEligibility
                            {
                                /// <summary>
                                /// 获取或设置订单行 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_line_items_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_line_items_ids")]
                                public string[] OrderLineItemIdList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否有资格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("eligible")]
                                [System.Text.Json.Serialization.JsonPropertyName("eligible")]
                                public bool IsEligible { get; set; }

                                /// <summary>
                                /// 获取或设置无资格原因代码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ineligible_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("ineligible_code")]
                                public int? IneligibleCode { get; set; }

                                /// <summary>
                                /// 获取或设置无资格原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ineligible_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("ineligible_reason")]
                                public string? IneligibleReason { get; set; }

                                /// <summary>
                                /// 获取或设置申请类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("request_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("request_type")]
                                public string? RequestType { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资格列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("line_item_eligibility")]
                        [System.Text.Json.Serialization.JsonPropertyName("line_item_eligibility")]
                        public Types.LineItemEligibility[] LineItemEligibilityList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置资格列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_eligibility")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_eligibility")]
                public Types.SKUEligibility[] SKUEligibilityList { get; set; } = default!;
            }
        }
    }
}
