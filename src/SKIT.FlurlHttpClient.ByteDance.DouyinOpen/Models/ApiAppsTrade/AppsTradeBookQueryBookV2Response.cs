namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/query_book 接口的响应。</para>
    /// </summary>
    public class AppsTradeBookQueryBookV2Response : DouyinOpenResponse<AppsTradeBookQueryBookV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Book
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
                                        public string SKUId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置加价金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                                        public int Price { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置门店 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_id")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string POIId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                                public string GoodsId { get; set; } = default!;

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
                                public Types.UserInfo[]? UserInfoList { get; set; }

                                /// <summary>
                                /// 获取或设置预约的商品 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string? SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置加价单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("markup_item_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("markup_item_order_id")]
                                public string? MarkupItemOrderId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家预约单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_book_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_book_no")]
                        public string OutBookNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置预约单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("book_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                        public string BookId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置预约状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置预约信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("book_child_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("book_child_info_list")]
                        public Types.ItemBookInfo[] ItemBookInfoList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置加价单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("markup_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("markup_order_id")]
                        public string? MarkupOrderId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置预约单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("book_info_list")]
                public Types.Book[] BookList { get; set; } = default!;
            }
        }
    }
}
