namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /token/refresh 接口的响应。</para>
    /// </summary>
    public class TokenRefreshResponse : TikTokShopResponse<TokenRefreshResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TokenCreateResponse.Types.Data
            {
            }
        }
    }
}
