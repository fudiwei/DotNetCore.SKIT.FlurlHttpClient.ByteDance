using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /platform/oauth/connect 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848834666171009035 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformOAuthConnectResponse> ExecutePlatformOAuthConnectAsync(this TikTokClient client, Models.PlatformOAuthConnectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "platform", "oauth", "connect")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", request.ResponseType)
                .SetQueryParam("scope", request.Scope)
                .SetQueryParam("redirect_uri", request.RedirectUrl);

            if (request.OptionalScope != null)
                flurlReq.SetQueryParam("optionalScope", request.OptionalScope);

            if (request.State != null)
                flurlReq.SetQueryParam("state", request.State);

            return await client.SendRequestWithJsonAsync<Models.PlatformOAuthConnectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /oauth/authorize 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848834851366275076 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthAuthorizeResponse> ExecuteOAuthAuthorizeAsync(this TikTokClient client, Models.OAuthAuthorizeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "oauth", "authorize")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", request.ResponseType)
                .SetQueryParam("scope", request.Scope)
                .SetQueryParam("redirect_uri", request.RedirectUrl);

            if (request.State != null)
                flurlReq.SetQueryParam("state", request.State);

            return await client.SendRequestWithJsonAsync<Models.OAuthAuthorizeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /oauth/authorize/v2 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848834666170959883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthAuthorizeV2Response> ExecuteOAuthAuthorizeV2Async(this TikTokClient client, Models.OAuthAuthorizeV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "oauth", "authorize", "v2")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", request.ResponseType)
                .SetQueryParam("scope", request.Scope)
                .SetQueryParam("redirect_uri", request.RedirectUrl);

            if (request.State != null)
                flurlReq.SetQueryParam("state", request.State);

            return await client.SendRequestWithJsonAsync<Models.OAuthAuthorizeV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/access_token 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806493387606024 </para>
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
                .CreateRequest(request, HttpMethod.Post, "oauth", "access_token");

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(client.Credentials.ClientKey, Encoding.UTF8), "client_key");
            httpContent.Add(new StringContent(client.Credentials.ClientSecret, Encoding.UTF8), "client_secret");
            httpContent.Add(new StringContent(request.Code, Encoding.UTF8), "code");
            httpContent.Add(new StringContent(request.GrantType, Encoding.UTF8), "grant_type");

            return await client.SendRequestAsync<Models.OAuthAccessTokenResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/renew_refresh_token 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806519174154248 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthRenewRefreshTokenResponse> ExecuteOAuthRenewRefreshTokenAsync(this TikTokClient client, Models.OAuthRenewRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "renew_refresh_token");

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(client.Credentials.ClientKey, Encoding.UTF8), "client_key");
            httpContent.Add(new StringContent(request.RefreshToken, Encoding.UTF8), "refresh_token");

            return await client.SendRequestAsync<Models.OAuthRenewRefreshTokenResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/client_token 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806493387573256 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthClientTokenResponse> ExecuteOAuthClientTokenAsync(this TikTokClient client, Models.OAuthClientTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth", "client_token");

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(client.Credentials.ClientKey, Encoding.UTF8), "client_key");
            httpContent.Add(new StringContent(client.Credentials.ClientSecret, Encoding.UTF8), "client_secret");
            httpContent.Add(new StringContent(request.GrantType, Encoding.UTF8), "grant_type");

            return await client.SendRequestAsync<Models.OAuthClientTokenResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth/refresh_token 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806497707722765 </para>
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
                .CreateRequest(request, HttpMethod.Post, "oauth", "refresh_token");

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(client.Credentials.ClientKey, Encoding.UTF8), "client_key");
            httpContent.Add(new StringContent(client.Credentials.ClientSecret, Encoding.UTF8), "client_secret");
            httpContent.Add(new StringContent(request.RefreshToken, Encoding.UTF8), "refresh_token");

            return await client.SendRequestAsync<Models.OAuthRefreshTokenResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        #region User
        /// <summary>
        /// <para>异步调用 [GET] /oauth/userinfo 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806527751489550 </para>
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
