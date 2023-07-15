using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    public class ProductApiQueryClassInfoResponse : ByteDanceMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductClassInfo
                    {
                        public static class Types
                        {
                            public class ClassInfoDetail
                            {
                                /// <summary>
                                /// 二级类目id
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_class_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_class_id")]
                                public int SecondClassId { get; set; }

                                /// <summary>
                                /// 二级类目名称
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_class_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_class_name")]
                                public string SecondClassName { get; set; }

                                /// <summary>
                                /// 特殊提醒
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("special_tip")]
                                [System.Text.Json.Serialization.JsonPropertyName("special_tip")]
                                public string SpecialTip { get; set; }

                                /// <summary>
                                /// 教师资格证
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("teacher_qualification_certificate")]
                                [System.Text.Json.Serialization.JsonPropertyName("teacher_qualification_certificate")]
                                public string TeacherQualificationCertificate { get; set; }

                                /// <summary>
                                /// 分类定义
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("class_definition")]
                                [System.Text.Json.Serialization.JsonPropertyName("class_definition")]
                                public string ClassDefinition { get; set; }

                                /// <summary>
                                /// 专业认证
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("professional_certification")]
                                [System.Text.Json.Serialization.JsonPropertyName("professional_certification")]
                                public string ProfessionalCertification { get; set; }

                                /// <summary>
                                /// 专业性学历
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("professional_education")]
                                [System.Text.Json.Serialization.JsonPropertyName("professional_education")]
                                public string ProfessionalEducation { get; set; }

                                /// <summary>
                                /// 行业资质提醒
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_tip")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_tip")]
                                public string QualificationTip { get; set; }

                                /// <summary>
                                /// 具体文档链接
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("document_link")]
                                [System.Text.Json.Serialization.JsonPropertyName("document_link")]
                                public string DocumentLink { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置已上架的商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("class_info_detail_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("class_info_detail_list")]
                        public Types.ClassInfoDetail[] ClassInfoDetailList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核中的商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class_id")]
                        public int FirstClassId { get; set; }

                        /// <summary>
                        /// 获取或设置审核中的商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class_name")]
                        public string FirstClassName { get; set; }
                        
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_class_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_class_info_list")]
                public Types.ProductClassInfo[] ProductClassInfoList { get; set; } = default!;
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
