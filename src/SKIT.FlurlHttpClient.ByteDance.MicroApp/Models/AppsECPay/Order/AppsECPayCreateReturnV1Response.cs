namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/create_return 接口的响应。</para>
    /// </summary>
    public class AppsECPayCreateReturnV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Return : AppsECPayQueryReturnV1Response.Types.Return
            {
            }
        }

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
        /// 获取或设置分账回退信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_info")]
        [System.Text.Json.Serialization.JsonPropertyName("return_info")]
        public Types.Return Return { get; set; } = default!;
    }
}
