using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/hotel/order/commit 接口的请求。</para>
    /// </summary>
    public class POIExternalHotelOrderCommitRequest : TikTokRequest
    {
        public static class Types
        {
            public class Customer
            {
                /// <summary>
                /// 获取或设置英文姓。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("surname")]
                [System.Text.Json.Serialization.JsonPropertyName("surname")]
                public string? FamilyName { get; set; }

                /// <summary>
                /// 获取或设置英文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("given_name")]
                [System.Text.Json.Serialization.JsonPropertyName("given_name")]
                public string? GivenName { get; set; }

                /// <summary>
                /// 获取或设置中文全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cn_name")]
                [System.Text.Json.Serialization.JsonPropertyName("cn_name")]
                public string? ChineseName { get; set; }
            }

            public class DatePrice
            {
                /// <summary>
                /// 获取或设置当日日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string? DateString { get; set; }

                /// <summary>
                /// 获取或设置当日价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date_price")]
                [System.Text.Json.Serialization.JsonPropertyName("date_price")]
                public int Price { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置入住日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_in")]
        [System.Text.Json.Serialization.JsonPropertyName("check_in")]
        public string? CheckinDateString { get; set; }

        /// <summary>
        /// 获取或设置离店日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_out")]
        [System.Text.Json.Serialization.JsonPropertyName("check_out")]
        public string? CheckoutDateString { get; set; }

        /// <summary>
        /// 获取或设置入住人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_list")]
        public IList<Types.Customer>? CustomerList { get; set; }

        /// <summary>
        /// 获取或设置预订人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_name")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_name")]
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预订人电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_phone")]
        public string CustomerPhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置房间外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单支付状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置每日价格列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_price")]
        [System.Text.Json.Serialization.JsonPropertyName("date_price")]
        public IList<Types.DatePrice>? DatePriceList { get; set; }

        /// <summary>
        /// 获取或设置总价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_price")]
        [System.Text.Json.Serialization.JsonPropertyName("total_price")]
        public int TotalPrice { get; set; }

        /// <summary>
        /// 获取或设置预定数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("reserve_amount")]
        public int? ReserveCount { get; set; }
    }
}
