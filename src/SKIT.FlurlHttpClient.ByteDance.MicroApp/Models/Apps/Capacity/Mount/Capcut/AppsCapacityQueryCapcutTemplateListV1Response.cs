namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_capcut_template_list 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryCapcutTemplateListV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CapcutTemplate
                    {
                        public static class Types
                        {
                            public class AuditReason
                            {
                                /// <summary>
                                /// 获取或设置审核拒绝原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                                public string RejectReason { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核建议。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_advice")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_advice")]
                                public string Advice { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置模版 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                        public long TemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置模板标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模板描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_video_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_video_url")]
                        public string VideoUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开关状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_status")]
                        public int TemplateStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_audit_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_audit_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_audit_reason")]
                        public Types.AuditReason[]? AuditReasonList { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_ctime")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_ctime")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置剪映视频模版列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("capcut_template_list")]
                [System.Text.Json.Serialization.JsonPropertyName("capcut_template_list")]
                public Types.CapcutTemplate[] CapcutTemplateList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_count")]
                [System.Text.Json.Serialization.JsonPropertyName("page_count")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
