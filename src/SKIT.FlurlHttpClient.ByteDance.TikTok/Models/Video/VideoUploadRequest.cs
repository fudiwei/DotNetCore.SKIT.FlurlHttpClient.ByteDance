using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/upload 接口的请求。</para>
    /// </summary>
    public class VideoUploadRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置视频文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] VideoFileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置视频文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? VideoFileName { get; set; }

        /// <summary>
        /// 获取或设置视频文件类型。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? VideoContentType { get; set; }
    }
}
