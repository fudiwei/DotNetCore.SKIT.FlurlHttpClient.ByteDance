namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/bankAccountVerify 接口的请求。</para>
    /// </summary>
    public class CrossBorderBankAccountVerifyRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置币种。
        /// <para>默认值：CNY</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency")]
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string Currency { get; set; } = "CNY";

        /// <summary>
        /// 获取或设置账户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_name")]
        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account_no")]
        public string BankAccountNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开户行名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string BankName { get; set; } = string.Empty;
    }
}
