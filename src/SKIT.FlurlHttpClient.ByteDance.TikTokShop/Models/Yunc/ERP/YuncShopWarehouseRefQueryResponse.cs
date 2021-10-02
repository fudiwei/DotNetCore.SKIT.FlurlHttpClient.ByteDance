namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/shopWarehouseRefQuery 接口的响应。</para>
    /// </summary>
    public class YuncShopWarehouseRefQueryResponse : TikTokShopResponse<YuncShopWarehouseRefQueryResponse.Types.Data>
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
                        /// 获取或设置仓库编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
                        public string WarehouseCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_name")]
                        public string WarehouseName { get; set; } = default!;
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
