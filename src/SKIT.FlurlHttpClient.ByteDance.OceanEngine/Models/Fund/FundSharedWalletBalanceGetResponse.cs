namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/fund/shared_wallet_balance/get 接口的响应。</para>
    /// </summary>
    public class FundSharedWalletBalanceGetResponse : OceanEngineResponse<FundSharedWalletBalanceGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SharedWallet
                    {
                        public static class Types
                        {
                            public class BalanceDetail
                            {
                                /// <summary>
                                /// 获取或设置余额（单位：元）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("balance")]
                                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                                public double Balance { get; set; }

                                /// <summary>
                                /// 获取或设置余额可用广告位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("billing_inventory")]
                                [System.Text.Json.Serialization.JsonPropertyName("billing_inventory")]
                                public string? BillingInventory { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置余额查询状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置余额查询状态说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("status_message")]
                        public string StatusMessage { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置余额详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("balance_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("balance_detail")]
                        public Types.BalanceDetail[] BalanceDetailList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置共享钱包列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.SharedWallet[] SharedWalletList { get; set; } = default!;
            }
        }
    }
}
