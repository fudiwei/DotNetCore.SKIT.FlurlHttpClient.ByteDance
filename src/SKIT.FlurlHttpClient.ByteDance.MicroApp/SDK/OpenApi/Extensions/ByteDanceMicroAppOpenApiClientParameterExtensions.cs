using Flurl;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi
{
    public static class ByteDanceMicroAppOpenApiClientParameterExtensions
    {
        /// <summary>
        /// <para>生成第三方应用服务商授权 URL。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/authorization/admin </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="preAuthCode"></param>
        /// <param name="redirectUrl"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForOpenComponentThirdPartyAuthorization(this ByteDanceMicroAppOpenApiClient client, string preAuthCode, string redirectUrl)
        {
            return new Url(ByteDanceMicroAppOpenApiEndpoints.DEFAULT)
                .AppendPathSegments("mappconsole", "tp", "authorization")
                .SetQueryParam("component_appid", client.Credentials.ComponentAppId)
                .SetQueryParam("pre_auth_code", preAuthCode)
                .SetQueryParam("redirect_uri", redirectUrl)
                .ToString();
        }
    }
}
