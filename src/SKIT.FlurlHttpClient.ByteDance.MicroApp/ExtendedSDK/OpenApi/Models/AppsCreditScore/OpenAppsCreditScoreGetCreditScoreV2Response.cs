namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v2/credit_score/get_credit_score 接口的响应。</para>
    /// </summary>
    public class OpenAppsCreditScoreGetCreditScoreV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置信用分分值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credit_score")]
                [System.Text.Json.Serialization.JsonPropertyName("credit_score")]
                public int CreditScore { get; set; }
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
