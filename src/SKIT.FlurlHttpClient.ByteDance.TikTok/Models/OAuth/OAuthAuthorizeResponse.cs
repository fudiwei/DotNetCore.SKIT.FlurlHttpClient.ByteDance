namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/authorize 接口的响应。</para>
    /// </summary>
    public class OAuthAuthorizeResponse : TikTokResponse<OAuthAuthorizeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : OAuthAccessTokenResponse.Types.Data
            {
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
