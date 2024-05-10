namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /authorization/{version}/shops 接口的响应。</para>
    /// </summary>
    public class AuthorizationGetShopsResponse : TikTokShopResponse<AuthorizationGetShopsResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ShopId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_type")]
                        public string SellerType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺密码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cipher")]
                        [System.Text.Json.Serialization.JsonPropertyName("cipher")]
                        public string Cipher { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string Code { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置店铺列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shops")]
                [System.Text.Json.Serialization.JsonPropertyName("shops")]
                public Types.Shop[] ShopList { get; set; } = default!;
            }
        }
    }
}
