namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/code2session 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppCode2SessionV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置登录 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置匿名登录 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AnoymousCode { get; set; }
    }
}
