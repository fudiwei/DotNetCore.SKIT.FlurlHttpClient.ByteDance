namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/url_link/generate 接口的响应。</para>
    /// </summary>
    public class AppsUrlLinkGenerateResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置分享链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link")]
        public string UrlLink { get; set; } = default!;
    }
}
