namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/orders/{order_id}/tracking 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetOrderTrackingResponse : TikTokShopResponse<FulfillmentGetOrderTrackingResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Tracking
                    {
                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置更新时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time_millis")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time_millis")]
                        public long UpdateTimeMilliseconds { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置物流轨迹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking")]
                public Types.Tracking[] TrackingList { get; set; } = default!;
            }
        }
    }
}
