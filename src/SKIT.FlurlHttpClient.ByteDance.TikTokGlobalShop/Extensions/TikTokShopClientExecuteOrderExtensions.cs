using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /order/{version}/orders/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa8094a0bb702c06df242 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderSearchOrdersResponse> ExecuteOrderSearchOrdersAsync(this TikTokShopClient client, Models.OrderSearchOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "order", request.ApiVersion, "orders", "search")
                .SetQueryParam("sort_field", request.SortField)
                .SetQueryParam("sort_order", request.SortOrder)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderSearchOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /order/{version}/orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa8ccc16ffe02b8f167a0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderBatchGetOrderDetailResponse> ExecuteOrderBatchGetOrderDetailAsync(this TikTokShopClient client, Models.OrderBatchGetOrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "order", request.ApiVersion, "orders")
                .SetQueryParam("ids", request.OrderIdList);

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderBatchGetOrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /order/{version}/orders/{order_id}/price_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/66ce16cadefa5102ffda9c6b ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderGetOrderPriceDetailResponse> ExecuteOrderGetOrderPriceDetailAsync(this TikTokShopClient client, Models.OrderGetOrderPriceDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "order", request.ApiVersion, "orders", request.OrderId, "price_detail");

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderGetOrderPriceDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ExternalOrder
        /// <summary>
        /// <para>异步调用 [POST] /order/{version}/orders/external_orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/668cf073a6a5e002e69d4a28 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderCreateExternalOrderResponse> ExecuteOrderCreateExternalOrderAsync(this TikTokShopClient client, Models.OrderCreateExternalOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "order", request.ApiVersion, "orders", "external_orders");

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderCreateExternalOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /order/{version}/orders/{order_id}/external_orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/668cf073115ebe02f8050b0a ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderGetExternalOrdersResponse> ExecuteOrderGetExternalOrdersAsync(this TikTokShopClient client, Models.OrderGetExternalOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "order", request.ApiVersion, "orders", request.OrderId, "external_orders")
                .SetQueryParam("platform", request.Platform);

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderGetExternalOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/{version}/orders/external_order_search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/668cf073737c3702ef051a27 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderSearchExternalOrdersResponse> ExecuteOrderSearchExternalOrdersAsync(this TikTokShopClient client, Models.OrderSearchExternalOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "order", request.ApiVersion, "orders", "external_order_search")
                .SetQueryParam("external_order_id", request.ExternalOrderId)
                .SetQueryParam("platform", request.Platform);

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderSearchExternalOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
