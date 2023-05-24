namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/upload_video_part 接口的请求。</para>
    /// </summary>
    public class VideoPartUploadRequest : VideoUploadRequest
    {
        /// <summary>
        /// 获取或设置上传 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分片编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PartNumber { get; set; }
    }
}
