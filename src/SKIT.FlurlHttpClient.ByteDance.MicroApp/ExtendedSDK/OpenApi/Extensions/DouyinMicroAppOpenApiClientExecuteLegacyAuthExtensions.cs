using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteLegacyAuthExtensions
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
                .SetQueryParam("authorization_code", request.AuthorizationCode)
                .SetQueryParam("authorizer_refresh_token", request.AuthorizerRefreshToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiOAuthTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/auth/tp/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/componentaccesstoken ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthThirdPartyTokenV1Response> ExecuteOpenApiAuthThirdPartyTokenV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthThirdPartyTokenV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppSecret is null)
                request.ComponentAppSecret = client.Credentials.ComponentAppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "auth", "tp", "token")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "auth", "tp", "token"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_appsecret", request.ComponentAppSecret)
                .SetQueryParam("component_ticket", request.ComponentTicket);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthThirdPartyTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/auth/pre_auth_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/preauthcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthPreAuthCodeV2Response> ExecuteOpenApiAuthPreAuthCodeV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthPreAuthCodeV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "auth", "pre_auth_code")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v2", "auth", "pre_auth_code"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthPreAuthCodeV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/auth/gen_link 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/genlink ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthGenerateLinkV2Response> ExecuteOpenApiAuthGenerateLinkV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthGenerateLinkV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "auth", "gen_link")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v2", "auth", "gen_link"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthGenerateLinkV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/auth/retrieve 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/findauthorizationcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthRetrieveV1Response> ExecuteOpenApiAuthRetrieveV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthRetrieveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "auth", "retrieve")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "auth", "retrieve"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("authorization_appid", request.AuthorizerAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthRetrieveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
