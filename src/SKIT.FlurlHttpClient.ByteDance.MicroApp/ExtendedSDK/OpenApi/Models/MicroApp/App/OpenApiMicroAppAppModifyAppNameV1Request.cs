namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_app_name 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppModifyAppNameV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置准备修改的小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_name")]
        [System.Text.Json.Serialization.JsonPropertyName("new_name")]
        public string NewName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审核材料路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_file_path")]
        [System.Text.Json.Serialization.JsonPropertyName("material_file_path")]
        public string? MaterialFilePath { get; set; }
    }
}
