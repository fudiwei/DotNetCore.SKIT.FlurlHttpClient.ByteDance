using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update/budget 接口的请求。</para>
    /// </summary>
    public class AdvertisingUpdateBudgetRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class AdBudget
            {
                /// <summary>
                /// 获取或设置广告计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                public long AdvertisingId { get; set; }

                /// <summary>
                /// 获取或设置预算（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("budget")]
                [System.Text.Json.Serialization.JsonPropertyName("budget")]
                public double Budget { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置广告计划预算列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.AdBudget> AdBudgetList { get; set; } = new List<Types.AdBudget>();
    }
}
