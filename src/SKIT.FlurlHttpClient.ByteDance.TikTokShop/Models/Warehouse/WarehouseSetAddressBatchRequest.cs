using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/setAddrBatch 接口的请求。</para>
    /// </summary>
    public class WarehouseSetAddressBatchRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class OutWarehouse
            {
                public static class Types
                {
                    public class Address : WarehouseSetAddressRequest.Types.Address
                    {
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

        /// <summary>
        /// 获取或设置外部仓库列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_list")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_list")]
        public IList<Types.OutWarehouse> OutWarehouseList { get; set; } = new List<Types.OutWarehouse>();
    }
}
