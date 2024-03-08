using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /file/card_image/upload 接口的请求。</para>
    /// </summary>
    public class WebcastFileCardImageUploadRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ImageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] ImageFileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置图片文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageFileName { get; set; }

        /// <summary>
        /// 获取或设置图片文件 MIME 类型。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageFileContentType { get; set; }
    }
}
