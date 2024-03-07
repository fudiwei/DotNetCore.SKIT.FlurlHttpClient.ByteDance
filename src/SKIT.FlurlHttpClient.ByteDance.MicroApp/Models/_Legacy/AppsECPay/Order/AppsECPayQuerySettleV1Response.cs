namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/query_settle 接口的响应。</para>
    /// </summary>
    public class AppsECPayQuerySettleV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Settlement
            {
                /// <summary>
                /// 获取或设置担保交易分账单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
                public string SettleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                public int SettleAmount { get; set; }

                /// <summary>
                /// 获取或设置分账状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_status")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_status")]
                public string SettleStatus { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结算信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
        public Types.Settlement Settlement { get; set; } = default!;
    }
}
