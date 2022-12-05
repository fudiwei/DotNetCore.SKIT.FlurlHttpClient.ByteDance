namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/talent/list 接口的响应。</para>
    /// </summary>
    public class POICommonPlanTalentListResponse : DouyinOpenResponse<POICommonPlanTalentListResponse.Types.Data>
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
                        /// 获取或设置达人带货场景。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_type")]
                        public int ContentType { get; set; }

                        /// <summary>
                        /// 获取或设置达人抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("douyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
                        public string DouyinId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置达人抖音昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置带货 GMV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("gmv")]
                        public int GMV { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据产出日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人带货数据列表。
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
