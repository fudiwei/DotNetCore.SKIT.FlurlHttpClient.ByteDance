namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /business/diamond/query 接口的响应。</para>
    /// </summary>
    public class WebcastBusinessDiamondQueryResponse : DouyinMicroAppWebcastResponse
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置付费点。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_tag")]
        public string PayTag { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diamonds")]
        [System.Text.Json.Serialization.JsonPropertyName("diamonds")]
        public int Diamonds { get; set; }
    }
}
