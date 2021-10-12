namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/card/save 接口的请求。</para>
    /// </summary>
    public class EnterpriseIMCardSaveRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置卡片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置卡片名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_name")]
        [System.Text.Json.Serialization.JsonPropertyName("card_name")]
        public string? CardName { get; set; }

        /// <summary>
        /// 获取或设置卡片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public string CardType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡片内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
