using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/code2session 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-04-08 下线。")]
    public class OpenApiMicroAppCode2SessionV1Request : DouyinMicroAppOpenApiRequest
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
