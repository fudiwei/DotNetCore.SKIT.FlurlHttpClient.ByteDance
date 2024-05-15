namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/packages/{package_id}/shipping_documents 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetPackageShippingDocumentsResponse : TikTokShopResponse<FulfillmentGetPackageShippingDocumentsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_url")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_url")]
                public string DocumentUrl { get; set; } = default!;
            }
        }
    }
}
