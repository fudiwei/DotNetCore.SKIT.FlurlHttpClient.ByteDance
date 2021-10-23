namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/budget/get 接口的响应。</para>
    /// </summary>
    public class AdvertiserBudgetGetResponse : OceanEngineResponse<AdvertiserBudgetGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Budget
                    {
                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置预算（单位：原）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("budget")]
                        [System.Text.Json.Serialization.JsonPropertyName("budget")]
                        public double BudgetAmount { get; set; }

                        /// <summary>
                        /// 获取或设置预算类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("budget_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("budget_mode")]
                        public string BudgetMode { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置预算列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Budget[] BudgetList { get; set; } = default!;
            }
        }
    }
}
