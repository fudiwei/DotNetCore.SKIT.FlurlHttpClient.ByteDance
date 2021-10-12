namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/update 接口的响应。</para>
    /// </summary>
    public class EnterpriseLeadsTagUpdateResponse : TikTokResponse<EnterpriseLeadsTagUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_id")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                public long TagId { get; set; }
            }
        }
    }
}
