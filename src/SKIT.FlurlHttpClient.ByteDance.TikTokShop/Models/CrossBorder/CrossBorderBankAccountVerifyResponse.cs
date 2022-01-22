namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/bankAccountVerify 接口的响应。</para>
    /// </summary>
    public class CrossBorderBankAccountVerifyResponse : TikTokShopResponse<CrossBorderBankAccountVerifyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置受理结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acceptance_result")]
                [System.Text.Json.Serialization.JsonPropertyName("acceptance_result")]
                public string AcceptanceResult { get; set; } = default!;

                /// <summary>
                /// 获取或设置校验结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verification_result")]
                [System.Text.Json.Serialization.JsonPropertyName("verification_result")]
                public string VerificationResult { get; set; } = default!;
            }
        }
    }
}
