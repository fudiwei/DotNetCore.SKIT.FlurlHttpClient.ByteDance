namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/refresh_token 接口的响应。</para>
    /// </summary>
    public class OAuthRefreshTokenResponse : DouyinOpenResponse<OAuthRefreshTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : OAuthAccessTokenResponse.Types.Data
            {
            }
        }
    }
}
