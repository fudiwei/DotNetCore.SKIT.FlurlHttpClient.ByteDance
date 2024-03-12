namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/refresh_biz_token/ 接口的响应。</para>
    /// </summary>
    public class OAuthRefreshBusinessTokenResponse : DouyinOpenResponse<OAuthRefreshBusinessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : OAuthBusinessTokenResponse.Types.Data
            {
            }
        }
    }
}
