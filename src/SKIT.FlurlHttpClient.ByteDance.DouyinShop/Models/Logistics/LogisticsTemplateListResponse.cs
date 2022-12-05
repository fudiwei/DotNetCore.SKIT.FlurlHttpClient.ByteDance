namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/templateList 接口的响应。</para>
    /// </summary>
    public class LogisticsTemplateListResponse : DouyinShopResponse<LogisticsTemplateListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Template
                    {
                        public static class Types
                        {
                            public class Template
                            {
                                /// <summary>
                                /// 获取或设置模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int TemplateId { get; set; }

                                /// <summary>
                                /// 获取或设置模板类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_type")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int TemplateType { get; set; }

                                /// <summary>
                                /// 获取或设置模板编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_code")]
                                public string TemplateCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置模板名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                                public string TemplateName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置模板 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_url")]
                                public string TemplateUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置预览 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("perview_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("perview_url")]
                                public string PreviewUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置版本。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("version")]
                                [System.Text.Json.Serialization.JsonPropertyName("version")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Version { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置快递公司编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                        public string LogisticsCompanyCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模板列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_infos")]
                        public Types.Template[] TemplateList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_data")]
                [System.Text.Json.Serialization.JsonPropertyName("template_data")]
                public Types.Template[] TemplateList { get; set; } = default!;
            }
        }
    }
}
