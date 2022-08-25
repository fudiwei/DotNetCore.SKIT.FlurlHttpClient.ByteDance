namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/query 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateQueryV1Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置加密券码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EncryptedCode { get; set; }

        /// <summary>
        /// 获取或设置抖音订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OrderId { get; set; }
    }
}
