namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v2/auth/pre_auth_code 接口的请求。</para>
    /// </summary>
    public class OpenApiAuthPreAuthCodeV2Request : OpenApiAuthPreAuthCodeV1Request
    {
        /// <summary>
        /// 获取或设置服务商的分账比例上限（范围：0～30）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("share_ratio")]
        public int? ShareRatio { get; set; }

        /// <summary>
        /// 获取或设置服务商的分账金额上限（范围：0～50）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("share_amount")]
        public int? ShareAmount { get; set; }
    }
}
