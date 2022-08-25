using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteMarketServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /market/service/user/purchase/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/service-market/service-relationship/purchase-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MarketServiceUserPurchaseListResponse> ExecuteMarketServiceUserPurchaseListAsync(this TikTokClient client, Models.MarketServiceUserPurchaseListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "market", "service", "user", "purchase", "list")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("is_test_env", request.IsTestEnvironment);

            return await client.SendRequestWithJsonAsync<Models.MarketServiceUserPurchaseListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /market/service/user/remaintimes/decr 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/service-market/service-relationship/remaintimes-decr </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MarketServiceUserRemainTimesDecreaseResponse> ExecuteMarketServiceUserRemainTimesDecreaseAsync(this TikTokClient client, Models.MarketServiceUserRemainTimesDecreaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "market", "service", "user", "remaintimes", "decr")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MarketServiceUserRemainTimesDecreaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /market/service/user/insert/purchase/info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/service-market/service-relationship/insert-purchase-info </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MarketServiceUserInsertPurchaseInfoResponse> ExecuteMarketServiceUserInsertPurchaseInfoAsync(this TikTokClient client, Models.MarketServiceUserInsertPurchaseInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "market", "service", "user", "insert", "purchase", "info")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MarketServiceUserInsertPurchaseInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /market/service/user/delete/purchase/info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/service-market/service-relationship/delete-purchase-info </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MarketServiceUserDeletePurchaseInfoResponse> ExecuteMarketServiceUserDeletePurchaseInfoAsync(this TikTokClient client, Models.MarketServiceUserDeletePurchaseInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "market", "service", "user", "delete", "purchase", "info")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MarketServiceUserDeletePurchaseInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
