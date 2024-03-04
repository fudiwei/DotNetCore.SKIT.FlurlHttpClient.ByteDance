namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/fund/daily_stat 接口的响应。</para>
    /// </summary>
    public class AdvertiserFundDailyStatisticsResponse : OceanEngineResponse<AdvertiserFundDailyStatisticsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Statistics
                    {
                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日终结余（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("balance")]
                        [System.Text.Json.Serialization.JsonPropertyName("balance")]
                        public decimal Balance { get; set; }

                        /// <summary>
                        /// 获取或设置总支出（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost")]
                        public decimal TotalCost { get; set; }

                        /// <summary>
                        /// 获取或设置现金支出（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cash_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("cash_cost")]
                        public decimal CashCost { get; set; }

                        /// <summary>
                        /// 获取或设置赠款支出（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reward_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("reward_cost")]
                        public decimal GrantCost { get; set; }

                        /// <summary>
                        /// 获取或设置共享钱包支出（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shared_wallet_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("shared_wallet_cost")]
                        public decimal SharedWalletCost { get; set; }

                        /// <summary>
                        /// 获取或设置冻结金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("frozen")]
                        [System.Text.Json.Serialization.JsonPropertyName("frozen")]
                        public decimal FrozenFee { get; set; }

                        /// <summary>
                        /// 获取或设置总存入（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("income")]
                        [System.Text.Json.Serialization.JsonPropertyName("income")]
                        public decimal Income { get; set; }

                        /// <summary>
                        /// 获取或设置总转入（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transfer_in")]
                        [System.Text.Json.Serialization.JsonPropertyName("transfer_in")]
                        public decimal TransferInAmount { get; set; }

                        /// <summary>
                        /// 获取或设置总转出（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transfer_out")]
                        [System.Text.Json.Serialization.JsonPropertyName("transfer_out")]
                        public decimal TransferOutAmount { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Statistics[] StatisticsList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
