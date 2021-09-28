using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /dutyFree/orderConfirm 接口的请求。</para>
    /// </summary>
    public class DutyFreeOrderConfirmRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Error
            {
                /// <summary>
                /// 获取或设置失败编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("error_code")]
                [System.Text.Json.Serialization.JsonPropertyName("error_code")]
                public string ErrorCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("error_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
                public string ErrorMessage { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置接单时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occurrence_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("occurrence_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset OccurrenceTime { get; set; }

        /// <summary>
        /// 获取或设置接单失败信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_info")]
        [System.Text.Json.Serialization.JsonPropertyName("error_info")]
        public Types.Error? Error { get; set; }
    }
}
