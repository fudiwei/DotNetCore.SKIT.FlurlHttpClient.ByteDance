namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/app/credit_score 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppAppCreditScoreV1Response : OpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置信用分分值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creditScore")]
                [System.Text.Json.Serialization.JsonPropertyName("creditScore")]
                public int CreditScore { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
