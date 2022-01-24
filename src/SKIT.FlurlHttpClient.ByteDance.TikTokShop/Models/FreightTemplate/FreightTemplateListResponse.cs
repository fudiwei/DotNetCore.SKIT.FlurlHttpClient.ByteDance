namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /freightTemplate/list 接口的响应。</para>
    /// </summary>
    public class FreightTemplateListResponse : TikTokShopResponse<FreightTemplateListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FreightTemplate
                    {
                        public static class Types
                        {
                            public class Template
                            {
                                /// <summary>
                                /// 获取或设置运费模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置运费模板名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("template_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                                public string Name { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置运费模板信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template")]
                        [System.Text.Json.Serialization.JsonPropertyName("template")]
                        public Types.Template Template { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置运费模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("List")]
                [System.Text.Json.Serialization.JsonPropertyName("List")]
                public Types.FreightTemplate[] FreightTemplateList { get; set; } = default!;

                /// <summary>
                /// 获取或设置运费模板总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Count")]
                [System.Text.Json.Serialization.JsonPropertyName("Count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
