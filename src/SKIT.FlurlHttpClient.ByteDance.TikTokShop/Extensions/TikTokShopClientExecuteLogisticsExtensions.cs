using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteLogisticsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /logistics/getOutRange 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/327 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetOutRangeResponse> ExecuteLogisticsGetOutRangeAsync(this TikTokShopClient client, Models.LogisticsGetOutRangeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "getOutRange")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetOutRangeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/trackNoRouteDetail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/784 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsTrackNoRouteDetailResponse> ExecuteLogisticsTrackNoRouteDetailAsync(this TikTokShopClient client, Models.LogisticsTrackNoRouteDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "trackNoRouteDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.LogisticsTrackNoRouteDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/getCustomTemplateList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/784 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetCustomTemplateListResponse> ExecuteLogisticsGetCustomTemplateListAsync(this TikTokShopClient client, Models.LogisticsGetCustomTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "getCustomTemplateList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetCustomTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/updateOrder 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/784 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsUpdateOrderResponse> ExecuteLogisticsUpdateOrderAsync(this TikTokShopClient client, Models.LogisticsUpdateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "updateOrder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.LogisticsUpdateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/cancelOrder 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/397 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsCancelOrderResponse> ExecuteLogisticsCancelOrderAsync(this TikTokShopClient client, Models.LogisticsCancelOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "cancelOrder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.LogisticsCancelOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/listShopNetsite 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/576 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsListShopNetSiteResponse> ExecuteLogisticsListShopNetSiteAsync(this TikTokShopClient client, Models.LogisticsListShopNetSiteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "listShopNetsite")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.LogisticsListShopNetsiteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
