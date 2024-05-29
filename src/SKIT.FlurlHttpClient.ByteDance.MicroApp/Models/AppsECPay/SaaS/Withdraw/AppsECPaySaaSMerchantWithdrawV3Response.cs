namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/merchant_withdraw/ 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSMerchantWithdrawV3Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置商户主体标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_entity")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_entity")]
                public int? MerchantEntity { get; set; }

                /// <summary>
                /// 获取或设置平台提现单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
