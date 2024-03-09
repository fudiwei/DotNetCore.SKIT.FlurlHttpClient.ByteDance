using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/icp_record/upload_image/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsICPRecordUploadImageV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置图片类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int ImageType { get; set; }

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
