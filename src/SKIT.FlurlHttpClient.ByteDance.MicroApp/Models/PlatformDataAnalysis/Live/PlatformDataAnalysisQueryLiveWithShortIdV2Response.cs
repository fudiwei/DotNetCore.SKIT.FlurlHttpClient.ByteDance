namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_live_with_short_id/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryLiveWithShortIdV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AnchorData
                    {
                        public static class Types
                        {
                            public class AnchorInfo
                            {
                                /// <summary>
                                /// 获取或设置抖音号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("AwemeShortID")]
                                [System.Text.Json.Serialization.JsonPropertyName("AwemeShortID")]
                                public string AwemeShortId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置账号类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("AccountType")]
                                [System.Text.Json.Serialization.JsonPropertyName("AccountType")]
                                public int AccountType { get; set; }

                                /// <summary>
                                /// 获取或设置昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("Nickname")]
                                public string Nickname { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Avat")]
                                [System.Text.Json.Serialization.JsonPropertyName("Avat")]
                                public string AvatarUrl { get; set; } = default!;
                            }

                            public class Statistics
                            {
                                /// <summary>
                                /// 获取或设置直播总时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomDuration")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomDuration")]
                                public int RoomDuration { get; set; }

                                /// <summary>
                                /// 获取或设置直播最高在线人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomHighestOnlineCount")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomHighestOnlineCount")]
                                public int RoomHighestOnlineCount { get; set; }

                                /// <summary>
                                /// 获取或设置直播新增粉丝数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomNewFans")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomNewFans")]
                                public int RoomNewFansCount { get; set; }

                                /// <summary>
                                /// 获取或设置直播场次。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomSessionCnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomSessionCnt")]
                                public int RoomSessionCount { get; set; }

                                /// <summary>
                                /// 获取或设置支付人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("PayCustomerCnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("PayCustomerCnt")]
                                public int PayUserCount { get; set; }

                                /// <summary>
                                /// 获取或设置支付订单金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("PayOrderAmount")]
                                [System.Text.Json.Serialization.JsonPropertyName("PayOrderAmount")]
                                public long PayOrderAmount { get; set; }

                                /// <summary>
                                /// 获取或设置客单价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("CustomerOncePrice")]
                                [System.Text.Json.Serialization.JsonPropertyName("CustomerOncePrice")]
                                public long CustomerOncePrice { get; set; }

                                /// <summary>
                                /// 获取或设置单均价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_once_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_once_price")]
                                public long OrderOncePrice { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置主播信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ShortInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("ShortInfo")]
                        public Types.AnchorInfo AnchorInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置统计数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Data")]
                        [System.Text.Json.Serialization.JsonPropertyName("Data")]
                        public Types.Statistics Statistics { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置主播数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ShortDataList")]
                [System.Text.Json.Serialization.JsonPropertyName("ShortDataList")]
                public Types.AnchorData[] AnchorDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Total")]
                [System.Text.Json.Serialization.JsonPropertyName("Total")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
