using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteLegacyOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /v1/oauth/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authorizeraccesstoken ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authorizerrefreshtoken ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiOAuthTokenV1Response> ExecuteOpenApiOAuthTokenV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiOAuthTokenV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "oauth", "token")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "oauth", "token"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("authorization_code", request.AuthCode)
                .SetQueryParam("authorizer_refresh_token", request.AuthorizerRefreshToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiOAuthTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
