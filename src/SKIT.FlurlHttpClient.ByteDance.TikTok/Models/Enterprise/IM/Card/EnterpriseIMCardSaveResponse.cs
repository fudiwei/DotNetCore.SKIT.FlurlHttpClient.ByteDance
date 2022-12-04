namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/card/save 接口的响应。</para>
    /// </summary>
    public class EnterpriseIMCardSaveResponse : TikTokResponse<EnterpriseIMCardSaveResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置卡片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = default!;
            }
        }
    }
}
