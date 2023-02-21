namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/partner/product_commission/query 接口的响应。</para>
    /// </summary>
    public class GoodLifePartnerProductCommissionQueryV1Response : DouyinOpenResponse<GoodLifePartnerProductCommissionQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class ProductCommission
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_status")]
                                public int ProductStatus { get; set; }

                                /// <summary>
                                /// 获取或设置商品售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_price")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int ActualPrice { get; set; }

                                /// <summary>
                                /// 获取或设置生效中的商品分佣比例（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("effective_commission_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("effective_commission_ratio")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? EffectiveCommissionRatio { get; set; }

                                /// <summary>
                                /// 获取或设置商品佣金状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_commission_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_commission_status")]
                                public int ProductCommissionStatus { get; set; }
                            }

                            public class CommissionRecordItem
                            {
                                /// <summary>
                                /// 获取或设置记录 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                                public string ItemId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核中的商品分佣比例（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_commission_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_commission_ratio")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? AuditCommissionRatio { get; set; }

                                /// <summary>
                                /// 获取或设置生效中的商品分佣比例（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_ratio_before")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_ratio_before")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? EffectiveCommissionRatio { get; set; }

                                /// <summary>
                                /// 获取或设置佣金审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_audit_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_audit_status")]
                                public int CommissionAuditStatus { get; set; }

                                /// <summary>
                                /// 获取或设置商家确认或拒绝时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_ack_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_ack_time")]
                                public long? MerchantAcknowledgeTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product")]
                        [System.Text.Json.Serialization.JsonPropertyName("product")]
                        public Types.Product Product { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置最近一次的佣金配置记录商品明细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latest_commission_record_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("latest_commission_record_item")]
                        public Types.CommissionRecordItem? CommissionRecordItem { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_commissions")]
                [System.Text.Json.Serialization.JsonPropertyName("product_commissions")]
                public Types.ProductCommission[] ProductCommissionList { get; set; } = default!;

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
