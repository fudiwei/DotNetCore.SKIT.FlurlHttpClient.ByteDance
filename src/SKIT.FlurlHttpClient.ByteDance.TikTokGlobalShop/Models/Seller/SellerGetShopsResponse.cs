namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /seller/{version}/shops 接口的响应。</para>
    /// </summary>
    public class SellerGetShopsResponse : TikTokShopResponse<SellerGetShopsResponse.Types.Data>
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
                        /// 获取或设置所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;
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
