namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/getCateProperty 接口的响应。</para>
    /// </summary>
    public class ProductGetCategoryPropertyResponse : TikTokShopResponse<ProductGetCategoryPropertyResponse.Types.Data[]>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Option
                    {
                        /// <summary>
                        /// 获取或设置选项名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置选项值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
                    }
                }

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
                /// 获取或设置属性类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否必填。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("required")]
                [System.Text.Json.Serialization.JsonPropertyName("required")]
                public bool IsRequired { get; set; }

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public Types.Option[]? OptionList { get; set; }
            }
        }
    }
}
