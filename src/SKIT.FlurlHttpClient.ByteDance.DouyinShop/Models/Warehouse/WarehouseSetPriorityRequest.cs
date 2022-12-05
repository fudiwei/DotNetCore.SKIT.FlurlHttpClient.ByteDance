using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/setPriority 接口的请求。</para>
    /// </summary>
    public class WarehouseSetPriorityRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Address : WarehouseSetAddressRequest.Types.Address
            {
            }
        }

        /// <summary>
        /// 获取或设置仓库地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        public Types.Address Address { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置外部仓库优先级字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priorities")]
        [System.Text.Json.Serialization.JsonPropertyName("priorities")]
        public IDictionary<string, int> OutWarehousePriorityMap { get; set; } = new Dictionary<string, int>();
    }
}
