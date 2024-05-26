namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_doudian_shop_info 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryDoudianShopInfoV1Response : DouyinMicroAppResponse
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
                        /// 获取或设置抖音小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MaAppId")]
                        [System.Text.Json.Serialization.JsonPropertyName("MaAppId")]
                        public string MicroAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置抖店应用 AppID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("DoudianAppId")]
                        [System.Text.Json.Serialization.JsonPropertyName("DoudianAppId")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string DoudianAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置抖店店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ShopId")]
                        [System.Text.Json.Serialization.JsonPropertyName("ShopId")]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置抖店店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ShopName")]
                        [System.Text.Json.Serialization.JsonPropertyName("ShopName")]
                        public string ShopName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置抖店用户 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ToutiaoId")]
                        [System.Text.Json.Serialization.JsonPropertyName("ToutiaoId")]
                        public long DouyinId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置店铺列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ShopIdList")]
                [System.Text.Json.Serialization.JsonPropertyName("ShopIdList")]
                public Types.Shop[] ShopList { get; set; } = default!;
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
