using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/add_task/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxAddTaskV2Request : DouyinMicroAppRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

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
        /// 获取或设置任务标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_tags")]
        [System.Text.Json.Serialization.JsonPropertyName("task_tags")]
        public IList<string> TaskTagList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置小程序截图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refer_ma_captures")]
        [System.Text.Json.Serialization.JsonPropertyName("refer_ma_captures")]
        public IList<string>? ReferMicroAppCaptureUrlList { get; set; }

        /// <summary>
        /// 获取或设置视频的 GID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refer_gids")]
        [System.Text.Json.Serialization.JsonPropertyName("refer_gids")]
        public IList<long>? ReferGIdList { get; set; }

        /// <summary>
        /// 获取或设置任务最大退款周期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_refund_period")]
        [System.Text.Json.Serialization.JsonPropertyName("task_refund_period")]
        public int? TaskRefundPeriod { get; set; }

        /// <summary>
        /// 获取或设置指定推广达人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_ids")]
        public IList<string>? DouyinIdList { get; set; }

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
    }
}
