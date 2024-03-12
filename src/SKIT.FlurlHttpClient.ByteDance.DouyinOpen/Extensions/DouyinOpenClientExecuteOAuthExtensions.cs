using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /oauth/client_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/client-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/non-user-authorization/get-client_token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthClientTokenResponse> ExecuteOAuthClientTokenAsync(this DouyinOpenClient client, Models.OAuthClientTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret is null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "client_token/");

            return await client.SendFlurlRequestAsJsonAsync<Models.OAuthClientTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/access_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/get-access-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/user-authorization/get-user-access-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthAccessTokenResponse> ExecuteOAuthAccessTokenAsync(this DouyinOpenClient client, Models.OAuthAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret is null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "access_token/");

            return await client.SendFlurlRequestAsJsonAsync<Models.OAuthAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/refresh_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/refresh-access-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/user-authorization/refresh-user-access-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRefreshTokenResponse> ExecuteOAuthRefreshTokenAsync(this DouyinOpenClient client, Models.OAuthRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "refresh_token/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/renew_refresh_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/refresh-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/user-authorization/refresh-user-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRenewRefreshTokenResponse> ExecuteOAuthRenewRefreshTokenAsync(this DouyinOpenClient client, Models.OAuthRenewRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "renew_refresh_token/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthRenewRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/business_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/business-token/get-business-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthBusinessTokenResponse> ExecuteOAuthBusinessTokenAsync(this DouyinOpenClient client, Models.OAuthBusinessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.WebhookSecret is null)
                request.WebhookSecret = client.Credentials.WebhookSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "business_token/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OAuthBusinessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/refresh_biz_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/business-token/refresh-business-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRefreshBusinessTokenResponse> ExecuteOAuthRefreshBusinessTokenAsync(this DouyinOpenClient client, Models.OAuthRefreshBusinessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.WebhookSecret is null)
                request.WebhookSecret = client.Credentials.WebhookSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "refresh_biz_token/");

            return await client.SendFlurlRequestAsJsonAsync<Models.OAuthRefreshBusinessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/business_scopes/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/business-token/query-business ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthBusinessScopesResponse> ExecuteOAuthBusinessScopesAsync(this DouyinOpenClient client, Models.OAuthBusinessScopesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "business_scopes/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OAuthBusinessScopesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region User
        /// <summary>
        /// <para>异步调用 [POST] /oauth/userinfo/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-management/get-account-open-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthUserInfoResponse> ExecuteOAuthUserInfoAsync(this DouyinOpenClient client, Models.OAuthUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "userinfo/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
