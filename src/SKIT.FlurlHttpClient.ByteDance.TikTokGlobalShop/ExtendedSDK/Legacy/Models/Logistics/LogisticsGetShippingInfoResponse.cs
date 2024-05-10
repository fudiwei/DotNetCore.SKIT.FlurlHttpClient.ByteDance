namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/ship/get 接口的响应。</para>
    /// </summary>
    public class LogisticsGetShippingInfoResponse : TikTokShopLegacyResponse<LogisticsGetShippingInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TrackingInfo
                    {
                        public static class Types
                        {
                            public class TrackingInfo
                            {
                                /// <summary>
                                /// 获取或设置描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("description")]
                                [System.Text.Json.Serialization.JsonPropertyName("description")]
                                public string Description { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置轨迹列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tracking_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("tracking_info")]
                        public Types.TrackingInfo[] TrackingInfoList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置轨迹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_info_list")]
                public Types.TrackingInfo[] TrackingInfoList { get; set; } = default!;
            }
        }
    }
}
