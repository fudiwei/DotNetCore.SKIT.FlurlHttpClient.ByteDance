﻿namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/app/check_app_name 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppCheckAppNameV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置待检测的小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AppName { get; set; } = string.Empty;
    }
}
