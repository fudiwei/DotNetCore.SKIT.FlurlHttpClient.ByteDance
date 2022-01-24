namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/message/custom/send 接口的响应。</para>
    /// </summary>
    public class AppsMessageCustomSendResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public override int ErrorNumber { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public override string? ErrorMessage { get; set; }
    }
}
