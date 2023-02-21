namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.SCOPE_QUOTA_AUDIT_RESULT 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/all/scope-quota </para>
    /// </summary>
    public class ScopeQuotaAuditResultEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置作用域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                [System.Xml.Serialization.XmlElement("scope")]
                public string Scope { get; set; } = default!;

                /// <summary>
                /// 获取或设置额度生效开始日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                [System.Xml.Serialization.XmlElement("start_date")]
                public string StartDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置额度生效结束日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                [System.Xml.Serialization.XmlElement("end_date")]
                public string EndDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请的额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_quota")]
                [System.Xml.Serialization.XmlElement("apply_quota")]
                public int ApplyQuota { get; set; }

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason_list")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason_list")]
                [System.Xml.Serialization.XmlElement("reject_reason_list", Type = typeof(string), IsNullable = true)]
                public string[]? RejectReasonList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventContent")]
        [System.Text.Json.Serialization.JsonPropertyName("EventContent")]
        [System.Xml.Serialization.XmlElement("EventContent")]
        public Types.EventContent EventContent { get; set; } = default!;
    }
}
