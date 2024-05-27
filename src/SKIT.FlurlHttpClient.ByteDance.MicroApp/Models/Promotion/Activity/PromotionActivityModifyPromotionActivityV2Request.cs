namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/activity/modify_promotion_activity/ 接口的请求。</para>
    /// </summary>
    public class PromotionActivityModifyPromotionActivityV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class Activity
            {
                public static class Types
                {
                    public class LiveActivity
                    {
                        /// <summary>
                        /// 获取或设置线索组件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("clue_component_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("clue_component_id")]
                        public string? ClueComponentId { get; set; }

                        /// <summary>
                        /// 获取或设置发放须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notice_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("notice_text")]
                        public string? NoticeText { get; set; }
                    }

                    public class IMActivity
                    {
                        /// <summary>
                        /// 获取或设置活动生效开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public long? ValidBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置活动生效结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long? ValidEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置发放须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notice_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("notice_text")]
                        public string? NoticeText { get; set; }
                    }

                    public class SidebarActivity
                    {
                        /// <summary>
                        /// 获取或设置活动生效开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public long? ValidBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置活动生效结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long? ValidEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置高价值区展示的内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("high_value_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("high_value_content")]
                        public string? HighValueContent { get; set; }

                        /// <summary>
                        /// 获取或设置跳转按钮展示的内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("jump_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("jump_text")]
                        public string? JumpText { get; set; }

                        /// <summary>
                        /// 获取或设置最近使用区小程序右上角气泡展示的内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recent_bubble_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("recent_bubble_text")]
                        public string? RecentBubbleText { get; set; }

                        /// <summary>
                        /// 获取或设置短标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("short_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("short_title")]
                        public string? ShortTitle { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string ActivityId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置活动名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                public string? ActivityName { get; set; }

                /// <summary>
                /// 获取或设置直播间发放场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_activity")]
                [System.Text.Json.Serialization.JsonPropertyName("live_activity")]
                public Types.LiveActivity? LiveActivity { get; set; }

                /// <summary>
                /// 获取或设置 IM 私域发放场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("im_activity")]
                [System.Text.Json.Serialization.JsonPropertyName("im_activity")]
                public Types.IMActivity? IMActivity { get; set; }

                /// <summary>
                /// 获取或设置复访发放场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sidebar_activity")]
                [System.Text.Json.Serialization.JsonPropertyName("sidebar_activity")]
                public Types.SidebarActivity? SidebarActivity { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置活动信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_activity")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_activity")]
        public Types.Activity Activity { get; set; } = new Types.Activity();
    }
}
