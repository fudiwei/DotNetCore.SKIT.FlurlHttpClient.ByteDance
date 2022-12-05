using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteCrossBorderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/queryBalance 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/662 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderQueryBalanceResponse> ExecuteCrossBorderQueryBalanceAsync(this DouyinShopClient client, Models.CrossBorderQueryBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "queryBalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderQueryBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/bankAccountVerify 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/664 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderBankAccountVerifyResponse> ExecuteCrossBorderBankAccountVerifyAsync(this DouyinShopClient client, Models.CrossBorderBankAccountVerifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "bankAccountVerify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderBankAccountVerifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/stockTaking 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderStockTakingResponse> ExecuteCrossBorderStockTakingAsync(this DouyinShopClient client, Models.CrossBorderStockTakingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "stockTaking")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderStockTakingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/stockTransform 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/918 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderStockTransformResponse> ExecuteCrossBorderStockTransformAsync(this DouyinShopClient client, Models.CrossBorderStockTransformRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "stockTransform")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderStockTransformResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/warehouseInOutboundEvent 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/919 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderWarehouseInOutboundEventResponse> ExecuteCrossBorderWarehouseInOutboundEventAsync(this DouyinShopClient client, Models.CrossBorderWarehouseInOutboundEventRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "warehouseInOutboundEvent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderWarehouseInOutboundEventResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/OrderInterception 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/920 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderOrderInterceptionResponse> ExecuteCrossBorderOrderInterceptionAsync(this DouyinShopClient client, Models.CrossBorderOrderInterceptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "OrderInterception")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderOrderInterceptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /crossBorder/orderList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/496 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CrossBorderOrderListResponse> ExecuteCrossBorderOrderListAsync(this DouyinShopClient client, Models.CrossBorderOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "crossBorder", "orderList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CrossBorderOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
