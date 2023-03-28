namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/shipping_document 接口的请求。</para>
    /// </summary>
    public class FulfillmentGetPackageShippingDocumentRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DocumentType { get; set; }

        /// <summary>
        /// 获取或设置文件尺寸。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? DocumentSize { get; set; }
    }
}
