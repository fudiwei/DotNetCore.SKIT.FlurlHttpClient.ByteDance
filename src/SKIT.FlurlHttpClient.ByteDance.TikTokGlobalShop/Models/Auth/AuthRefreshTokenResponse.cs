namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /token/refresh 接口的响应。</para>
    /// </summary>
    public class AuthRefreshTokenResponse : TikTokShopResponse<AuthRefreshTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : AuthGetTokenResponse.Types.Data
            {
            }
        }
    }
}
