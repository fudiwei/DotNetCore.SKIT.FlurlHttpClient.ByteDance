namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/tp/template/add_tpl 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyTemplateAddTemplateV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置草稿 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("draft_id")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
        public long DraftId { get; set; }
    }
}
