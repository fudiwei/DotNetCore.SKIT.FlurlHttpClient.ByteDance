using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify_qualification 接口的请求。</para>
    /// </summary>
    public class ProductApiModifyQualificationRequest : ByteDanceMicroAppProductApiRequest
    {
        public static class Types
        {
            public class Qualification
            {
                public static class Types
                {
                    public class TeacherQualification : ProductApiAddQualificationRequest.Types.Qualification.Types.TeacherQualification
                    {
                        public static new class Types
                        {
                            public class DouyinAuthInfo : ProductApiAddQualificationRequest.Types.Qualification.Types.TeacherQualification.Types.DouyinAuthInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_info_lst")]
                        public new IList<Material> MaterialList { get; set; } = new List<Material>();

                        /// <summary>
                        /// 获取或设置抖音授权信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("douyin_auth_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("douyin_auth_info")]
                        public new IList<Types.DouyinAuthInfo>? DouyinAuthInfoList { get; set; }
                    }

                    public class InstitutionQualification : ProductApiAddQualificationRequest.Types.Qualification.Types.InstitutionQualification
                    {
                        /// <summary>
                        /// 获取或设置材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_info_lst")]
                        public new IList<Material> MaterialList { get; set; } = new List<Material>();
                    }

                    public class Material : ProductApiAddQualificationRequest.Types.Qualification.Types.Material
                    {
                    }
                }

                /// <summary>
                /// 获取或设置审核主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object_type")]
                [System.Text.Json.Serialization.JsonPropertyName("object_type")]
                public int ObjectType { get; set; }

                /// <summary>
                /// 获取或设置审核主体 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object_id")]
                [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                public string ObejctId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置教师资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("teacher_qualification_info")]
                [System.Text.Json.Serialization.JsonPropertyName("teacher_qualification_info")]
                public Types.TeacherQualification? TeacherQualification { get; set; }

                /// <summary>
                /// 获取或设置机构资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("institution_qualification_info")]
                [System.Text.Json.Serialization.JsonPropertyName("institution_qualification_info")]
                public Types.InstitutionQualification? InstitutionQualification { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification")]
        public Types.Qualification Qualification { get; set; } = new Types.Qualification();
    }
}
