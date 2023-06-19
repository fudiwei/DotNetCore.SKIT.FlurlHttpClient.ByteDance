namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.PACKAGE_AUDIT 事件的数据。</para>
    /// <para>REF: https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/audit-code </para>
    /// </summary>
    public class PackageAuditEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class AuditResult
            {
                public static class Types
                {
                    public class AuditDetail
                    {
                        public static class Types
                        {
                            public class ModifyGuide
                            {
                                /// <summary>
                                /// 获取或设置修改指引名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                [System.Xml.Serialization.XmlElement("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置修改指引链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("link")]
                                [System.Text.Json.Serialization.JsonPropertyName("link")]
                                [System.Xml.Serialization.XmlElement("link")]
                                public string LinkUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        [System.Xml.Serialization.XmlElement("reason")]
                        public string RejectReason { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置附件 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detailFile")]
                        [System.Text.Json.Serialization.JsonPropertyName("detailFile")]
                        [System.Xml.Serialization.XmlElement("detailFile", IsNullable = true)]
                        public string? FileUrl { get; set; }

                        /// <summary>
                        /// 获取或设置修改建议信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("modifyGuide")]
                        [System.Text.Json.Serialization.JsonPropertyName("modifyGuide")]
                        [System.Xml.Serialization.XmlElement("modifyGuide", IsNullable = true)]
                        public Types.ModifyGuide? ModifyGuide { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置宿主端英文简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hostName")]
                [System.Text.Json.Serialization.JsonPropertyName("hostName")]
                [System.Xml.Serialization.XmlElement("hostName")]
                public string HostName { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置拒绝原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", Type = typeof(string), IsNullable = true)]
                public string[]? RejectReasonList { get; set; }

                /// <summary>
                /// 获取或设置审核详细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auditDetail")]
                [System.Text.Json.Serialization.JsonPropertyName("auditDetail")]
                [System.Xml.Serialization.XmlElement("auditDetail", Type = typeof(Types.AuditDetail), IsNullable = true)]
                public Types.AuditDetail[]? AuditDetailList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置审核结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuditResults")]
        [System.Text.Json.Serialization.JsonPropertyName("AuditResults")]
        [System.Xml.Serialization.XmlElement("AuditResults", Type = typeof(Types.AuditResult))]
        public Types.AuditResult[] AuditResultList { get; set; } = default!;
    }
}
