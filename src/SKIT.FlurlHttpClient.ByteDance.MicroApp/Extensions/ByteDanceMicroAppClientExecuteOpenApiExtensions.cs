using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteOpenApiExtensions
    {
        #region Auth
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/auth/tp/token 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/access </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1AuthThirdPartyTokenResponse> ExecuteOpenApiV1AuthThirdPartyTokenAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1AuthThirdPartyTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.ComponentAppSecret == null)
                request.ComponentAppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "auth", "tp", "token")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_appsecret", request.ComponentAppSecret)
                .SetQueryParam("component_ticket", request.ComponentTicket);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1AuthThirdPartyTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/auth/pre_auth_code 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/auth </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1AuthPreAuthCodeResponse> ExecuteOpenApiV1AuthPreAuthCodeAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1AuthPreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1AuthPreAuthCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v2/auth/pre_auth_code 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/auth </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV2AuthPreAuthCodeResponse> ExecuteOpenApiV2AuthPreAuthCodeAsync(this ByteDanceMicroAppClient client, Models.OpenApiV2AuthPreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v2", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV2AuthPreAuthCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/auth/retrieve 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/find </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1AuthRetrieveResponse> ExecuteOpenApiV1AuthRetrieveAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1AuthRetrieveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "auth", "retrieve")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("authorization_appid", request.AuthorizerAppId);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1AuthRetrieveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region OAuth
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/oauth/token 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/voucher </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/update </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1OAuthTokenResponse> ExecuteOpenApiV1OAuthTokenAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1OAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "oauth", "token")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("grant_type", request.GrantType);

            if (request.AuthCode != null)
                flurlReq.SetQueryParam("authorization_code", request.AuthCode);

            if (request.AuthorizerRefreshToken != null)
                flurlReq.SetQueryParam("authorizer_refresh_token", request.AuthorizerRefreshToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1OAuthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
