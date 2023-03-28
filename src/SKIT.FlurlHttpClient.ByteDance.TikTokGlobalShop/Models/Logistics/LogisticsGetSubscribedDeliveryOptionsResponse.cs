namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/get_subscribed_deliveryoptions 接口的响应。</para>
    /// </summary>
    public class LogisticsGetSubscribedDeliveryOptionsResponse : TikTokShopResponse<LogisticsGetSubscribedDeliveryOptionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Warehouse
                    {
                        public static class Types
                        {
                            public class WarehouseDeliveryOption
                            {
                                /// <summary>
                                /// 获取或设置配送方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_option")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_option")]
                                public int DeliveryOption { get; set; }

                                /// <summary>
                                /// 获取或设置服务 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_id")]
                                public string? ServiceId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置服务名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                                public string? ServiceName { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string WarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_delivery")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_delivery")]
                        public Types.WarehouseDeliveryOption[] DeliveryOptionList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置仓库列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_list")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_list")]
                public Types.Warehouse[] WarehouseList { get; set; } = default!;
            }
        }
    }
}
