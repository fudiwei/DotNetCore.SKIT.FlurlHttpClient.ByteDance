namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/access_token 接口的响应。</para>
    /// </summary>
    public class OAuthAccessTokenResponse : TikTokResponse<OAuthAccessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : PlatformOAuthConnectResponse.Types.Data
            {
            }
        }
    }
}
