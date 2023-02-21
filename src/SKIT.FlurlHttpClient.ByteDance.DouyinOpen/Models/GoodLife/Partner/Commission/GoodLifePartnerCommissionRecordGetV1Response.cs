namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/partner/commission_record/get 接口的响应。</para>
    /// </summary>
    public class GoodLifePartnerCommissionRecordGetV1Response : DouyinOpenResponse<GoodLifePartnerCommissionRecordGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
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
                        [Newtonsoft.Json.JsonProperty("effective_commission_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("effective_commission_ratio")]
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
                /// 获取或设置佣金配置记录商品明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_record_items")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_record_items")]
                public Types.CommissionRecordItem[] CommissionRecordItemList { get; set; } = default!;
            }
        }
    }
}
