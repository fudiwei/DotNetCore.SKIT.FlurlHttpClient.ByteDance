using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteTokenExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /token/create 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/guide-docs/9/21 </para>
        /// <para>REF: https://op.jinritemai.com/docs/guide-docs/9/22 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TokenCreateResponse> ExecuteTokenCreateAsync(this TikTokShopClient client, Models.TokenCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "token", "create")
                .SetQueryParam("app_key", client.Credentials.AppKey);

            return await client.SendRequestWithJsonAsync<Models.TokenCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /token/refresh 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/guide-docs/9/21 </para>
        /// <para>REF: https://op.jinritemai.com/docs/guide-docs/9/22 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TokenRefreshResponse> ExecuteTokenRefreshAsync(this TikTokShopClient client, Models.TokenRefreshRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "token", "refresh")
                .SetQueryParam("app_key", client.Credentials.AppKey);

            return await client.SendRequestWithJsonAsync<Models.TokenRefreshResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
