namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/order/v2/push 接口的请求。</para>
    /// </summary>
    public class AppsOrderPushV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class KeyValue
            {
                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置第三方在开放平台申请的 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置 POI 外部商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_shop_id")]
        public string ExternalShopId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string AppName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 JSON 格式的订单详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
        public string? OrderDetailJson { get; set; }

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置订单变更时间毫秒级时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public long UpdateTimeMilliseconds { get; set; }

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra")]
        [System.Text.Json.Serialization.JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string? Scene { get; set; }

        /// <summary>
        /// 获取或设置位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 获取或设置下单来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("launch_from")]
        [System.Text.Json.Serialization.JsonPropertyName("launch_from")]
        public string? LaunchFrom { get; set; }

        /// <summary>
        /// 获取或设置担保支付平台订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_order_no")]
        public string? PaymentOrderNumber { get; set; }
    }
}
