using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteOrdersExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /orders/search 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262815 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrdersSearchResponse> ExecuteOrdersSearchAsync(this TikTokShopClient client, Models.OrdersSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "orders", "search")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.OrdersSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /orders/detail/query 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262814 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrdersDetailQueryResponse> ExecuteOrdersDetailQueryAsync(this TikTokShopClient client, Models.OrdersDetailQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "orders", "detail", "query")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.OrdersDetailQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /orders/rts 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrdersReadyToShipResponse> ExecuteOrdersReadyToShipAsync(this TikTokShopClient client, Models.OrdersReadyToShipRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "orders", "rts")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.OrdersReadyToShipResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
