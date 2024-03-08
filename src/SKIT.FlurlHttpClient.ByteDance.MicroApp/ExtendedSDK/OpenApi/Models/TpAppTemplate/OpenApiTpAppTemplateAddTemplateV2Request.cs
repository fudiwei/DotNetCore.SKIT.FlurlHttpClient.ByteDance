namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /tpapp/v2/template/add_tpl 接口的请求。</para>
    /// </summary>
    public class OpenApiTpAppTemplateAddTemplateV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置草稿 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("draft_id")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
        public long DraftId { get; set; }
    }
}
