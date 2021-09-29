using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteBuyinExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /buyin/simplePlan 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/61/923 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BuyinSimplePlanResponse> ExecuteBuyinSimplePlanAsync(this TikTokShopClient client, Models.BuyinSimplePlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "buyin", "simplePlan")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BuyinSimplePlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /buyin/exclusivePlan 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/61/922 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BuyinExclusivePlanResponse> ExecuteBuyinExclusivePlanAsync(this TikTokShopClient client, Models.BuyinExclusivePlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "buyin", "exclusivePlan")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BuyinExclusivePlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /buyin/applyActivities 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/61/744 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BuyinApplyActivitiesResponse> ExecuteBuyinApplyActivitiesAsync(this TikTokShopClient client, Models.BuyinApplyActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "buyin", "applyActivities")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BuyinApplyActivitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /buyin/activitySearch 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/61/743 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BuyinActivitySearchResponse> ExecuteBuyinActivitySearchAsync(this TikTokShopClient client, Models.BuyinActivitySearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "buyin", "activitySearch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BuyinActivitySearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
