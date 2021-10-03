namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/authorize/v2 接口的响应。</para>
    /// </summary>
    public class OAuthAuthorizeV2Response : TikTokResponse<OAuthAuthorizeV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : OAuthAuthorizeResponse.Types.Data
            {
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
