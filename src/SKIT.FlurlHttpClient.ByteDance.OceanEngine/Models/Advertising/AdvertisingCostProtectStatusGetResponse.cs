namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/ad/cost_protect_status/get 接口的响应。</para>
    /// </summary>
    public class AdvertisingCostProtectStatusGetResponse : OceanEngineResponse<AdvertisingCostProtectStatusGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置广告计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                        public long AdvertisingId { get; set; }

                        /// <summary>
                        /// 获取或设置计划成本保障状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置审核建议列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public static Types.Item[] List { get; set; } = default!;
            }
        }
    }
}
