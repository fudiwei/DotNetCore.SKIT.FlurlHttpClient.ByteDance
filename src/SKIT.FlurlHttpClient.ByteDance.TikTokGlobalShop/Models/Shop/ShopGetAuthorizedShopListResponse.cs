namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /shop/get_authorized_shop 接口的响应。</para>
    /// </summary>
    public class ShopGetAuthorizedShopListResponse : TikTokShopResponse<ShopGetAuthorizedShopListResponse.Types.Data>
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
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                        public string ShopName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置店铺列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_list")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_list")]
                public Types.Shop[] ShopList { get; set; } = default!;
            }
        }
    }
}
