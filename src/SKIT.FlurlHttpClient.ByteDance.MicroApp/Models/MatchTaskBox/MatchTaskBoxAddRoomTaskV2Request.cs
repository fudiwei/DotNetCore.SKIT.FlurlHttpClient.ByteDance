using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/add_room_task/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxAddRoomTaskV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置任务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_name")]
        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string TaskName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结算方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_settle_type")]
        [System.Text.Json.Serialization.JsonPropertyName("task_settle_type")]
        public int TaskSettleType { get; set; }

        /// <summary>
        /// 获取或设置小程序页面地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_page")]
        [System.Text.Json.Serialization.JsonPropertyName("start_page")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置直播间页面标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_title")]
        [System.Text.Json.Serialization.JsonPropertyName("room_title")]
        public string? RoomTitle { get; set; }

        /// <summary>
        /// 获取或设置内容标签。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("content_tag")]
        public string? ContentTag { get; set; }

        /// <summary>
        /// 获取或设置形态标签。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("form_tag")]
        public string? FormTag { get; set; }

        /// <summary>
        /// 获取或设置任务图标 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_icon")]
        [System.Text.Json.Serialization.JsonPropertyName("task_icon")]
        public string TaskIconUrl { get; set; } = string.Empty;

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
        public string TaskDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置示例视频 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refer_videos")]
        [System.Text.Json.Serialization.JsonPropertyName("refer_videos")]
        public IList<string>? ReferVideoUrlList { get; set; }

        /// <summary>
        /// 获取或设置小程序截图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refer_ma_captures")]
        [System.Text.Json.Serialization.JsonPropertyName("refer_ma_captures")]
        public IList<string>? ReferMicroAppCaptureUrlList { get; set; }
    }
}
