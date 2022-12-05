namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/invoiceUpload 接口的请求。</para>
    /// </summary>
    public class OrderInvoiceUploadRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发票文件字节数组（与字段 <see cref="FileUrl"/> 二选一）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? FileBytes { get; set; }

        /// <summary>
        /// 获取或设置发票文件 URL（与字段 <see cref="FileBytes"/> 二选一）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_file")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_file")]
        public string? FileUrl { get; set; }
    }
}
