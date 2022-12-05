namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qualityList 接口的响应。</para>
    /// </summary>
    public class ProductQualityListResponse : DouyinShopResponse<ProductQualityListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Quality
                    {
                        public static class Types
                        {
                            public class ProblemTypeDistribution
                            {
                                /// <summary>
                                /// 获取或设置优化项具体名字。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("type_name")]
                                public string TypeName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置具体问题数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("num")]
                                [System.Text.Json.Serialization.JsonPropertyName("num")]
                                public int Count { get; set; }
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
                        /// 获取或设置待优化项数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problem_num_to_improve")]
                        [System.Text.Json.Serialization.JsonPropertyName("problem_num_to_improve")]
                        public int ProblemToImproveTotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置问题类型分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problem_type_distribution")]
                        [System.Text.Json.Serialization.JsonPropertyName("problem_type_distribution")]
                        public Types.ProblemTypeDistribution[]? ProblemTypeDistributionList { get; set; }

                        /// <summary>
                        /// 获取或设置商品达标状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("meet_standard")]
                        [System.Text.Json.Serialization.JsonPropertyName("meet_standard")]
                        public int MeetStandard { get; set; }

                        /// <summary>
                        /// 获取或设置商品基础分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("base_score")]
                        [System.Text.Json.Serialization.JsonPropertyName("base_score")]
                        public int BaseScore { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品质量列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quality_list")]
                [System.Text.Json.Serialization.JsonPropertyName("quality_list")]
                public Types.Quality[] QualityList { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺待优化商品总量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
