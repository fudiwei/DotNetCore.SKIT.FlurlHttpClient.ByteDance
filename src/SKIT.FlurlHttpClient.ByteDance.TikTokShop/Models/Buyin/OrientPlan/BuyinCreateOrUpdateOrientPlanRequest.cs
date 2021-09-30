namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/createOrUpdateOrienPlan 接口的请求。</para>
    /// </summary>
    public class BuyinCreateOrUpdateOrientPlanRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class OrientPlan
            {
                /// <summary>
                /// 获取或设置定向计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orien_plan_id")]
                [System.Text.Json.Serialization.JsonPropertyName("orien_plan_id")]
                public string? OrientPlanId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long? ProductId { get; set; }

                /// <summary>
                /// 获取或设置佣金比例（范围：0～80）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cos_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("cos_ratio")]
                public double? COSRatio { get; set; }

                /// <summary>
                /// 获取或设置申请类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_type")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_type")]
                public int? ApplyType { get; set; }

                /// <summary>
                /// 获取或设置限制类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("restricted_type")]
                [System.Text.Json.Serialization.JsonPropertyName("restricted_type")]
                public int? RestrictedType { get; set; }

                /// <summary>
                /// 获取或设置达人等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("author_level")]
                [System.Text.Json.Serialization.JsonPropertyName("author_level")]
                public int? AuthorLevel { get; set; }

                /// <summary>
                /// 获取或设置审核类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_type")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_type")]
                public int? AuditType { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否是创建。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_create")]
        [System.Text.Json.Serialization.JsonPropertyName("is_create")]
        public bool IsCreating { get; set; }

        /// <summary>
        /// 获取或设置定向计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan")]
        [System.Text.Json.Serialization.JsonPropertyName("plan")]
        public Types.OrientPlan OrientPlan { get; set; } = new Types.OrientPlan();
    }
}
