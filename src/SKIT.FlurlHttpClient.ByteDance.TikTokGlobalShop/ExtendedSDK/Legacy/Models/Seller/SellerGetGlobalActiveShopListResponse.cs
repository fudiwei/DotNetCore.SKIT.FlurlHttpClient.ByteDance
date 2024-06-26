namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /seller/global/active_shops 接口的响应。</para>
    /// </summary>
    public class SellerGetGlobalActiveShopListResponse : TikTokShopLegacyResponse<SellerGetGlobalActiveShopListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Shop
                    {
                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ShopId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_region")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_region")]
                        public string Region { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置活跃店铺列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_shops")]
                [System.Text.Json.Serialization.JsonPropertyName("active_shops")]
                public Types.Shop[] ActiveShopList { get; set; } = default!;
            }
        }
    }
}
