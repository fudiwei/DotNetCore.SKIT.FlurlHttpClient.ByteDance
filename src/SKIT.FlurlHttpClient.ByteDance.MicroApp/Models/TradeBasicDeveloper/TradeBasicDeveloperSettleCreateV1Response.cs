namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/settle_create/ 接口的响应。</para>
    /// </summary>
    public class TradeBasicDeveloperSettleCreateV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置分账单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_id")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_id")]
                public string SettleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置底层分账单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wallet_settle_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wallet_settle_id")]
                public string WalletSettleId { get; set; } = default!;
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
