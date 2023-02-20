using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Events
{
    /// <summary>
    /// <para>表示商品资源事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url </para>
    /// </summary>
    public class ProductResourceEvent : ByteDanceMicroAppProductApiEvent
    {
        /// <summary>
        /// 获取或设置资源路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_tos_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_tos_uri")]
        public string ResourcePath { get; set; } = default!;

        /// <summary>
        /// 获取或设置资源状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_source_status")]
        [System.Text.Json.Serialization.JsonPropertyName("produce_source_status")]
        public int ResourceStatus { get; set; }

        /// <summary>
        /// 获取或设置商品审核结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_source_examine_res")]
        [System.Text.Json.Serialization.JsonPropertyName("produce_source_examine_res")]
        public bool ResourceAuditResult { get; set; }

        /// <summary>
        /// 获取或设置商品审核失败原因字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public IDictionary<string, string[]>? ProductAuditRejectReasonsMap { get; set; }
    }
}
