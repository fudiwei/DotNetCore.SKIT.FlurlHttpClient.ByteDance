using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/tp/upload_pic_material 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyUploadPictureMaterialV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置第三方应用 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传的文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int MaterialType { get; set; }

        /// <summary>
        /// 获取或设置资源文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] MaterialFileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置封面图片文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MaterialFileName { get; set; }
    }
}
