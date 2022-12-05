namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/OpenAfterSaleChannel 接口的响应。</para>
    /// </summary>
    public class AftersaleOpenAfterSaleChannelResponse : DouyinShopResponse<AftersaleOpenAfterSaleChannelResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Conclusion
                    {
                        /// <summary>
                        /// 获取或设置匹配是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_success")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_success")]
                        public bool IsMatchSucceeded { get; set; }

                        /// <summary>
                        /// 获取或设置匹配到超级售后的类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_conclusion")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_conclusion")]
                        public int MatchConclusion { get; set; }

                        /// <summary>
                        /// 获取或设置匹配结果的解释。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_message")]
                        public string? MatchMessage { get; set; }

                        /// <summary>
                        /// 获取或设置可以发起的售后类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_apply_type_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_apply_type_list")]
                        public int[]? CanApplyTypeLsit { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置匹配信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conclusion")]
                [System.Text.Json.Serialization.JsonPropertyName("conclusion")]
                public Types.Conclusion Conclusion { get; set; } = default!;
            }
        }
    }
}
