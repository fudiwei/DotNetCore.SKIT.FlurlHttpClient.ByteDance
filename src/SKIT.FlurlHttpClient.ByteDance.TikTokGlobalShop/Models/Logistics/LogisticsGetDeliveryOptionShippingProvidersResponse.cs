namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/{version}/delivery_options/{delivery_option_id}/shipping_providers 接口的响应。</para>
    /// </summary>
    public class LogisticsGetDeliveryOptionShippingProvidersResponse : TikTokShopResponse<LogisticsGetDeliveryOptionShippingProvidersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ShippingProvider
                    {
                        /// <summary>
                        /// 获取或设置运输服务商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ShippingProviderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置运输服务商名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置运输服务商列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_providers")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_providers")]
                public Types.ShippingProvider[] ShippingProviderList { get; set; } = default!;
            }
        }
    }
}
