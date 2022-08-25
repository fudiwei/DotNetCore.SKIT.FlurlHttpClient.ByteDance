namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [GET] /v0/oauth/get_qrcode 接口的响应。</para>
    /// </summary>
    public class OAuthGetQrcodeResponse : TikTokResponse<OAuthGetQrcodeResponse.Types.Data>
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
                /// 获取或设置二维码链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scan_qrcode_url")]
                [System.Text.Json.Serialization.JsonPropertyName("scan_qrcode_url")]
                public string ScanQrcodeUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置二维码令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("token")]
                [System.Text.Json.Serialization.JsonPropertyName("token")]
                public string Token { get; set; } = default!;
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
