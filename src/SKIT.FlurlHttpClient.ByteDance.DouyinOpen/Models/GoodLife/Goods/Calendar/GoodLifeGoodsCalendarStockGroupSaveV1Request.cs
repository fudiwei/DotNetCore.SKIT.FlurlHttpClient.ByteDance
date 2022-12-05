using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/calendar_stock_group/save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsCalendarStockGroupSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class CalendarStockGroup
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
                /// 获取或设置日历库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("calendar_stocks")]
                [System.Text.Json.Serialization.JsonPropertyName("calendar_stocks")]
                public IList<Types.CalendarStock> StockList { get; set; } = new List<Types.CalendarStock>();
            }

            public class CalendarStock
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
                /// 获取或设置库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_qty")]
                public int StockQuantity { get; set; }

                /// <summary>
                /// 获取或设置库存上限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_qty_limit_type")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_qty_limit_type")]
                public int StockLimitType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日历库存信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar_stock_group")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar_stock_group")]
        public Types.CalendarStockGroup CalendarStockGroup { get; set; } = new Types.CalendarStockGroup();
    }
}
