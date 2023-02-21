namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.MODIFY_APP_NAME 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-name </para>
    /// </summary>
    public class ModifyAppNameEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class ModifyResult
            {
                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? RejectReason { get; set; }

                /// <summary>
                /// 获取或设置审核建议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advice")]
                [System.Text.Json.Serialization.JsonPropertyName("advice")]
                [System.Xml.Serialization.XmlElement("advice", IsNullable = true)]
                public string? AuditAdvice { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置修改结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ModifyAppNameResults")]
        [System.Text.Json.Serialization.JsonPropertyName("ModifyAppNameResults")]
        [System.Xml.Serialization.XmlElement("ModifyAppNameResults")]
        public Types.ModifyResult ModifyResult { get; set; } = default!;
    }
}
