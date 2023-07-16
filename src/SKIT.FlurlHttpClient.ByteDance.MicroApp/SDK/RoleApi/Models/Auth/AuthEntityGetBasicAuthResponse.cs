namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_basic_auth 接口的响应。</para>
    /// </summary>
    public class AuthEntityGetBasicAuthResponse: ByteDanceMicroAppRoleApiResponse
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置资质材料类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_type")]
                [System.Text.Json.Serialization.JsonPropertyName("material_type")]
                public int MaterialType { get; set; }

                /// <summary>
                /// 获取或设置资料过期时间字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_expiretime")]
                [System.Text.Json.Serialization.JsonPropertyName("material_expiretime")]
                public string MaterialExpireTime { get; set; } = default!;

                /// <summary>
                /// 获取或设置资质材料资源路径列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_paths")]
                [System.Text.Json.Serialization.JsonPropertyName("material_paths")]
                public string[]? MaterialPaths { get; set; }
            }

            public class Person
            {
                /// <summary>
                /// 获取或设置个人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置身份证号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_number")]
                public string IdNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置身份证有效期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTimeString { get; set; } = default!;

                /// <summary>
                /// 获取或设置身份证正面资源文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_path")]
                [System.Text.Json.Serialization.JsonPropertyName("front_path")]
                public string FrontMaterialPath { get; set; } = default!;

                /// <summary>
                /// 获取或设置身份证背面资源文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_path")]
                [System.Text.Json.Serialization.JsonPropertyName("back_path")]
                public string BackMaterialPath { get; set; } = default!;
            }

            public class BasicAuth
            {
                public static class Types
                {
                    public class Enterprise
                    {
                        /// <summary>
                        /// 获取或设置营业执照编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资质材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_materials")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_materials")]
                        public Material[]? CertificateMaterialList { get; set; }

                        /// <summary>
                        /// 获取或设置法人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                        public Person? LegalPerson { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置实体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_type")]
                public int EntityType { get; set; }

                /// <summary>
                /// 获取或设置实体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_name")]
                public string EntityName { get; set; } = default!;

                /// <summary>
                /// 获取或设置证件照类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_type")]
                public int CertificateType { get; set; }

                /// <summary>
                /// 获取或设置个人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("individual")]
                [System.Text.Json.Serialization.JsonPropertyName("individual")]
                public Person? Individual { get; set; }

                /// <summary>
                /// 获取或设置企业信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enterprise")]
                [System.Text.Json.Serialization.JsonPropertyName("enterprise")]
                public Types.Enterprise? Enterprise { get; set; }
            }

            public class Qualification
            {
                /// <summary>
                /// 获取或设置资质审核任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_taskid")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
                public string AuditTaskId { get; set; } = default!;

                /// <summary>
                /// 获取或设置资质审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int AuditStatus { get; set; }

                /// <summary>
                /// 获取或设置审核失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string AuditFailReason { get; set; } = default!;

                /// <summary>
                ///  获取或设置资质材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public Material[] QualificationMaterialList { get; set; } = default!;

                /// <summary>
                /// 获取或设置资质材料中最大的过期时间字符串（格式：yyyy-MM-dd）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTimeString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 实体基础认证信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth")]
        public Types.BasicAuth BasicAuth { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_status")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
        public int AuthStatus { get; set; }

        /// <summary>
        /// 获取或设置认证失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_reason")]
        public string? AuthFailReason { get; set; }

        /// <summary>
        /// 获取或设置线上生效的资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("online_qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("online_qualification")]
        public Types.Qualification? OnlineQualification { get; set; }

        /// <summary>
        /// 获取或设置最近审核中的资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_qualification")]
        public Types.Qualification? AuditQualification { get; set; }
    }
}
