using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/apply_scope_quota 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-01 下线。")]
    public class AppsCapacityApplyScopeQuotaV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置权限 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permission_key")]
        [System.Text.Json.Serialization.JsonPropertyName("permission_key")]
        public string PermissionKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置作用域 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string ScopeKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置额度生效开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置额度生效结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请的额度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_quota")]
        public int ApplyQuota { get; set; }

        /// <summary>
        /// 获取或设置申请原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_reason_type")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_reason_type")]
        public int ApplyReasonType { get; set; }

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 获取或设置联系方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public string? Contact { get; set; }
    }
}
