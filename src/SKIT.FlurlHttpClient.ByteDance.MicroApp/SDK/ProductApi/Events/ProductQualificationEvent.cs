using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Events
{
    /// <summary>
    /// <para>表示商品资质事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url </para>
    /// </summary>
    public class ProductQualificationEvent : ByteDanceMicroAppProductApiEvent
    {
        /// <summary>
        /// 获取或设置审核主体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_name")]
        [System.Text.Json.Serialization.JsonPropertyName("object_name")]
        public string ObjectType { get; set; } = default!;

        /// <summary>
        /// 获取或设置资源状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_status")]
        [System.Text.Json.Serialization.JsonPropertyName("produce_status")]
        public int ProductStatus { get; set; }

        /// <summary>
        /// 获取或设置商品审核结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_examine_res")]
        [System.Text.Json.Serialization.JsonPropertyName("produce_examine_res")]
        public bool ProductAuditResult { get; set; }

        /// <summary>
        /// 获取或设置商品审核失败原因字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public IDictionary<string, string[]>? ProductAuditRejectReasonsMap { get; set; }
    }
}
