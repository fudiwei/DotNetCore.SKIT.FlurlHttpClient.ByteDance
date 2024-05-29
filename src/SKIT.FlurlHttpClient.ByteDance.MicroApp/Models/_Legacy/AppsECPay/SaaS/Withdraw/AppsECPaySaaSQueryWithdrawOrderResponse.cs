namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/query_withdraw_order 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSQueryWithdrawOrderResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置提现状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置提现状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("status_msg")]
        public string StatusMessage { get; set; } = default!;
    }
}
