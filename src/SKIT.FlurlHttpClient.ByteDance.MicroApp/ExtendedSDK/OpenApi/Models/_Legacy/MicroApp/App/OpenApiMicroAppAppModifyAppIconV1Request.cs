using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_app_icon 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiMicroAppAppModifyAppIconV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置准备修改的小程序图标路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_icon_path")]
        [System.Text.Json.Serialization.JsonPropertyName("new_icon_path")]
        public string NewIconPath { get; set; } = string.Empty;
    }
}
