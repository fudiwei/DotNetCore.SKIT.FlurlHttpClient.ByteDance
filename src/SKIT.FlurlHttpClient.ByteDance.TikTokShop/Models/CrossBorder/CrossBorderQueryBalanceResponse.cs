namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/queryBalance 接口的响应。</para>
    /// </summary>
    public class CrossBorderQueryBalanceResponse : TikTokShopResponse<CrossBorderQueryBalanceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Balance
                    {
                        /// <summary>
                        /// 获取或设置金额类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("balance_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("balance_type")]
                        public string BalanceType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置余额列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_list")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_list")]
                public Types.Balance[] BalanceList { get; set; } = default!;
            }
        }
    }
}
