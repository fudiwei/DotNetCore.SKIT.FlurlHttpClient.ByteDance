using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/file/upload_material 接口的请求。</para>
    /// </summary>
    public class OpenAppsFileUploadMaterialV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置上传文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int MaterialType { get; set; }

        /// <summary>
        /// 获取或设置上传文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] MaterialFileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置上传文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MaterialFileName { get; set; }

        /// <summary>
        /// 获取或设置上传文件 MIME 类型。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MaterialFileContentType { get; set; }
    }
}
