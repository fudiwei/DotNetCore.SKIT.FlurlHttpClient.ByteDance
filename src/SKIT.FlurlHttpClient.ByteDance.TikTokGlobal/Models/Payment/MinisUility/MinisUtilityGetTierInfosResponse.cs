namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/utility/get_tier_infos/ 接口的响应。</para>
    /// </summary>
    public class MinisUtilityGetTierInfosResponse : TikTokV2Response<MinisUtilityGetTierInfosResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TierInfo
                    {
                        /// <summary>
                        /// 获取或设置等级 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tier_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tier_id")]
                        public string? TierId { get; set; }

                        /// <summary>
                        /// 获取或设置等级名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tier_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("tier_name")]
                        public string? TierName { get; set; }

                        /// <summary>
                        /// 获取或设置代币类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("token_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("token_type")]
                        public string? TokenType { get; set; }

                        /// <summary>
                        /// 获取或设置代币数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("token_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("token_amount")]
                        public int TokenAmount { get; set; }

                        /// <summary>
                        /// 获取或设置价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public string? Price { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string? Currency { get; set; }

                        /// <summary>
                        /// 获取或设置币种符号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("symbol")]
                        [System.Text.Json.Serialization.JsonPropertyName("symbol")]
                        public string? Symbol { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置等级信息字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tier_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("tier_infos")]
                public Dictionary<string, Types.TierInfo>? TierInfoMap { get; set; }
            }
        }
    }
}
