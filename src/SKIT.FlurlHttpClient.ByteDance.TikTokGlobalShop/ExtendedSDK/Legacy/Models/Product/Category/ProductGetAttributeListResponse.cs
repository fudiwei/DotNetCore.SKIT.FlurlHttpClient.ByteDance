namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/attributes 接口的响应。</para>
    /// </summary>
    public class ProductGetAttributeListResponse : TikTokShopLegacyResponse<ProductGetAttributeListResponse.Types.Data>
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
                            public class IntputSettings
                            {
                                /// <summary>
                                /// 获取或设置是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_mandatory")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_mandatory")]
                                public bool IsMandatory { get; set; }

                                /// <summary>
                                /// 获取或设置是否允许多选。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_multiple_selected")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_multiple_selected")]
                                public bool IsMultipleSelected { get; set; }

                                /// <summary>
                                /// 获取或设置是否允许自定义。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_customized")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_customized")]
                                public bool IsCustomized { get; set; }
                            }

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
                                public string ValueName { get; set; } = default!;
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
                        public string AttributeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_type")]
                        public int AttributeType { get; set; }

                        /// <summary>
                        /// 获取或设置输入配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("input_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("input_type")]
                        public Types.IntputSettings IntputSettings { get; set; } = default!;

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
