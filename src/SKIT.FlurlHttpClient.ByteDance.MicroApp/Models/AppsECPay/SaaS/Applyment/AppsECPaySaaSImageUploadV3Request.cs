using System;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/v3/saas/image_upload/ 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSImageUploadV3Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置图片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_type")]
        [System.Text.Json.Serialization.JsonPropertyName("image_type")]
        public string ImageType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_content")]
        [System.Text.Json.Serialization.JsonPropertyName("image_content")]
        public byte[] ImageFileBytes { get; set; } = Array.Empty<byte>();
    }
}
