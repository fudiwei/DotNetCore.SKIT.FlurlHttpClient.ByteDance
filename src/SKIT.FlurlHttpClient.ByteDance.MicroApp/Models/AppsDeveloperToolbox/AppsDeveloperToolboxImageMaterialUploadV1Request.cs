namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/developer_toolbox/image_material/upload/ 接口的请求。</para>
    /// </summary>
    public class AppsDeveloperToolboxImageMaterialUploadV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置图片素材 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_material_url")]
        [System.Text.Json.Serialization.JsonPropertyName("image_material_url")]
        public string ImageMaterialUrl { get; set; } = string.Empty;
    }
}
