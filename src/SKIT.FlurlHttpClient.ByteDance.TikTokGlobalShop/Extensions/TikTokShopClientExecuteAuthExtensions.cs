using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /token/get 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/261250 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthTokenGetResponse> ExecuteAuthTokenGetAsync(this TikTokShopClient client, Models.AuthTokenGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "token", "get")
                .WithUrl($"{client.EndpointForAuthAPI}/token/get")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("app_secret", client.Credentials.AppSecret)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("auth_code", request.AuthorizedCode);

            return await client.SendRequestWithJsonAsync<Models.AuthTokenGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /token/refresh 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/261250 </para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262967 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthTokenRefreshResponse> ExecuteAuthTokenRefreshAsync(this TikTokShopClient client, Models.AuthTokenRefreshRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "token", "refresh")
                .WithUrl($"{client.EndpointForAuthAPI}/token/refresh")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("app_secret", client.Credentials.AppSecret)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("refresh_token", request.RefreshToken);

            return await client.SendRequestWithJsonAsync<Models.AuthTokenRefreshResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
