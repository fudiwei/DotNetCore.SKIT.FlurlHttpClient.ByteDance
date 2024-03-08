using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/query_task_info/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskBoxQueryTaskInfoV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Task
                    {
                        public static class Types
                        {
                            public class OrientedTalent
                            {
                                /// <summary>
                                /// 获取或设置达人抖音号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("douyin_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
                                public string DouyinId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置合作状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cooperation_state")]
                                [System.Text.Json.Serialization.JsonPropertyName("cooperation_state")]
                                public int CooperationState { get; set; }

                                /// <summary>
                                /// 获取或设置取消方类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cancel_operator")]
                                [System.Text.Json.Serialization.JsonPropertyName("cancel_operator")]
                                public int? CancelOperatorType { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置任务所属小程序。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
                        public string TaskName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_settle_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_settle_type")]
                        public int TaskSettleType { get; set; }

                        /// <summary>
                        /// 获取或设置页面类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_type")]
                        public int? PageType { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_page")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_page")]
                        public string? PagePath { get; set; }

                        /// <summary>
                        /// 获取或设置锚点标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("anchor_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("anchor_title")]
                        public string? AnchorTitle { get; set; }

                        /// <summary>
                        /// 获取或设置任务图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_icon")]
                        public string TaskIconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_start_time")]
                        public long TaskStartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置任务结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_end_time")]
                        public long TaskEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置任务简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_desc")]
                        public string TaskDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_type")]
                        public int TaskType { get; set; }

                        /// <summary>
                        /// 获取或设置任务状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int TaskStatus { get; set; }

                        /// <summary>
                        /// 获取或设置驳回原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置示例视频 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refer_videos")]
                        [System.Text.Json.Serialization.JsonPropertyName("refer_videos")]
                        public string[]? ReferVideoUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置任务标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_tags")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_tags")]
                        public string[] TaskTagList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序截图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refer_ma_captures")]
                        [System.Text.Json.Serialization.JsonPropertyName("refer_ma_captures")]
                        public string[]? ReferMicroAppCaptureUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置示例视频截图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refer_video_captures")]
                        [System.Text.Json.Serialization.JsonPropertyName("refer_video_captures")]
                        public string[]? ReferVideoCaptureUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置视频的 GID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refer_gids")]
                        [System.Text.Json.Serialization.JsonPropertyName("refer_gids")]
                        public long[]? ReferGIdList { get; set; }

                        /// <summary>
                        /// 获取或设置专属达人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("oriented_talent_rel_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("oriented_talent_rel_list")]
                        public Types.OrientedTalent[]? OrientedTalentList { get; set; }

                        /// <summary>
                        /// 获取或设置任务最大退款周期（单位：天）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_refund_period")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_refund_period")]
                        public int? TaskRefundPeriod { get; set; }

                        /// <summary>
                        /// 获取或设置混合分成比例字典（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mix_payment_allocate_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("mix_payment_allocate_ratio")]
                        public IDictionary<int, int>? MixPaymentAllocateRatioMap { get; set; }

                        /// <summary>
                        /// 获取或设置分成比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_allocate_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_allocate_ratio")]
                        public int? PaymentAllocateRatio { get; set; }

                        /// <summary>
                        /// 获取或设置达人混合分成比例字典（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_mix_payment_allocate_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_mix_payment_allocate_ratio")]
                        public IDictionary<int, int>? TalentMixPaymentAllocateRatioMap { get; set; }

                        /// <summary>
                        /// 获取或设置达人分成比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_payment_allocate_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_payment_allocate_ratio")]
                        public int? TalentPaymentAllocateRatio { get; set; }

                        /// <summary>
                        /// 获取或设置平台小程序版地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_address_app")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_address_app")]
                        public string? PlatformMicroAppPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置平台 Web 版地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_address_web")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_address_web")]
                        public string? PlatformWebUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tasks")]
                [System.Text.Json.Serialization.JsonPropertyName("tasks")]
                public Types.Task[] TaskList { get; set; } = default!;

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

                /// <summary>
                /// 获取或设置推广计划小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;
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
