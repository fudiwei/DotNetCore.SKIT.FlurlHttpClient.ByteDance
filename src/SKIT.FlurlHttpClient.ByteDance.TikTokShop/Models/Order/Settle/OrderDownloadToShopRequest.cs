namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/downloadToShop 接口的请求。</para>
    /// </summary>
    public class OrderDownloadToShopRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置生成的下载 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_id")]
        [System.Text.Json.Serialization.JsonPropertyName("download_id")]
        public string DownloadId { get; set; } = string.Empty;
    }
}
