namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/{version}/global_warehouses 接口的响应。</para>
    /// </summary>
    public class LogisticsGetGlobalWarehousesResponse : TikTokShopResponse<LogisticsGetGlobalWarehousesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Warehouse
                    {
                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string WarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置所有权类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ownership")]
                        [System.Text.Json.Serialization.JsonPropertyName("ownership")]
                        public string Ownership { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置仓库列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("global_warehouses")]
                [System.Text.Json.Serialization.JsonPropertyName("global_warehouses")]
                public Types.Warehouse[] WarehouseList { get; set; } = default!;
            }
        }
    }
}
