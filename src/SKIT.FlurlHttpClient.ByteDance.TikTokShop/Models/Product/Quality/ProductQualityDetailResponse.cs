namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qualityDetail 接口的响应。</para>
    /// </summary>
    public class ProductQualityDetailResponse : TikTokShopResponse<ProductQualityDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Problem
                    {
                        /// <summary>
                        /// 获取或设置字段 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_key")]
                        public string FieldKey { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_name")]
                        public string FieldName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problem_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("problem_key")]
                        public int ProblemKey { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problem_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("problem_name")]
                        public string ProblemName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problem_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("problem_type")]
                        public int ProblemType { get; set; }

                        /// <summary>
                        /// 获取或设置问题建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("suggestion")]
                        [System.Text.Json.Serialization.JsonPropertyName("suggestion")]
                        public string Suggestion { get; set; } = default!;
                    }
                }

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
                /// 获取或设置可优化问题项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_problem")]
                [System.Text.Json.Serialization.JsonPropertyName("field_problem")]
                public Types.Problem[] ProblemList { get; set; } = default!;
            }
        }
    }
}
