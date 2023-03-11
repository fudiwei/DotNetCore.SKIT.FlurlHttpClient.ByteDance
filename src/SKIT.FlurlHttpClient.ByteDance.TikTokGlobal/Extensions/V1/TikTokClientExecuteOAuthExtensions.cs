using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /oauth/access_token/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-manage-user-access-tokens </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthAccessTokenResponse> ExecuteOAuthAccessTokenAsync(this TikTokClient client, Models.OAuthAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "access_token/")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("client_secret", client.Credentials.ClientSecret)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.OAuthAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/refresh_token/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-manage-user-access-tokens </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRefreshTokenResponse> ExecuteOAuthRefreshTokenAsync(this TikTokClient client, Models.OAuthRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "refresh_token/")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("refresh_token", request.RefreshToken);

            return await client.SendRequestWithJsonAsync<Models.OAuthRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/revoke/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-manage-user-access-tokens </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRevokeResponse> ExecuteOAuthRevokeAsync(this TikTokClient client, Models.OAuthRevokeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "revoke/")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OAuthRevokeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [GET] /v0/oauth/get_qrcode 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-qr-code-authorization/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthGetQrcodeResponse> ExecuteOAuthGetQrcodeAsync(this TikTokClient client, Models.OAuthGetQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "v0", "oauth", "get_qrcode")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("scope", request.Scope)
                .SetQueryParam("next", request.CallbackUrl)
                .SetQueryParam("state", request.State);

            return await client.SendRequestWithJsonAsync<Models.OAuthGetQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v0/oauth/check_qrcode 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-qr-code-authorization/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthCheckQrcodeResponse> ExecuteOAuthCheckQrcodeAsync(this TikTokClient client, Models.OAuthCheckQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "v0", "oauth", "check_qrcode")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("scope", request.Scope)
                .SetQueryParam("next", request.CallbackUrl)
                .SetQueryParam("token", request.Token);

            return await client.SendRequestWithJsonAsync<Models.OAuthCheckQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
