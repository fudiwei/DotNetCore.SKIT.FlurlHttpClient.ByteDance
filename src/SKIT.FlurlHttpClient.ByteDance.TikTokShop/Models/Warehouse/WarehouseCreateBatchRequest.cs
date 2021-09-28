using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/createBatch 接口的请求。</para>
    /// </summary>
    public class WarehouseCreateBatchRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class OutWarehouse
            {
                /// <summary>
                /// 获取或设置外部仓库 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                public string OutWarehouseId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置仓库名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置仓库介绍。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intro")]
                [System.Text.Json.Serialization.JsonPropertyName("intro")]
                public string Introduction { get; set; } = string.Empty;
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
