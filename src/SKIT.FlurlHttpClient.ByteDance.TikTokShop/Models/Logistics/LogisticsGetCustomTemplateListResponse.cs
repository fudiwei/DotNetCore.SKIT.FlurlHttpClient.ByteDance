namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/getCustomTemplateList 接口的响应。</para>
    /// </summary>
    public class LogisticsGetCustomTemplateListResponse : TikTokShopResponse<LogisticsGetCustomTemplateListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CustomTemplate
                    {
                        public static class Types
                        {
                            public class Template
                            {
                                /// <summary>
                                /// 获取或设置自定义模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_template_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_template_id")]
                                public int CustomTemplateId { get; set; }

                                /// <summary>
                                /// 获取或设置自定义模板编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_template_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_template_code")]
                                public string CustomTemplateCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置自定义模板名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_template_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_template_name")]
                                public string CustomTemplateName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置上级模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("parent_template_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("parent_template_id")]
                                public int? ParentTemplateId { get; set; }

                                /// <summary>
                                /// 获取或设置上级模板编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("parent_template_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("parent_template_code")]
                                public string? ParentTemplateCode { get; set; }

                                /// <summary>
                                /// 获取或设置自定义模板 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_template_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_template_url")]
                                public string CustomTemplateUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置自定义模板打印项字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_template_key_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_template_key_list")]
                                public string[]? CustomTemplateKeyList { get; set; }
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
                        [Newtonsoft.Json.JsonProperty("custom_template_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_template_infos")]
                        public Types.Template[] TemplateList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置自定义模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_template_data")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_template_data")]
                public Types.CustomTemplate[] CustomTemplateList { get; set; } = default!;
            }
        }
    }
}
