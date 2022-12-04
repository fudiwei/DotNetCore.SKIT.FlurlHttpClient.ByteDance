namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/card/save 接口的响应。</para>
    /// </summary>
    public class EnterpriseIMCardSaveResponse : DouyinOpenResponse<EnterpriseIMCardSaveResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
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
