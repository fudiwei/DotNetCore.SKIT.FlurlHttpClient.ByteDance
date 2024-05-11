namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/listing_schemas 接口的响应。</para>
    /// </summary>
    public class ProductGetListingSchemasResponse : TikTokShopResponse<ProductGetListingSchemasResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ListingSchema
                    {
                        public static class Types
                        {
                            public class Field
                            {
                                public static class Types
                                {
                                    public class Rule
                                    {
                                        /// <summary>
                                        /// 获取或设置规则类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public string Type { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置规则值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public string Value { get; set; } = default!;
                                    }

                                    public class Option
                                    {
                                        /// <summary>
                                        /// 获取或设置选项 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public string OptionId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置选项名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置字段 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string FieldId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置字段名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置规则列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rules")]
                                [System.Text.Json.Serialization.JsonPropertyName("rules")]
                                public Types.Rule[]? RuleList { get; set; }

                                /// <summary>
                                /// 获取或设置选项列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("options")]
                                [System.Text.Json.Serialization.JsonPropertyName("options")]
                                public Types.Option[]? OptionList { get; set; }

                                /// <summary>
                                /// 获取或设置子字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("complex_values")]
                                [System.Text.Json.Serialization.JsonPropertyName("complex_values")]
                                public Field[]? SubFieldList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fileds")]
                        [System.Text.Json.Serialization.JsonPropertyName("fileds")]
                        public Types.Field[] FieldList { get; set; } = default!;
                    }

                    public class Error
                    {
                        public static class Types
                        {
                            public class Detail
                            {
                                /// <summary>
                                /// 获取或设置分类 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("category_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string CategoryId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public int Code { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string Message { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public Types.Detail Detail { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置上架模式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("listing_schemas")]
                [System.Text.Json.Serialization.JsonPropertyName("listing_schemas")]
                public Types.ListingSchema[] ListingSchemaList { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errors")]
                [System.Text.Json.Serialization.JsonPropertyName("errors")]
                public Types.Error[]? ErrorList { get; set; } = default!;
            }
        }
    }
}
