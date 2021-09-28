using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/addSerialNumber 接口的请求。</para>
    /// </summary>
    public class OrderAddSerialNumberRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置序列号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serial_number_list")]
        [System.Text.Json.Serialization.JsonPropertyName("serial_number_list")]
        public IList<string> SerialNumberList { get; set; } = new List<string>();
    }
}
