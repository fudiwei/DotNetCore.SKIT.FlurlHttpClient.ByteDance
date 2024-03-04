namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/global_products/attributes 接口的响应。</para>
    /// </summary>
    public class GlobalProductGetAttributeListResponse : TikTokShopResponse<GlobalProductGetAttributeListResponse.Types.Data>
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
                            public class IntputSettings : ProductGetAttributeListResponse.Types.Data.Types.Attribute.Types.IntputSettings
                            {
                                /// <summary>
                                /// 获取或设置必填地区列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mandatory_regions")]
                                [System.Text.Json.Serialization.JsonPropertyName("mandatory_regions")]
                                public string[]? MandatoryRegionList { get; set; }
                            }

                            public class AttributeValue : ProductGetAttributeListResponse.Types.Data.Types.Attribute.Types.AttributeValue
                            {
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
