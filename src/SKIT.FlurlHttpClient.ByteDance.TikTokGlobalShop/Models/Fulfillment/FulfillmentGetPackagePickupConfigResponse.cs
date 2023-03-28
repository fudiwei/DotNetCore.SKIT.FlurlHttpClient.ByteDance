namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/package_pickup_config/list 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetPackagePickupConfigResponse : TikTokShopResponse<FulfillmentGetPackagePickupConfigResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PickupTime
                    {
                        /// <summary>
                        /// 获取或设置开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否可预约。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avaliable")]
                        [System.Text.Json.Serialization.JsonPropertyName("avaliable")]
                        public bool IsAvaliable { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置是否支持上门提货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_pick_up")]
                [System.Text.Json.Serialization.JsonPropertyName("is_pick_up")]
                public bool IsPickUp { get; set; }

                /// <summary>
                /// 获取或设置上门提货时间列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_up_time_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_up_time_list")]
                public Types.PickupTime[]? PickupTimeList { get; set; }

                /// <summary>
                /// 获取或设置是否支持网点交货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_drop_off")]
                [System.Text.Json.Serialization.JsonPropertyName("is_drop_off")]
                public bool IsDropOff { get; set; }

                /// <summary>
                /// 获取或设置网点交货 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("drop_off_point_url")]
                [System.Text.Json.Serialization.JsonPropertyName("drop_off_point_url")]
                public string? DropOffPointUrl { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_van_collection")]
                [System.Text.Json.Serialization.JsonPropertyName("is_van_collection")]
                public bool? IsVanCollection { get; set; }
            }
        }
    }
}
