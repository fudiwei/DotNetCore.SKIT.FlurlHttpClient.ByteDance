namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/distribution/order/sync_status 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentDistributionOrderSyncStatusV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置骑手电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rider_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("rider_phone")]
        public string RiderPhoneNumer { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置三方配送商标示。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("three_source")]
        [System.Text.Json.Serialization.JsonPropertyName("three_source")]
        public int RiderSource { get; set; }

        /// <summary>
        /// 获取或设置行为类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("behavior")]
        [System.Text.Json.Serialization.JsonPropertyName("behavior")]
        public int BehaviorType { get; set; }

        /// <summary>
        /// 获取或设置接单时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        public long AcceptTimestamp { get; set; }
    }
}
