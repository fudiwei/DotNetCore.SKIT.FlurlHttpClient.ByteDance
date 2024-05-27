namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/activity/query_promotion_activity/ 接口的响应。</para>
    /// </summary>
    public class PromotionActivityQueryPromotionActivityV2Response : DouyinMicroAppResponse
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
                        /// 获取或设置用户领券玩法。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_task_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_task_type")]
                        public int CouponTaskType { get; set; }

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
                        public static class Types
                        {
                            public class ShareFissionConfig
                            {
                                /// <summary>
                                /// 获取或设置奖励类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("award_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("award_type")]
                                public int AwardType { get; set; }

                                /// <summary>
                                /// 获取或设置奖励券的模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("award_coupon_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("award_coupon_id")]
                                public long? AwardCouponId { get; set; }

                                /// <summary>
                                /// 获取或设置奖励券的名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("award_coupon_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("award_coupon_name")]
                                public string? AwardCouponName { get; set; }

                                /// <summary>
                                /// 获取或设置奖励券的数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("award_coupon_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("award_coupon_num")]
                                public long? AwardCouponNumber { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置活动生效开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public long ValidBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置活动生效结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long ValidEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置用户领券玩法。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_task_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_task_type")]
                        public int CouponTaskType { get; set; }

                        /// <summary>
                        /// 获取或设置发放须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notice_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("notice_text")]
                        public string? NoticeText { get; set; }

                        /// <summary>
                        /// 获取或设置分享裂变配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_fission_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_fission_config")]
                        public Types.ShareFissionConfig? ShareFissionConfig { get; set; }
                    }

                    public class SidebarActivity
                    {
                        /// <summary>
                        /// 获取或设置活动生效开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public long ValidBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置活动生效结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long ValidEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置引流方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_trigger")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_trigger")]
                        public int? ActionTrigger { get; set; }

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

                        /// <summary>
                        /// 获取或设置完成次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("complete_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("complete_times")]
                        public int? CompleteTimes { get; set; }

                        /// <summary>
                        /// 获取或设置是否绑定用户。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_bind")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_bind")]
                        public bool? RequireBind { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string ActivityId { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                public string ActivityName { get; set; } = default!;

                /// <summary>
                /// 获取或设置券模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                public string CouponMetaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置用户领取次数限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_limit")]
                public int ReceiveLimit { get; set; }

                /// <summary>
                /// 获取或设置发放场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("send_scene")]
                public int SendScene { get; set; }

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
        public Types.Activity Activity { get; set; } = default!;
    }
}
