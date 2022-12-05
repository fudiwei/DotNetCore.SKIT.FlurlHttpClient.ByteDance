using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/talent/detail 接口的响应。</para>
    /// </summary>
    public class POICommonPlanTalentDetailResponse : DouyinOpenResponse<POICommonPlanTalentDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Data
                    {
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
                        /// 获取或设置直播间数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_cnt")]
                        public int LiveCount { get; set; }

                        /// <summary>
                        /// 获取或设置短视频数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("short_video_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("short_video_cnt")]
                        public int ShortVideoCount { get; set; }

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
                /// 获取或设置达人带货数据字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public IDictionary<string, Types.Data> DataMap { get; set; } = default!;
            }
        }
    }
}
