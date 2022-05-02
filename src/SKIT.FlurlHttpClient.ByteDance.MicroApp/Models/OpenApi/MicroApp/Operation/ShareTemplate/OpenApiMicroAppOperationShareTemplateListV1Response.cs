namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /openapi/v1/microapp/operation/share_tpl_list 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppOperationShareTemplateListV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ShareTemplate
                    {
                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("templateId")]
                        [System.Text.Json.Serialization.JsonPropertyName("templateId")]
                        public string TemplateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分享标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分享文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分享图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("imageUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
                        public string ImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是默认模板。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("isDefault")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("isDefault")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsDefault { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ctime")]
                        [System.Text.Json.Serialization.JsonPropertyName("ctime")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最近修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mtime")]
                        [System.Text.Json.Serialization.JsonPropertyName("mtime")]
                        public long ModifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置分享信息审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auditStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("auditStatus")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auditTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("auditTime")]
                        public long? AuditTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分享模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shareTplList")]
                [System.Text.Json.Serialization.JsonPropertyName("shareTplList")]
                public Types.ShareTemplate[] ShareTemplateList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享模板总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
