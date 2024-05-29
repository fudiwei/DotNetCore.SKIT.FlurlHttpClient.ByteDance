namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/tag_query/ 接口的响应。</para>
    /// </summary>
    public class TradeBasicDeveloperTagQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TagGroup
                    {
                        public static class Types
                        {
                            public class Tag
                            {
                                /// <summary>
                                /// 获取或设置标签 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tag_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                                public string TagId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置标签名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tag_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置标签类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tag_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("tag_type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置标签描述列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tag_descs")]
                                [System.Text.Json.Serialization.JsonPropertyName("tag_descs")]
                                public string[] DescriptionList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置行业类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("biz_line")]
                                [System.Text.Json.Serialization.JsonPropertyName("biz_line")]
                                public int BusinessType { get; set; }

                                /// <summary>
                                /// 获取或设置商品类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_type")]
                                public int GoodsType { get; set; }
                            }

                            public class Rule
                            {
                                public static class Types
                                {
                                    public class RefundRule
                                    {
                                        /// <summary>
                                        /// 获取或设置业务状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("biz_status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("biz_status")]
                                        public string BusinessStatus { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商家审核类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_audit_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_audit_type")]
                                        public int MerchantAuditType { get; set; }

                                        /// <summary>
                                        /// 获取或设置退款类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("refund_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
                                        public int RefundType { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置规则 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rule_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
                                public string RuleId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置规则类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rule_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("rule_type")]
                                public int RuleType { get; set; }

                                /// <summary>
                                /// 获取或设置退款规则信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_rule")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_rule")]
                                public Types.RefundRule? RefundRule { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置标签组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_group_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_group_id")]
                        public string TagGroupId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                        public Types.Tag[] TagList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
                        public Types.Rule[]? RuleList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置标签组列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_detail_list")]
                public Types.TagGroup[] TagGroupList { get; set; } = default!;
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
