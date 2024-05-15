using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/deliver 接口的请求。</para>
    /// </summary>
    public class FulfillmentBatchUpdatePackagesDeliveryStatusRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Package
            {
                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string PackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置配送类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public string DeliveryType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_delivery_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_delivery_reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置文件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_type")]
                [System.Text.Json.Serialization.JsonPropertyName("file_type")]
                public string? FileType { get; set; }

                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_url")]
                [System.Text.Json.Serialization.JsonPropertyName("file_url")]
                public string? FileUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packages")]
        [System.Text.Json.Serialization.JsonPropertyName("packages")]
        public IList<Types.Package> PackageList { get; set; } = new List<Types.Package>();
    }
}
