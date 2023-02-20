using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Events
{
    /// <summary>
    /// <para>表示商品履约内容事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url </para>
    /// </summary>
    public class ProductFulfilmentEvent : ByteDanceMicroAppProductApiEvent
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_id")]
        [System.Text.Json.Serialization.JsonPropertyName("produce_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_name")]
        [System.Text.Json.Serialization.JsonPropertyName("produce_name")]
        public string ProductName { get; set; } = default!;

        /// <summary>
        /// 获取或设置履约文件资源路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_uri")]
        public string FulfillmentPath { get; set; } = default!;

        /// <summary>
        /// 获取或设置履约文件审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
        public int FulfillmentAuditStatus { get; set; }

        /// <summary>
        /// 获取或设置商品审核失败位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position")]
        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public string? FulfillmentAuditRejectPosition { get; set; }

        /// <summary>
        /// 获取或设置商品审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FulfillmentAuditRejectReason { get; set; }
    }
}
