namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/setAddr 接口的请求。</para>
    /// </summary>
    public class WarehouseSetAddressRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置一级地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addr_id1")]
                [System.Text.Json.Serialization.JsonPropertyName("addr_id1")]
                public int AddressId1 { get; set; }

                /// <summary>
                /// 获取或设置二级地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addr_id2")]
                [System.Text.Json.Serialization.JsonPropertyName("addr_id2")]
                public int? AddressId2 { get; set; }

                /// <summary>
                /// 获取或设置三级地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addr_id3")]
                [System.Text.Json.Serialization.JsonPropertyName("addr_id3")]
                public int? AddressId3 { get; set; }

                /// <summary>
                /// 获取或设置四级地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addr_id4")]
                [System.Text.Json.Serialization.JsonPropertyName("addr_id4")]
                public int? AddressId4 { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置外部仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string OutWarehouseId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        public Types.Address Address { get; set; } = new Types.Address();
    }
}
