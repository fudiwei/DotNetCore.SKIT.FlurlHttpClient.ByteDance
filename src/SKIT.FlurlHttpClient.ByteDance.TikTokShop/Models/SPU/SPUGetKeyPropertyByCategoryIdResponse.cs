namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/getKeyPropertyByCid 接口的响应。</para>
    /// </summary>
    public class SPUGetKeyPropertyByCategoryIdResponse : TikTokShopResponse<SPUGetKeyPropertyByCategoryIdResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Property
                    {
                        /// <summary>
                        /// 获取或设置关联属性值 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rel_value_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("rel_value_id")]
                        public int RelatedValueId { get; set; }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("property_id")]
                        public int PropertyId { get; set; }

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("property_name")]
                        public string PropertyName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                        public int ValueId { get; set; }

                        /// <summary>
                        /// 获取或设置属性值名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                        public string ValueName { get; set; } = default!;
                    }

                    public class Brand : Property
                    {
                    }
                }

                /// <summary>
                /// 获取或设置属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_info")]
                [System.Text.Json.Serialization.JsonPropertyName("property_info")]
                public Types.Property[] PropertyList { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_info")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_info")]
                public Types.Brand[] BrandList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
