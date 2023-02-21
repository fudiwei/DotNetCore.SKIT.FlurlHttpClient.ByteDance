namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/app/info 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppAppInfoV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class NewNameAuditInfo
                    {
                        /// <summary>
                        /// 获取或设置新名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_name")]
                        public string NewName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_name_audit_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_name_audit_state")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置剩余更改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remaining_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("remaining_times")]
                        public int RemainingTimes { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置修改建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advice")]
                        [System.Text.Json.Serialization.JsonPropertyName("advice")]
                        public string? Advice { get; set; }
                    }

                    public class NewIntroductionAuditInfo
                    {
                        /// <summary>
                        /// 获取或设置新简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_intro")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_intro")]
                        public string NewIntroduction { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_intro_audit_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_intro_audit_state")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置剩余更改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remaining_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("remaining_times")]
                        public int RemainingTimes { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置修改建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advice")]
                        [System.Text.Json.Serialization.JsonPropertyName("advice")]
                        public string? Advice { get; set; }
                    }

                    public class NewIconAuditInfo
                    {
                        /// <summary>
                        /// 获取或设置新图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_icon")]
                        public string NewIconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_icon_audit_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_icon_audit_state")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置剩余更改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remaining_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("remaining_times")]
                        public int RemainingTimes { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置修改建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advice")]
                        [System.Text.Json.Serialization.JsonPropertyName("advice")]
                        public string? Advice { get; set; }
                    }

                    public class CategoryAuditInfo
                    {
                        /// <summary>
                        /// 获取或设置服务类目 ID 字符串（以逗号分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_category")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_category")]
                        public string CategoryIdString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目名称（以短横线分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_category_name")]
                        public string CategoryNameString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_category_audit_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_category_audit_state")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }
                    }

                    public class SubjectAuditInfo
                    {
                        /// <summary>
                        /// 获取或设置主体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subject_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                        public int SubjectType { get; set; }

                        /// <summary>
                        /// 获取或设置主体名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subject_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("subject_name")]
                        public string SubjectName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subject_audit_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("subject_audit_state")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                public string AppName { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_type")]
                [System.Text.Json.Serialization.JsonPropertyName("app_type")]
                public int AppType { get; set; }

                /// <summary>
                /// 获取或设置小程序状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_state")]
                [System.Text.Json.Serialization.JsonPropertyName("app_state")]
                public int AppState { get; set; }

                /// <summary>
                /// 获取或设置小程序简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_intro")]
                [System.Text.Json.Serialization.JsonPropertyName("app_intro")]
                public string AppIntroduction { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序图标 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_icon")]
                [System.Text.Json.Serialization.JsonPropertyName("app_icon")]
                public string AppIconUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置新名称审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_name_audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("new_name_audit_info")]
                public Types.NewNameAuditInfo? NewNameAuditInfo { get; set; }

                /// <summary>
                /// 获取或设置新简介审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_intro_audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("new_intro_audit_info")]
                public Types.NewIntroductionAuditInfo? NewIntroductionAuditInfo { get; set; }

                /// <summary>
                /// 获取或设置新图标审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_icon_audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("new_icon_audit_info")]
                public Types.NewIconAuditInfo? NewIconAuditInfo { get; set; }

                /// <summary>
                /// 获取或设置服务类目审核信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_categories_audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("app_categories_audit_info")]
                public Types.CategoryAuditInfo[]? CategoryAuditInfoList { get; set; }

                /// <summary>
                /// 获取或设置主体审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_audit_info")]
                public Types.SubjectAuditInfo? SubjectAuditInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
