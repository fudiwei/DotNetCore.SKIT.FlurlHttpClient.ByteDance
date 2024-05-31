namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/settle/create_settle 接口的响应。</para>
    /// </summary>
    public class AppsTradeSettleCreateSettleV2Response : DouyinOpenResponse
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
                /// 获取或设置内部分账单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inner_settle_id")]
                [System.Text.Json.Serialization.JsonPropertyName("inner_settle_id")]
                public string InnerSettleId { get; set; } = default!;
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
