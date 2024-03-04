using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [PUT] /{upload_url} 接口的请求。</para>
    /// </summary>
    public class PostUploadVideoRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置文件上传地址。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频分片字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] ChunkBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置视频分片起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long ChunkContentRangeStart { get; set; }

        /// <summary>
        /// 获取或设置视频分片结束位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long ChunkContentRangeEnd { get; set; }

        /// <summary>
        /// 获取或设置视频文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ChunkContentType { get; set; }

        /// <summary>
        /// 获取或设置视频文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long VideoSize { get; set; }
    }
}
