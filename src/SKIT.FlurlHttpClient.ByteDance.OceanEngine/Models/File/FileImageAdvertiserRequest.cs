namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/image/advertiser 接口的请求。</para>
    /// </summary>
    public class FileImageAdvertiserRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置上传类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传资质。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadTo { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片 URL。与字段 <see cref="ImageFileBytes"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 获取或设置图片文件字节数组。与字段 <see cref="ImageUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? ImageFileBytes { get; set; }

        /// <summary>
        /// 获取或设置图片文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageFileName { get; set; }

        /// <summary>
        /// 获取或设置图片文件 MD5 哈希值。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageFileHash { get; set; }

        /// <summary>
        /// 获取或设置图片文件类型。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageContentType { get; set; }
    }
}
