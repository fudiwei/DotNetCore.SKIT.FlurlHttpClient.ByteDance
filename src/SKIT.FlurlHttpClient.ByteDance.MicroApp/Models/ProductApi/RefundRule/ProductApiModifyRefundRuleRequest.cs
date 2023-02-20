using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/modify_refund_rule 接口的请求。</para>
    /// </summary>
    public class ProductApiModifyRefundRuleRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置审核参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CheckType { get; set; }

        /// <summary>
        /// 获取或设置商品 ID 以及对应的规则 ID 字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_rule_map")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_rule_map")]
        public IDictionary<long, int> ProductRefundRuleMap { get; set; } = new Dictionary<long, int>();
    }
}
