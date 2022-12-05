using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/calendar_amount_group/save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsCalendarAmountGroupSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class CalendarAmountGroup
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
                /// 获取或设置日历价格列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("calendar_amounts")]
                [System.Text.Json.Serialization.JsonPropertyName("calendar_amounts")]
                public IList<Types.CalendarAmount> AmountList { get; set; } = new List<Types.CalendarAmount>();
            }

            public class CalendarAmount
            {
                public static class Types
                {
                    public class Value : GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Request.Types.CalendarStaticAttribute.Types.Value
                    {
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
                /// 获取或设置原价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("origin_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("origin_amount")]
                public int OriginalAmount { get; set; }

                /// <summary>
                /// 获取或设置实际价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_amount")]
                public int ActualAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日历价格信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar_amount_group")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar_amount_group")]
        public Types.CalendarAmountGroup CalendarAmountGroup { get; set; } = new Types.CalendarAmountGroup();
    }
}
