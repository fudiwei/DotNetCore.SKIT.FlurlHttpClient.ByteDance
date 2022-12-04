namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/plan/list 接口的响应。</para>
    /// </summary>
    public class POIPlanListResponse : TikTokResponse<POIPlanListResponse.Types.Data>
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
                        /// 获取或设置计划状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置达人带货场景。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_type")]
                        public int ContentType { get; set; }

                        /// <summary>
                        /// 获取或设置达人佣金率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                        public int CommissionRate { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据产出日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置通用佣金计划列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Data[] DataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置总页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_count")]
                [System.Text.Json.Serialization.JsonPropertyName("page_count")]
                public int PageCount { get; set; }
            }
        }
    }
}
