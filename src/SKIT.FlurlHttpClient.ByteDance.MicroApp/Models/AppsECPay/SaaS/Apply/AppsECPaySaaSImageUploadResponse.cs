namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/image_upload 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSImageUploadResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_id")]
        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string ImageId { get; set; } = default!;
    }
}
