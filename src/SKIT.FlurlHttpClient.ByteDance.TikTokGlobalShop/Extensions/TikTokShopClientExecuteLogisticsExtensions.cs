using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteLogisticsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /logistics/get_warehouse_list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262859 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetWarehouseListResponse> ExecuteLogisticsGetWarehouseListAsync(this TikTokShopClient client, Models.LogisticsGetWarehouseListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "logistics", "get_warehouse_list");

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetWarehouseListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/get_subscribed_deliveryoptions 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262854 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetSubscribedDeliveryOptionsResponse> ExecuteLogisticsGetSubscribedDeliveryOptionsAsync(this TikTokShopClient client, Models.LogisticsGetSubscribedDeliveryOptionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "get_subscribed_deliveryoptions");

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetSubscribedDeliveryOptionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/shipping_providers 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262857 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetShippingProviderListResponse> ExecuteLogisticsGetShippingProviderListAsync(this TikTokShopClient client, Models.LogisticsGetShippingProviderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "logistics", "shipping_providers");

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetShippingProviderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/shipping_document 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262856 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetShippingDocumentResponse> ExecuteLogisticsGetShippingDocumentAsync(this TikTokShopClient client, Models.LogisticsGetShippingDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "logistics", "shipping_document")
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("document_type", request.DocumentType);

            if (request.DocumentSize != null)
                flurlReq.SetQueryParam("document_size", request.DocumentSize);

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetShippingDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/ship/get 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262858 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetShippingInfoResponse> ExecuteLogisticsGetShippingInfoAsync(this TikTokShopClient client, Models.LogisticsGetShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "logistics", "ship", "get")
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.LogisticsGetShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/tracking 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262855 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsUpdateShippingInfoResponse> ExecuteLogisticsUpdateShippingInfoAsync(this TikTokShopClient client, Models.LogisticsUpdateShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "logistics", "tracking")
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.LogisticsUpdateShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
