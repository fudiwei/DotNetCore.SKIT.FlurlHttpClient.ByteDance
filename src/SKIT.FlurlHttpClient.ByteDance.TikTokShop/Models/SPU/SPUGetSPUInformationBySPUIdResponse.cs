using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/getSpuInfoBySpuId 接口的响应。</para>
    /// </summary>
    public class SPUGetSPUInformationBySPUIdResponse : TikTokShopResponse<SPUGetSPUInformationBySPUIdResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SPU
                    {
                        /// <summary>
                        /// 获取或设置 SPU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_id")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public long SPUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SPU 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_name")]
                        public string SPUName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置产品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upc_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("upc_code")]
                        public string UPC { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        public int BrandId { get; set; }

                        /// <summary>
                        /// 获取或设置在线状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("op_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("op_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? AuditTime { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset UpdateTime { get; set; }
                    }

                    public class SPUProperty
                    {
                        public static class Types
                        {
                            public class SPUPropertyValue
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
                                [Newtonsoft.Json.JsonProperty("value_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                                public string ValueName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值别名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_alias")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_alias")]
                                public string ValueAlias { get; set; } = default!;
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
                        public int PropertyType { get; set; }

                        /// <summary>
                        /// 获取或设置属性别名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property_alias")]
                        [System.Text.Json.Serialization.JsonPropertyName("property_alias")]
                        public string PropertyAlias { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_property_value_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_property_value_info")]
                        public Types.SPUPropertyValue[] PropertyValueList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置 SPU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_info")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_info")]
                public Types.SPU SPU { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SPU 属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_property_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_property_infos")]
                public Types.SPUProperty[] SPUPropertyList { get; set; } = default!;
            }
        }
    }
}
