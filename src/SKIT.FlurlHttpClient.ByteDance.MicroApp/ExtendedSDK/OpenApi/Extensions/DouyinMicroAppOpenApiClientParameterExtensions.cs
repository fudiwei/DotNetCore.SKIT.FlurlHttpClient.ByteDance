using Flurl;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientParameterExtensions
    {
        private const string BASE_URL = "https://open.microapp.bytedance.com";

        /// <summary>
        /// <para>生成第三方应用服务商授权 URL。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/createlink ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="preAuthCode"></param>
        /// <param name="redirectUrl"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForOpenComponentThirdPartyAuthorization(this DouyinMicroAppOpenApiClient client, string preAuthCode, string redirectUrl)
        {
            return new Url(BASE_URL)
                .AppendPathSegments("mappconsole", "tp", "authorization")
                .SetQueryParam("component_appid", client.Credentials.ComponentAppId)
                .SetQueryParam("pre_auth_code", preAuthCode)
                .SetQueryParam("redirect_uri", redirectUrl)
                .ToString();
        }
    }
}
