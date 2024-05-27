using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/batch_consume_coupon 接口的请求。</para>
    /// </summary>
    public class PromotionCouponBatchConsumeCouponV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者核销单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_out_no")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_out_no")]
        public string OutConsumeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id_list")]
        public IList<string> CouponIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置核销时间戳。如果不指定将使用当前时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_time")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_time")]
        public long? ConsumeTimestamp { get; set; }
    }
}
