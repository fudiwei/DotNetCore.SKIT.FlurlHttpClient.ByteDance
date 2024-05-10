namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /token/refresh 接口的响应。</para>
    /// </summary>
    public class AuthRefreshTokenResponse : TikTokShopLegacyResponse<AuthRefreshTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : AuthGetTokenResponse.Types.Data
            {
            }
        }
    }
}
