using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteTpAppAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v2/auth/tp/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/componentaccesstoken-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAuthThirdPartyTokenV2Response> ExecuteOpenAuthThirdPartyTokenV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenAuthThirdPartyTokenV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId is null)
                request.ComponentAppId = client.Credentials.ComponentAppId;

            if (request.ComponentAppSecret is null)
                request.ComponentAppSecret = client.Credentials.ComponentAppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "openapi", "v2", "auth", "token")
                .WithUrl(url => url.RemovePath().AppendPathSegments("openapi", "v2", "auth", "token")) // NOTICE: 特殊入口点
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_appsecret", request.ComponentAppSecret)
                .SetQueryParam("component_ticket", request.ComponentTicket);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAuthThirdPartyTokenV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tpapp/v3/auth/gen_link 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/genlink-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenTpAppAuthGenerateLinkV3Response> ExecuteOpenTpAppAuthGenerateLinkV3Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppAuthGenerateLinkV3Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tpapp", "v3", "auth", "gen_link")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppAuthGenerateLinkV3Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /tpapp/v2/auth/get_auth_token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authorizeraccesstoken-v2 ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authorizerrefreshtoken-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenTpAppAuthGetAuthTokenV2Response> ExecuteOpenTpAppAuthGetAuthTokenV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppAuthGetAuthTokenV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "auth", "get_auth_token")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("authorization_code", request.AuthorizationCode)
                .SetQueryParam("authorizer_refresh_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppAuthGetAuthTokenV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tpapp/v2/auth/retrieve_auth_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/findauthorizationcode-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenTpAppAuthRetrieveAuthCodeV2Response> ExecuteOpenTpAppAuthRetrieveAuthCodeV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppAuthRetrieveAuthCodeV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tpapp", "v2", "auth", "retrieve_auth_code")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppAuthRetrieveAuthCodeV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /tpapp/v2/auth/get_auth_app_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authapplist-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenTpAppAuthGetAuthAppListV2Response> ExecuteOpenTpAppAuthGetAuthAppListV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppAuthGetAuthAppListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "auth", "get_auth_app_list")
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize)
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppAuthGetAuthAppListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
