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
                    public class Attribute : ProductGetAttributeListResponse.Types.Data.Types.Attribute
                    {
                        public static new class Types
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
                        /// 获取或设置输入配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("input_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("input_type")]
                        public new Types.IntputSettings IntputSettings { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public new Types.AttributeValue[] ValueList { get; set; } = default!;
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
