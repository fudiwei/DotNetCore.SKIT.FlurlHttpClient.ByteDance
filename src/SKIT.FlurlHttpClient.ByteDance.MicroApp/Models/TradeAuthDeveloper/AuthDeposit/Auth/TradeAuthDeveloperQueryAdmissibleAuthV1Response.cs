namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_admissible_auth/ 接口的响应。</para>
    /// </summary>
    public class TradeAuthDeveloperQueryAdmissibleAuthV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置准入性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admissibility")]
                [System.Text.Json.Serialization.JsonPropertyName("admissibility")]
                public int Admissibility { get; set; }

                /// <summary>
                /// 获取或设置准入 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admissible_token")]
                [System.Text.Json.Serialization.JsonPropertyName("admissible_token")]
                public string? AdmissibleToken { get; set; }

                /// <summary>
                /// 获取或设置过期时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_seconds")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
                public int? ExpiresIn { get; set; }
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
