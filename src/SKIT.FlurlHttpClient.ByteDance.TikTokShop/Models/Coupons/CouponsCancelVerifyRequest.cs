namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /coupons/cancelVerify 接口的请求。</para>
    /// </summary>
    public class CouponsCancelVerifyRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置卡券券码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_no")]
        public string CertNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置幂等请求编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_no")]
        public string? BatchNumber { get; set; }

        /// <summary>
        /// 获取或设置取消核销总次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_verify_count")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_verify_count")]
        public int? CancelVerifyCount { get; set; }
    }
}
