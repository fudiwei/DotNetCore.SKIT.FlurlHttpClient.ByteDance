namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/operation/live_application_status 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppOperationLiveApplicationStatusV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data : OpenApiMicroAppOperationVideoApplicationStatusV1Response.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
