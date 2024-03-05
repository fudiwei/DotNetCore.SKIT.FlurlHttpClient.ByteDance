namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.AWEME_PERMISSION_AUDIT_RESULT 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/all/douyin ]]>
    /// </para>
    /// </summary>
    public class AwemePermissionAuditResultEvent : DouyinMicroAppOpenApiEvent
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置权限 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("permission_key")]
                [System.Text.Json.Serialization.JsonPropertyName("permission_key")]
                [System.Xml.Serialization.XmlElement("permission_key")]
                public string PermissionKey { get; set; } = default!;

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
