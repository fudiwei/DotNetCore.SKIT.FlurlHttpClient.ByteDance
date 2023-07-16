namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_class_info 接口的响应。</para>
    /// </summary>
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
                                /// 获取或设置二级类目 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_class_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_class_id")]
                                public int SecondClassId { get; set; }

                                /// <summary>
                                /// 获取或设置二级类目名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_class_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_class_name")]
                                public string SecondClassName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分类定义。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("class_definition")]
                                [System.Text.Json.Serialization.JsonPropertyName("class_definition")]
                                public string? ClassDefinition { get; set; }

                                /// <summary>
                                /// 获取或设置教师资格证要求。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("teacher_qualification_certificate")]
                                [System.Text.Json.Serialization.JsonPropertyName("teacher_qualification_certificate")]
                                public string? TeacherQualificationCertificate { get; set; }

                                /// <summary>
                                /// 获取或设置获取或设置专业认证要求。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("professional_certification")]
                                [System.Text.Json.Serialization.JsonPropertyName("professional_certification")]
                                public string? ProfessionalCertification { get; set; }

                                /// <summary>
                                /// 获取或设置专业性学历要求。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("professional_education")]
                                [System.Text.Json.Serialization.JsonPropertyName("professional_education")]
                                public string? ProfessionalEducation { get; set; }

                                /// <summary>
                                /// 获取或设置行业资质提醒。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_tip")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_tip")]
                                public string? QualificationTips { get; set; }

                                /// <summary>
                                /// 获取或设置特殊提醒。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("special_tip")]
                                [System.Text.Json.Serialization.JsonPropertyName("special_tip")]
                                public string? SpecialTips { get; set; }

                                /// <summary>
                                /// 获取或设置文档链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("document_link")]
                                [System.Text.Json.Serialization.JsonPropertyName("document_link")]
                                public string? DocumentLink { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置已入库的课程信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("class_info_detail_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("class_info_detail_list")]
                        public Types.ClassInfoDetail[] ClassInfoDetailList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class_id")]
                        public int FirstClassId { get; set; }

                        /// <summary>
                        /// 获取或设置一级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class_name")]
                        public string FirstClassName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置课程类目信息列表。
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
