using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/confirm/prepare 接口的请求。</para>
    /// </summary>
    public class POIOrderConfirmPrepareRequest : DouyinOpenRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public override string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券码 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("code_list")]
        public IList<string> CodeList { get; set; } = new List<string>();
    }
}
