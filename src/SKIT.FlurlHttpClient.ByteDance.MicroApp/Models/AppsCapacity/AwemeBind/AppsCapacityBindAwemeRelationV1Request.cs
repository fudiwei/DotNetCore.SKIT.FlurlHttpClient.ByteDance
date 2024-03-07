using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/bind_aweme_relation/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityBindAwemeRelationV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class TemplateInfo
            {
                public static class Types
                {
                    public class TemplateContent
                    {
                        /// <summary>
                        /// 获取或设置资质名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置上传材料 MaterielId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("materiel_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("materiel_id")]
                        public string? MaterielId { get; set; }

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("val_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("val_type")]
                        public int? ValueType { get; set; }

                        /// <summary>
                        /// 获取或设置内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("val_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("val_list")]
                        public IList<string>? ValueList { get; set; }

                        /// <summary>
                        /// 获取或设置拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模版 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long TemplateId { get; set; }

                /// <summary>
                /// 获取或设置模版标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置内容列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_content")]
                [System.Text.Json.Serialization.JsonPropertyName("template_content")]
                public IList<Types.TemplateContent> TemplateContentList { get; set; } = new List<Types.TemplateContent>();
            }

            public class CooperationInfo
            {
                /// <summary>
                /// 获取或设置合作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_type")]
                public string CooperationType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置关系过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relation_expire_date")]
                [System.Text.Json.Serialization.JsonPropertyName("relation_expire_date")]
                public long RelationExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string? CompanyName { get; set; }

                /// <summary>
                /// 获取或设置营业执照编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_code")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_code")]
                public string? BusinessLicenseNumber { get; set; }

                /// <summary>
                /// 获取或设置真实姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("real_name")]
                [System.Text.Json.Serialization.JsonPropertyName("real_name")]
                public string? RealName { get; set; }

                /// <summary>
                /// 获取或设置身份证号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity_number")]
                [System.Text.Json.Serialization.JsonPropertyName("identity_number")]
                public string? IdCardNumber { get; set; }

                /// <summary>
                /// 获取或设置合作合同照片 MaterielId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_image")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_image")]
                public string? ContractImageMaterielId { get; set; }

                /// <summary>
                /// 获取或设置合作合同照片 MaterielId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_image_list")]
                public IList<string>? ContractImageMaterielIdList { get; set; }
            }

            public class EmployeeInfo
            {
                /// <summary>
                /// 获取或设置关系过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relation_expire_date")]
                [System.Text.Json.Serialization.JsonPropertyName("relation_expire_date")]
                public long RelationExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置真实姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("real_name")]
                [System.Text.Json.Serialization.JsonPropertyName("real_name")]
                public string RealName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity_number")]
                [System.Text.Json.Serialization.JsonPropertyName("identity_number")]
                public string IdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置劳动合同照片 MaterielId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_image")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_image")]
                public string? ContractImageMaterielId { get; set; }

                /// <summary>
                /// 获取或设置劳动合同照片 MaterielId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_image_list")]
                public IList<string>? ContractImageMaterielIdList { get; set; }

                /// <summary>
                /// 获取或设置资质类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                public string? QualificationType { get; set; }

                /// <summary>
                /// 获取或设置资质材料 MaterielId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_image_list")]
                public IList<string>? QualificationImageMaterielIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string AwemeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置绑定类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置绑定能力标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity_list")]
        [System.Text.Json.Serialization.JsonPropertyName("capacity_list")]
        public IList<string> CapacityKeyList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置是否相同主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("co_subject")]
        [System.Text.Json.Serialization.JsonPropertyName("co_subject")]
        public bool? IsCoSubject { get; set; }

        /// <summary>
        /// 获取或设置是否相同主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_template_info")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_template_info")]
        public IDictionary<string, Types.TemplateInfo> AuditTemplateInfoMap { get; set; } = new Dictionary<string, Types.TemplateInfo>();

        /// <summary>
        /// 获取或设置合作号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperation_info")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperation_info")]
        public Types.CooperationInfo? CooperationInfo { get; set; }

        /// <summary>
        /// 获取或设置员工号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employee_info")]
        [System.Text.Json.Serialization.JsonPropertyName("employee_info")]
        public Types.EmployeeInfo? EmployeeInfo { get; set; }
    }
}
