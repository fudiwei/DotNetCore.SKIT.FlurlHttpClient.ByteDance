using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/create_book 接口的请求。</para>
    /// </summary>
    public class AppsTradeBookCreateBookV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class ItemBookInfo
            {
                public static class Types
                {
                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置身份证号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_no")]
                        public string? IdCardNumber { get; set; }
                    }

                    public class BookSKUInfo
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID 类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id_type")]
                        public int SKUIdType { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置加价金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置外部店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_shop_id")]
                public string ExternalPOIId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string POIId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                public string ShopName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_id")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                public string GoodsId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                public string? ItemOrderId { get; set; }

                /// <summary>
                /// 获取或设置预约开始时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("book_start_time")]
                public long BookStartTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置预约结束时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("book_end_time")]
                public long BookEndTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置用户信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("user_info_list")]
                public IList<Types.UserInfo>? UserInfoList { get; set; }

                /// <summary>
                /// 获取或设置预约的商品 SKU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_sku_info")]
                [System.Text.Json.Serialization.JsonPropertyName("book_sku_info")]
                public Types.BookSKUInfo? BookSKUInfo { get; set; }
            }

            public class MarkupInfo
            {
                public static class Types
                {
                    public class MicroAppSchema : AppsTradeRefundCreateRefundV2Request.Types.MicroAppSchema
                    {
                    }
                }

                /// <summary>
                /// 获取或设置开发者加价单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_markup_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_markup_no")]
                public string OutMarkupNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置回调通知地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_notify_url")]
                public string? NotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置订单详情页的 Schema。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_entry_schema")]
                [System.Text.Json.Serialization.JsonPropertyName("order_entry_schema")]
                public Types.MicroAppSchema? OrderEntrySchema { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_book_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_book_no")]
        public string OutBookNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预约信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_book_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_book_info_list")]
        public IList<Types.ItemBookInfo> ItemBookInfoList { get; set; } = new List<Types.ItemBookInfo>();

        /// <summary>
        /// 获取或设置加价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("markup_info")]
        [System.Text.Json.Serialization.JsonPropertyName("markup_info")]
        public Types.MarkupInfo? MarkupInfo { get; set; } 
    }
}
