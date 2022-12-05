namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/trade/book/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeTradeBookGetV1Response : DouyinOpenResponse<GoodLifeTradeBookGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class BaseResponse
            {
                /// <summary>
                /// 获取或设置业务状态码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_code")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_code")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int BusinessCode { get; set; }

                /// <summary>
                /// 获取或设置业务状态描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_msg")]
                public string? BusinessMessage { get; set; }
            }

            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Hotel
                    {
                        /// <summary>
                        /// 获取或设置房间数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("number_of_rooms")]
                        [System.Text.Json.Serialization.JsonPropertyName("number_of_rooms")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int RoomCount { get; set; }

                        /// <summary>
                        /// 获取或设置酒店代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hotel_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("hotel_code")]
                        public string? HotelCode { get; set; }

                        /// <summary>
                        /// 获取或设置连锁代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chain_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("chain_code")]
                        public string? ChainCode { get; set; }

                        /// <summary>
                        /// 获取或设置房型代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_type_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_type_code")]
                        public string? RoomTypeCode { get; set; }

                        /// <summary>
                        /// 获取或设置合约代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rate_plan_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("rate_plan_code")]
                        public string? RatePlanCode { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置预约单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置预约单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置预约开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_start_day")]
                [System.Text.Json.Serialization.JsonPropertyName("book_start_day")]
                public string BookStartDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置预约结束日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_end_day")]
                [System.Text.Json.Serialization.JsonPropertyName("book_end_day")]
                public string BookEndDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("book_apply_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置取消时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_cancel_time")]
                [System.Text.Json.Serialization.JsonPropertyName("book_cancel_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? CancelTimestamp { get; set; }

                /// <summary>
                /// 获取或设置酒店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hotel")]
                [System.Text.Json.Serialization.JsonPropertyName("hotel")]
                public Types.Hotel? Hotel { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置基础响应。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BaseResp")]
        [System.Text.Json.Serialization.JsonPropertyName("BaseResp")]
        public Types.BaseResponse BaseResponse { get; set; } = default!;

        /// <summary>
        /// 获取或设置三方预定 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_book_sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("third_book_sku_id")]
        public string? ThirdBookSKUId { get; set; }

        /// <summary>
        /// 获取或设置订单外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_order_id")]
        public string? OrderExternalId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && BaseResponse?.BusinessCode == 0;
        }
    }
}
