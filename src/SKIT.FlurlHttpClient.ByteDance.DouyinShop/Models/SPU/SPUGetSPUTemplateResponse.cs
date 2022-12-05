namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/getSpuTpl 接口的响应。</para>
    /// </summary>
    public class SPUGetSPUTemplateResponse : DouyinShopResponse<SPUGetSPUTemplateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PropertyFormat
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                public int ValueId { get; set; }

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值顺序。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sequence")]
                                [System.Text.Json.Serialization.JsonPropertyName("sequence")]
                                public int Sequence { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置属性名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("options")]
                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                        public Types.Option[]? OptionList { get; set; }

                        /// <summary>
                        /// 获取或设置是否必填。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("require")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("require")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsRequired { get; set; }

                        /// <summary>
                        /// 获取或设置类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置多选最大选项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("multi_select_max")]
                        [System.Text.Json.Serialization.JsonPropertyName("multi_select_max")]
                        public int? MultiSelectMaximum { get; set; }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("property_id")]
                        public int PropertyId { get; set; }

                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("property_type")]
                        public int PropertyType { get; set; }

                        /// <summary>
                        /// 获取或设置属性顺序。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sequence")]
                        [System.Text.Json.Serialization.JsonPropertyName("sequence")]
                        public int Sequence { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_format")]
                [System.Text.Json.Serialization.JsonPropertyName("product_format")]
                public Types.PropertyFormat[] PropertyFormatList { get; set; } = default!;
            }
        }
    }
}
