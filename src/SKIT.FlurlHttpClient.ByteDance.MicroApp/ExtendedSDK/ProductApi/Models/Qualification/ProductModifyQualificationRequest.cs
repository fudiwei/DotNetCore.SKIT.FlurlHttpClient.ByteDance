using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify_qualification 接口的请求。</para>
    /// </summary>
    public class ProductModifyQualificationRequest : DouyinMicroAppProductApiRequest
    {
        public static class Types
        {
            public class Qualification
            {
                public static class Types
                {
                    public class TeacherQualification
                    {
                        public static class Types
                        {
                            public class DouyinAuthInfo : ProductAddQualificationRequest.Types.Qualification.Types.TeacherQualification.Types.DouyinAuthInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                        public int? FirstClassId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                        public int? SecondClassId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                        public int? ThirdClassId { get; set; }

                        /// <summary>
                        /// 获取或设置身份证号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ID_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("ID_number")]
                        public string IdCardNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置身份证照片资源路径列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ID_img_uris")]
                        [System.Text.Json.Serialization.JsonPropertyName("ID_img_uris")]
                        public IList<string> IdCardImagePathList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置照片资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_uri")]
                        public string? ImagePath { get; set; }

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("introduction")]
                        public string Introduction { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_info_lst")]
                        public IList<Material> MaterialList { get; set; } = new List<Material>();

                        /// <summary>
                        /// 获取或设置抖音授权信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("douyin_auth_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("douyin_auth_info")]
                        public IList<Types.DouyinAuthInfo>? DouyinAuthInfoList { get; set; }
                    }

                    public class InstitutionQualification : ProductAddQualificationRequest.Types.Qualification.Types.InstitutionQualification
                    {
                        /// <summary>
                        /// 获取或设置材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_info_lst")]
                        public new IList<Material> MaterialList { get; set; } = new List<Material>();
                    }

                    public class Material : ProductAddQualificationRequest.Types.Qualification.Types.Material
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
