namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/utility/check_redeem_amounts/ 接口的请求。</para>
    /// </summary>
    public class MinisUtilityCheckRedeemAmountsRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置代币类型。
        /// <para>默认值："BEANS"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_type")]
        [System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; } = "BEANS";

        /// <summary>
        /// 获取或设置代币数量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_amounts")]
        [System.Text.Json.Serialization.JsonPropertyName("token_amounts")]
        public List<int>? TokenAmountList { get; set; }
    }
}
