namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/update 接口的响应。</para>
    /// </summary>
    public class EnterpriseLeadsTagUpdateResponse : DouyinOpenResponse<EnterpriseLeadsTagUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
