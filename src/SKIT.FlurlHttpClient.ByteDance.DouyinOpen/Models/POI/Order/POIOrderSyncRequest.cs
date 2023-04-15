namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/sync 接口的请求。</para>
    /// </summary>
    public class POIOrderSyncRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class ExternalShop
            {
                /// <summary>
                /// 获取或设置商户外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_shop_id")]
                public string? ExternalShopId { get; set; }

                /// <summary>
                /// 获取或设置商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public string? ShopId { get; set; }
            }

            public class MicroApp
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置用户的小程序 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_open_id")]
                public string? UserOpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发送请求时的毫秒级时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_time")]
        [System.Text.Json.Serialization.JsonPropertyName("date_time")]
        public long? DateTimeUnixMilliseconds { get; set; }

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置订单结构 JSON。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
        public string? OrderDetailJson { get; set; }

        /// <summary>
        /// 获取或设置商家外部信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_shop_info")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_shop_info")]
        public Types.ExternalShop? ExternalShop { get; set; }

        /// <summary>
        /// 获取或设置小程序对接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_app")]
        [System.Text.Json.Serialization.JsonPropertyName("mini_app")]
        public Types.MicroApp? MicroApp { get; set; }
    }
}
