namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/packages/{package_id}/handover_time_slots 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetPackageHandoverTimeSlotsResponse : TikTokShopResponse<FulfillmentGetPackageHandoverTimeSlotsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TimeSlot
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
                        /// 获取或设置是否可用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avaliable")]
                        [System.Text.Json.Serialization.JsonPropertyName("avaliable")]
                        public bool IsAvaliable { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置是否可上门取件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_pickup")]
                [System.Text.Json.Serialization.JsonPropertyName("can_pickup")]
                public bool CanPickup { get; set; }

                /// <summary>
                /// 获取或设置是否可门店寄送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_drop_off")]
                [System.Text.Json.Serialization.JsonPropertyName("can_drop_off")]
                public bool CanDropOff { get; set; }

                /// <summary>
                /// 获取或设置是否可货车取件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_van_collection")]
                [System.Text.Json.Serialization.JsonPropertyName("can_van_collection")]
                public bool CanVanCollection { get; set; }

                /// <summary>
                /// 获取或设置寄送门店定位 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("drop_off_point_url")]
                [System.Text.Json.Serialization.JsonPropertyName("drop_off_point_url")]
                public string? DropOffPointUrl { get; set; }

                /// <summary>
                /// 获取或设置时间段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pickup_slots")]
                [System.Text.Json.Serialization.JsonPropertyName("pickup_slots")]
                public Types.TimeSlot[] TimeSlotList { get; set; } = default!;
            }
        }
    }
}
