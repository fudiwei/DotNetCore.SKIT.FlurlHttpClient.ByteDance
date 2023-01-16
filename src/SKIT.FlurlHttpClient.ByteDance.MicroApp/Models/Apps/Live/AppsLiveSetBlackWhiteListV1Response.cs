namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/live/set_black_white_list 接口的响应。</para>
    /// </summary>
    public class AppsLiveSetBlackWhiteListV1Response : ByteDanceMicroAppResponse
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
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }
    }
}
