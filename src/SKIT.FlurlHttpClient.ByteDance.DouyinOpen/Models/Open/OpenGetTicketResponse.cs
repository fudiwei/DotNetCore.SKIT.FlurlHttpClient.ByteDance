namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /open/getticket 接口的响应。</para>
    /// </summary>
    public class OpenGetTicketResponse : DouyinOpenResponse<OpenGetTicketResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置 JS 接口调用凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket")]
                public string Ticket { get; set; } = default!;

                /// <summary>
                /// 获取或设置凭证有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public long ExpiresIn { get; set; }
            }
        }
    }
}
