using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/delivery 接口的请求。</para>
    /// </summary>
    public class FulfillmentUpdatePackageDeliveryStatusRequest : TikTokShopLegacyRequest
    {
        public static class Types
        {
            public class Package
            {
                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                public string PackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置配送类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int? DeliveryType { get; set; }

                /// <summary>
                /// 获取或设置原因编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public int? ReasonCode { get; set; }

                /// <summary>
                /// 获取或设置附件文件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_type")]
                [System.Text.Json.Serialization.JsonPropertyName("file_type")]
                public int? AttachmentFileType { get; set; }

                /// <summary>
                /// 获取或设置附件文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_url")]
                [System.Text.Json.Serialization.JsonPropertyName("file_url")]
                public string? AttachmentFileUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_packages")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_packages")]
        public IList<Types.Package> PackageList { get; set; } = new List<Types.Package>();
    }
}
