namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/image_upload 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSImageUploadResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_id")]
        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string ImageId { get; set; } = default!;
    }
}
