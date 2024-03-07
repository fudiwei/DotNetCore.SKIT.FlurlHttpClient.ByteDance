using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/get_aweme_bind_template_info/ 接口的响应。</para>
    /// </summary>
    public class AppsCapacityGetAwemeBindTemplateInfoV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
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
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string Description { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置加粗标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mainTitle")]
                                [System.Text.Json.Serialization.JsonPropertyName("mainTitle")]
                                public string? MainTitle { get; set; }

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
                                public string[]? ValueList { get; set; }

                                /// <summary>
                                /// 获取或设置选择项列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("val_example")]
                                [System.Text.Json.Serialization.JsonPropertyName("val_example")]
                                public string[]? ValueExampleList { get; set; }

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
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模版描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_content")]
                        public Types.TemplateContent[] TemplateContentList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置资质模版字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_info")]
                [System.Text.Json.Serialization.JsonPropertyName("template_info")]
                public IDictionary<long, Types.TemplateInfo> TemplateInfoMap { get; set; } = default!;
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
