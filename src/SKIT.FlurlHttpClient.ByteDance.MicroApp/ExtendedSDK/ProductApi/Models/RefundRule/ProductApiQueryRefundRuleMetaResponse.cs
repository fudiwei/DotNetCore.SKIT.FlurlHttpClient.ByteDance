namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_refund_rule_meta 接口的响应。</para>
    /// </summary>
    public class ProductApiQueryRefundRuleMetaResponse : DouyinMicroAppProductApiResponse
    {
        public static class Types
        {
            public class RefundRule
            {
                /// <summary>
                /// 获取或设置规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置规则描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置规则详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("details")]
                [System.Text.Json.Serialization.JsonPropertyName("details")]
                public string Detail { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品退款规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.RefundRule[] RefundRuleList { get; set; } = default!;
    }
}
