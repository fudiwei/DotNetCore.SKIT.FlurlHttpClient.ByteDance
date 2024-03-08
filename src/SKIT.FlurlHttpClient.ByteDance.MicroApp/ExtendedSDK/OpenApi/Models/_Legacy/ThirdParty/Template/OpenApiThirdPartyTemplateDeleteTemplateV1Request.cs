using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/tp/template/del_tpl 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiThirdPartyTemplateDeleteTemplateV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public long TemplateId { get; set; }
    }
}
