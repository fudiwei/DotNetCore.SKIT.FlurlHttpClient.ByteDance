using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify_refund_rule 接口的请求。</para>
    /// </summary>
    public class ProductApiModifyRefundRuleRequest : DouyinMicroAppProductApiRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 以及对应的规则 ID 字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_rule_map")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_rule_map")]
        public IDictionary<long, int> ProductRefundRuleMap { get; set; } = new Dictionary<long, int>();
    }
}
