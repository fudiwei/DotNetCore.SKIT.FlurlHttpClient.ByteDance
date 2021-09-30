namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/trackNoRouteDetail 接口的响应。</para>
    /// </summary>
    public class LogisticsTrackNoRouteDetailResponse : TikTokShopResponse<LogisticsTrackNoRouteDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class RouteNode
                    {
                        /// <summary>
                        /// 获取或设置轨迹内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state")]
                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int StateCode { get; set; }

                        /// <summary>
                        /// 获取或设置状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("state_description")]
                        public string StateDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置站点名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_name")]
                        public string SiteName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long Timestamp { get; set; }
                    }

                    public class Tracking
                    {
                        /// <summary>
                        /// 获取或设置快递公司编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("express")]
                        [System.Text.Json.Serialization.JsonPropertyName("express")]
                        public string LogisticsCompanyCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置超区原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("track_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("track_no")]
                        public string LogisticsNumber { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置轨迹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("route_node_list")]
                [System.Text.Json.Serialization.JsonPropertyName("route_node_list")]
                public Types.RouteNode[] RouteNodeList { get; set; } = default!;

                /// <summary>
                /// 获取或设置运单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("track_info")]
                [System.Text.Json.Serialization.JsonPropertyName("track_info")]
                public Types.Tracking Tracking { get; set; } = default!;
            }
        }
    }
}
