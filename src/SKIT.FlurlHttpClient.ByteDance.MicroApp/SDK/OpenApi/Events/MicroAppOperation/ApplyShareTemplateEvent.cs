namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.APPLY_SHARE_TEMPLATE 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/addShareTpl </para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/modifyShareTpl </para>
    /// </summary>
    public class ApplyShareTemplateEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class ApplyResult
            {
                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("templateId")]
                [System.Text.Json.Serialization.JsonPropertyName("templateId")]
                [System.Xml.Serialization.XmlElement("templateId")]
                public string TemplateId { get; set; } = default!;

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
            }
        }

        /// <summary>
        /// 获取或设置申请结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyShareTemplateResults")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyShareTemplateResults")]
        [System.Xml.Serialization.XmlElement("ApplyShareTemplateResults")]
        public Types.ApplyResult ApplyResult { get; set; } = default!;
    }
}
