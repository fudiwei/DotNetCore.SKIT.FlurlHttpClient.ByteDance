using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /oauth/access_token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/get-access-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthAccessTokenResponse> ExecuteOAuthAccessTokenAsync(this TikTokClient client, Models.OAuthAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey == null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret == null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "access_token");

            return await client.SendRequestWithJsonAsync<Models.OAuthAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/renew_refresh_token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/refresh-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRenewRefreshTokenResponse> ExecuteOAuthRenewRefreshTokenAsync(this TikTokClient client, Models.OAuthRenewRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey == null)
                request.ClientKey = client.Credentials.ClientKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "renew_refresh_token");

            return await client.SendRequestWithJsonAsync<Models.OAuthRenewRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/client_token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/client-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthClientTokenResponse> ExecuteOAuthClientTokenAsync(this TikTokClient client, Models.OAuthClientTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey == null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret == null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "client_token");

            return await client.SendRequestWithJsonAsync<Models.OAuthClientTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/refresh_token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/refresh-access-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRefreshTokenResponse> ExecuteOAuthRefreshTokenAsync(this TikTokClient client, Models.OAuthRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey == null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret == null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "refresh_token");

            return await client.SendRequestWithJsonAsync<Models.OAuthRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region User
        /// <summary>
        /// <para>异步调用 [GET] /oauth/userinfo 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-management/get-account-open-info </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthUserInfoResponse> ExecuteOAuthUserInfoAsync(this TikTokClient client, Models.OAuthUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "oauth", "userinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.OAuthUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
