namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /opptyProduct/clue 接口的请求。</para>
    /// </summary>
    public class OpportunityProductClueRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置机会品线索类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oppty_clue_type")]
        [System.Text.Json.Serialization.JsonPropertyName("oppty_clue_type")]
        public string OpptyClueType { get; set; } = string.Empty;
    }
}
