namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories/{category_id}/attributes 接口的响应。</para>
    /// </summary>
    public class ProductGetCategoryAttributesResponse : TikTokShopResponse<ProductGetCategoryAttributesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Attribute
                    {
                        public static class Types
                        {
                            public class AttributeValue
                            {
                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AttributeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许多选。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_multiple_selection")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_multiple_selection")]
                        public bool IsMultipleSelection { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许自定义。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_customizable")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_customizable")]
                        public bool IsCustomizable { get; set; }

                        /// <summary>
                        /// 获取或设置属性值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public Types.AttributeValue[] ValueList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("attributes")]
                public Types.Attribute[] AttributeList { get; set; } = default!;
            }
        }
    }
}
