using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteOAuth2Extensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /oauth2/access_token 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710505596940 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuth2AccessTokenResponse> ExecuteOAuth2AccessTokenAsync(this OceanEngineClient client, Models.OAuth2AccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret == null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth2", "access_token");

            return await client.SendRequestWithJsonAsync<Models.OAuth2AccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth2/refresh_token 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710506097679 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuth2RefreshTokenResponse> ExecuteOAuth2RefreshTokenAsync(this OceanEngineClient client, Models.OAuth2RefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret == null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth2", "refresh_token");

            return await client.SendRequestWithJsonAsync<Models.OAuth2RefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /oauth2/advertiser/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710506574848 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuth2AdvertiserGetResponse> ExecuteOAuth2AdvertiserGetAsync(this OceanEngineClient client, Models.OAuth2AdvertiserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret == null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "oauth2", "advertiser", "get");

            return await client.SendRequestWithJsonAsync<Models.OAuth2AdvertiserGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /oauth2/app_access_token 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1713655428885516 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuth2AppAccessTokenResponse> ExecuteOAuth2AppAccessTokenAsync(this OceanEngineClient client, Models.OAuth2AppAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret == null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "oauth2", "app_access_token");

            return await client.SendRequestWithJsonAsync<Models.OAuth2AppAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
