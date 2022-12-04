using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/confirm 接口的请求。</para>
    /// </summary>
    public class POIOrderConfirmRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
        public string OrderExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券码 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("code_list")]
        public IList<string> CodeList { get; set; } = new List<string>();
    }
}
