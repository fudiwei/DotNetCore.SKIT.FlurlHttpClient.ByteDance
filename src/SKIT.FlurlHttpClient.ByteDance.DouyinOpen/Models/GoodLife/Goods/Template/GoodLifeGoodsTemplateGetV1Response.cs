namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/template/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsTemplateGetV1Response : DouyinOpenResponse<GoodLifeGoodsTemplateGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_multi")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_multi")]
                        public bool IsMultiple { get; set; }

                        /// <summary>
                        /// 获取或设置是否必填。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }

                        /// <summary>
                        /// 获取或设置值类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_type")]
                        public string ValueType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置值样例。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_demo")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_demo")]
                        public string? ValueDemo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("product_attrs")]
                public Types.Attribute[]? ProductAttributeList { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_attrs")]
                public Types.Attribute[]? SPUAttributeList { get; set; }

                /// <summary>
                /// 获取或设置 SKU 属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                public Types.Attribute[]? SKUAttributeList { get; set; }

                /// <summary>
                /// 获取或设置日历属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("calendar_attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("calendar_attrs")]
                public Types.Attribute[]? CalenderAttributeList { get; set; }
            }
        }
    }
}
