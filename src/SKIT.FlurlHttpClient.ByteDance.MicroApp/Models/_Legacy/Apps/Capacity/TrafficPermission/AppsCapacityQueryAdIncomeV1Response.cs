namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_ad_income 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryAdIncomeV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class IncomeData
                    {
                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收入金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("income")]
                        [System.Text.Json.Serialization.JsonPropertyName("income")]
                        public int Income { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收入数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income_list")]
                [System.Text.Json.Serialization.JsonPropertyName("income_list")]
                public Types.IncomeData[] IncomeDataList { get; set; } = default!;
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
