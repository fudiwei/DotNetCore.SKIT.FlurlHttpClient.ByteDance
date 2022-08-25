namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/certificate/cancel 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateCancelV1Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置核销记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
        public string VerifyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; } = string.Empty;
    }
}
