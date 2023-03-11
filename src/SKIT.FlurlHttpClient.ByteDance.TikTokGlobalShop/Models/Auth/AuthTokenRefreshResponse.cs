namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /token/refresh 接口的响应。</para>
    /// </summary>
    public class AuthTokenRefreshResponse : TikTokShopResponse<AuthTokenRefreshResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : AuthTokenGetResponse.Types.Data
            {
            }
        }
    }
}
