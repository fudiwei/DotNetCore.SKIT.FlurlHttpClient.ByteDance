namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /upload_material 接口的响应。</para>
    /// </summary>
    public class AuthEntityUploadMaterialResponse: ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置资源路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string Path { get; set; } = default!;
    }
}
