using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/list 接口的请求。</para>
    /// </summary>
    public class WarehouseListRequest : DouyinShopRequest
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
        public string? OutWarehouseId { get; set; }

        /// <summary>
        /// 获取或设置外部仓库 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_ids")]
        public IList<string>? OutWarehouseIdList { get; set; }

        /// <summary>
        /// 获取或设置仓库名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_name")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_name")]
        public string? WarehouseName { get; set; }

        /// <summary>
        /// 获取或设置仓库地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        public Types.Address? Address { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置排序方式。
        /// <para>默认值：desc</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank")]
        [System.Text.Json.Serialization.JsonPropertyName("rank")]
        public string SortBy { get; set; } = "desc";

        /// <summary>
        /// 获取或设置排序字段。
        /// <para>默认值：create_time</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by")]
        [System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string SortField { get; set; } = "create_time";
    }
}
