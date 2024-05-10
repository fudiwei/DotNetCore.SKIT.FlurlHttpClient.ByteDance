namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/uploadfile 接口的请求。</para>
    /// </summary>
    public class FulfillmentUploadFileRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置经 Base64 编码的文件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_data")]
        [System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string EncodingFileData { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string FileName { get; set; } = string.Empty;
    }
}
