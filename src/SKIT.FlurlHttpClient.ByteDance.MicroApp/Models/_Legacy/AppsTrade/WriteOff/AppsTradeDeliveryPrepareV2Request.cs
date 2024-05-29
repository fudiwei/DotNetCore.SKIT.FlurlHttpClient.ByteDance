namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/delivery_prepare 接口的请求。</para>
    /// </summary>
    public class AppsTradeDeliveryPrepareV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置从二维码解析出的加密数据。与字段 <see cref="Code"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypted_data")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_data")]
        public string? EncryptedData { get; set; }

        /// <summary>
        /// 获取或设置用户券码。与字段 <see cref="EncryptedData"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}
