using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/calendar_static_attr_group/save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class CalendarStaticAttributeGroup
            {
                /// <summary>
                /// 获取或设置商品 ID。与字段 <see cref="OutProductId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品外部 ID。与字段 <see cref="ProductId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_out_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_out_id")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置日历属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("calendar_static_attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("calendar_static_attrs")]
                public IList<Types.CalendarStaticAttribute> StaticAttributeList { get; set; } = new List<Types.CalendarStaticAttribute>();
            }

            public class CalendarStaticAttribute
            {
                public static class Types
                {
                    public class Value
                    {
                        /// <summary>
                        /// 获取或设置日期字符串列表（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public IList<string>? DateStringList { get; set; }

                        /// <summary>
                        /// 获取或设置要排除的日期字符串列表（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exclude_dates")]
                        [System.Text.Json.Serialization.JsonPropertyName("exclude_dates")]
                        public IList<string>? ExcludedDateStringList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置日历类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置日历值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public Types.Value Value { get; set; } = new Types.Value();

                /// <summary>
                /// 获取或设置属性字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_key_value_map")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_key_value_map")]
                public IDictionary<string, string>? KeyValueMap { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日历属性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar_static_attr_group")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar_static_attr_group")]
        public Types.CalendarStaticAttributeGroup CalendarStaticAttributeGroup { get; set; } = new Types.CalendarStaticAttributeGroup();
    }
}
