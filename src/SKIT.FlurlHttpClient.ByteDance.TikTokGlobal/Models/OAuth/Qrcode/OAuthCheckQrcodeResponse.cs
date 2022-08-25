namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [GET] /v0/oauth/check_qrcode 接口的响应。</para>
    /// </summary>
    public class OAuthCheckQrcodeResponse : TikTokResponse<OAuthCheckQrcodeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? ErrorDescription { get; set; }

                /// <summary>
                /// 获取或设置二维码状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户端票据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("client_ticket")]
                [System.Text.Json.Serialization.JsonPropertyName("client_ticket")]
                public string ClientTicket { get; set; } = default!;

                /// <summary>
                /// 获取或设置跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("redirect_url")]
                [System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
                public string? RedirectUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置响应状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? ResponseMessage { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && !"error".Equals(ResponseMessage);
        }
    }
}
