namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanList 接口的响应。</para>
    /// </summary>
    public class BuyinOrientPlanListResponse : DouyinShopResponse<BuyinOrientPlanListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductOrientPlan
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
                                public string OrientPlanId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品封面 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cover")]
                                [System.Text.Json.Serialization.JsonPropertyName("cover")]
                                public string ProductCoverUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int ProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置计划状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("plan_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("plan_status")]
                                public int PlanStatus { get; set; }

                                /// <summary>
                                /// 获取或设置佣金比例（范围：0～80）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cos_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("cos_ratio")]
                                public double COSRatio { get; set; }

                                /// <summary>
                                /// 获取或设置申请类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("apply_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("apply_type")]
                                public int ApplyType { get; set; }

                                /// <summary>
                                /// 获取或设置限制类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("restricted_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("restricted_type")]
                                public int RestrictedType { get; set; }

                                /// <summary>
                                /// 获取或设置达人等级。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_level")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_level")]
                                public int AuthorLevel { get; set; }

                                /// <summary>
                                /// 获取或设置审核类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_type")]
                                public int AuditType { get; set; }

                                /// <summary>
                                /// 获取或设置达人人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("kol_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("kol_num")]
                                public int KOLCount { get; set; }

                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置过期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long EndTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置修改后的佣金比例（范围：0～80）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_cos_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_cos_ratio")]
                                public double? NewCOSRatio { get; set; }

                                /// <summary>
                                /// 获取或设置修改后的佣金比例生效时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_cos_ratio_start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_cos_ratio_start_time")]
                                public long? NewCOSRatioStartTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置定向计划列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("orien_plans")]
                        [System.Text.Json.Serialization.JsonPropertyName("orien_plans")]
                        public Types.OrientPlan[] OrientPlanList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品定向计划列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orien_plans")]
                [System.Text.Json.Serialization.JsonPropertyName("orien_plans")]
                public Types.ProductOrientPlan[] ProductOrientPlanList { get; set; } = default!;

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
