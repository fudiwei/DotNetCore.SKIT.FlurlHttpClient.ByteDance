namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/revoke 接口的响应。</para>
    /// </summary>
    public class OAuthRevokeResponse : TikTokResponse<OAuthRevokeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResponseData
            {
                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? ErrorDescription { get; set; }
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
