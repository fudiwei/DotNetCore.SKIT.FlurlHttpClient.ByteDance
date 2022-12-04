namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/talent/media/list 接口的响应。</para>
    /// </summary>
    public class POICommonPlanTalentMediaListResponse : TikTokResponse<POICommonPlanTalentMediaListResponse.Types.Data>
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
                        /// 获取或设置达人带货场景。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_type")]
                        public int ContentType { get; set; }

                        /// <summary>
                        /// 获取或设置达人带货场景 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_open_id")]
                        public string ContentOpenId { get; set; } = default!;

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
                        /// 获取或设置观看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("play_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("play_cnt")]
                        public int PlayCount { get; set; }

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
