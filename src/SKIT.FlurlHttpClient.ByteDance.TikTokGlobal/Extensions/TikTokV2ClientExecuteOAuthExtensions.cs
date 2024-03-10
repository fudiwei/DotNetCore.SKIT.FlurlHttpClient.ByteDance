using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokV2ClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /oauth/token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/oauth-user-access-token-management ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/client-access-token-management ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthAccessTokenResponse> ExecuteOAuthAccessTokenAsync(this TikTokV2Client client, Models.OAuthAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret is null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "token/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/refresh_token/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/oauth-user-access-token-management ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRefreshTokenResponse> ExecuteOAuthRefreshTokenAsync(this TikTokV2Client client, Models.OAuthRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret is null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "refresh_token/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/revoke/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/login-kit-manage-user-access-tokens ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRevokeTokenResponse> ExecuteOAuthRevokeTokenAsync(this TikTokV2Client client, Models.OAuthRevokeTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            if (request.ClientSecret is null)
                request.ClientSecret = client.Credentials.ClientSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "revoke/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthRevokeTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /oauth/get_qrcode/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/login-kit-qr-code-authorization ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthGetQrcodeResponse> ExecuteOAuthGetQrcodeAsync(this TikTokV2Client client, Models.OAuthGetQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ClientKey is null)
                request.ClientKey = client.Credentials.ClientKey;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "get_qrcode/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthGetQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/check_qrcode/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/login-kit-qr-code-authorization ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthCheckQrcodeResponse> ExecuteOAuthCheckQrcodeAsync(this TikTokV2Client client, Models.OAuthCheckQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "check_qrcode/");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.OAuthCheckQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
