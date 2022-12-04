using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/detail 接口的响应。</para>
    /// </summary>
    public class POICommonPlanDetailResponse : TikTokResponse<POICommonPlanDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("plan_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
                        public long PlanId { get; set; }

                        /// <summary>
                        /// 获取或设置带货 GMV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("gmv")]
                        public int GMV { get; set; }

                        /// <summary>
                        /// 获取或设置已核销 GMV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("used_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("used_gmv")]
                        public int UsedGMV { get; set; }

                        /// <summary>
                        /// 获取或设置达人佣金（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_commission")]
                        public int TalentCommission { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据产出日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划带货数据字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public IDictionary<string, Types.Data> DataMap { get; set; } = default!;
            }
        }
    }
}
