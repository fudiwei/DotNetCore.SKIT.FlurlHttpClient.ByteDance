using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/image_upload 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSImageUploadRequest : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。与字段 <see cref="ComponentAppId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。与字段 <see cref="AppId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// 与字段 <see cref="ComponentAccessToken"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。与字段 <see cref="AccessToken"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("component_access_token")]
        public string? ComponentAccessToken { get; set; }

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
