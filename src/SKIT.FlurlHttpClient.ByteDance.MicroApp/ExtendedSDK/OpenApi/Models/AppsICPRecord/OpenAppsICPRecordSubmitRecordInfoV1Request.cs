using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/icp_record/submit_record_info/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsICPRecordSubmitRecordInfoV1Request : DouyinMicroAppOpenApiRequest
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置资源路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string FilePath { get; set; } = string.Empty;
            }

            public class CorpInfo
            {
                /// <summary>
                /// 获取或设置主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_type")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_type")]
                public int CorpType { get; set; }

                /// <summary>
                /// 获取或设置省份编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_code")]
                [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                public string ProvinceCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string ProvinceName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_code")]
                [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                public string CityCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_name")]
                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                public string CityName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("region_code")]
                [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                public string DistrictCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("region_name")]
                [System.Text.Json.Serialization.JsonPropertyName("region_name")]
                public string DistrictName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置通信地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("communication_address")]
                [System.Text.Json.Serialization.JsonPropertyName("communication_address")]
                public string CommunicationAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credentials_type")]
                [System.Text.Json.Serialization.JsonPropertyName("credentials_type")]
                public int CredentialsType { get; set; }

                /// <summary>
                /// 获取或设置证件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credentials_address")]
                [System.Text.Json.Serialization.JsonPropertyName("credentials_address")]
                public string CredentialsAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credentials_name")]
                [System.Text.Json.Serialization.JsonPropertyName("credentials_name")]
                public string CredentialsName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credentials_number")]
                [System.Text.Json.Serialization.JsonPropertyName("credentials_number")]
                public string CredentialsNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件材料。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credentials_pic")]
                [System.Text.Json.Serialization.JsonPropertyName("credentials_pic")]
                public Material CredentialsMaterial { get; set; } = new Material();

                /// <summary>
                /// 获取或设置负责人证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_type")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_type")]
                public int InchargePeopleCredentialsType { get; set; }

                /// <summary>
                /// 获取或设置负责人证件编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_number")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_number")]
                public string InchargePeopleCredentialsNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人证件正面材料。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_front")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_front")]
                public Material InchargePeopleCredentialsFrontMaterial { get; set; } = new Material();

                /// <summary>
                /// 获取或设置负责人证件背面材料。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_back")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_back")]
                public Material InchargePeopleCredentialsBackMaterial { get; set; } = new Material();

                /// <summary>
                /// 获取或设置负责人证件是否有有效期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_has_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_has_end_time")]
                public bool? InchargePeopleCredentialsHasEndTime { get; set; }

                /// <summary>
                /// 获取或设置负责人证件有效开始日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_valid_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_valid_start_time")]
                public long? InchargePeopleCredentialsValidStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置负责人证件有效结束日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_credentials_valid_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_credentials_valid_end_time")]
                public long? InchargePeopleCredentialsValidEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置负责人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_name")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_name")]
                public string InchargePeopleName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_email")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_email")]
                public string InchargePeopleEmail { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_phone")]
                public string InchargePeoplePhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人应急手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_emergency_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_emergency_phone")]
                public string InchargePeopleEmergencyPhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人授权书材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_authority_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_authority_letter")]
                public IList<Material>? CorpAuthorityLetterMaterialList { get; set; }

                /// <summary>
                /// 获取或设置主办单位备案承诺书材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_commitment")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_commitment")]
                public IList<Material>? CorpCommitmentMaterialList { get; set; }

                /// <summary>
                /// 获取或设置主办单位其他材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_other_materials")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_other_materials")]
                public IList<Material>? CorpOtherMaterialList { get; set; }

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }

            public class AppInfo
            {
                public static class Types
                {
                    public class PreApproval
                    {
                        /// <summary>
                        /// 获取或设置前置审核项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_approval_item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_approval_item_id")]
                        public int PreApprovalTypeId { get; set; }

                        /// <summary>
                        /// 获取或设置前置审批编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_approval_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_approval_number")]
                        public string? PreApprovalNumber { get; set; }

                        /// <summary>
                        /// 获取或设置前置审批文件材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_approval_files")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_approval_files")]
                        public IList<Material>? PreApprovalMaterialList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置语种列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_language")]
                [System.Text.Json.Serialization.JsonPropertyName("app_language")]
                public IList<int> LanguageTypeList { get; set; } = new List<int>();

                /// <summary>
                /// 获取或设置人证核验 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("facial_recognition_token")]
                [System.Text.Json.Serialization.JsonPropertyName("facial_recognition_token")]
                public string FacialRecognitionToken { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_email")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_email")]
                public string InchargePeopleEmail { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_phone")]
                public string InchargePeoplePhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人应急手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incharge_people_emergency_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("incharge_people_emergency_phone")]
                public string InchargePeopleEmergencyPhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否涉及前置审批。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("involve_pre_approval")]
                [System.Text.Json.Serialization.JsonPropertyName("involve_pre_approval")]
                public bool IsPreApprovalInvolved { get; set; }

                /// <summary>
                /// 获取或设置前置审批列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_approval_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_approval_list")]
                public IList<Types.PreApproval>? PreApprovalList { get; set; }

                /// <summary>
                /// 获取或设置服务内容 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_content_type_list")]
                [System.Text.Json.Serialization.JsonPropertyName("service_content_type_list")]
                public IList<int> ServiceContentTypeList { get; set; } = new List<int>();

                /// <summary>
                /// 获取或设置负责人授权书材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_authority_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("app_authority_letter")]
                public IList<Material>? AppAuthorityLetterMaterialList { get; set; }

                /// <summary>
                /// 获取或设置其他材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_other_materials")]
                [System.Text.Json.Serialization.JsonPropertyName("app_other_materials")]
                public IList<Material>? AppOtherMaterialList { get; set; }

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置备案主体信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_info")]
        public Types.CorpInfo CorpInfo { get; set; } = new Types.CorpInfo();

        /// <summary>
        /// 获取或设置备案应用信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_info")]
        [System.Text.Json.Serialization.JsonPropertyName("app_info")]
        public Types.AppInfo AppInfo { get; set; } = new Types.AppInfo();
    }
}
