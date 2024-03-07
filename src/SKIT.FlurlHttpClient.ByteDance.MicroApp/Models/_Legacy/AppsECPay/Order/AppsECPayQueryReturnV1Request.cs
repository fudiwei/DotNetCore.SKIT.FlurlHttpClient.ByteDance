namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/query_return 接口的请求。</para>
    /// </summary>
    public class AppsECPayQueryReturnV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户回退单号。与字段 <see cref="ReturnNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_return_no")]
        public string? OutReturnNumber { get; set; }

        /// <summary>
        /// 获取或设置平台回退单号。与字段 <see cref="OutReturnNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("return_no")]
        public string? ReturnNumber { get; set; }

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }
    }
}
