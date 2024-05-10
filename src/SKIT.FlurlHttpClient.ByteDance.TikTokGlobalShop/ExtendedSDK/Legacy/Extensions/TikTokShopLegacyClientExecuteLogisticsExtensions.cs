using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyClientExecuteLogisticsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /logistics/get_warehouse_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262859 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetWarehouseListResponse> ExecuteLogisticsGetWarehouseListAsync(this TikTokShopLegacyClient client, Models.LogisticsGetWarehouseListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", "get_warehouse_list");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetWarehouseListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/get_subscribed_deliveryoptions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262854 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetSubscribedDeliveryOptionsResponse> ExecuteLogisticsGetSubscribedDeliveryOptionsAsync(this TikTokShopLegacyClient client, Models.LogisticsGetSubscribedDeliveryOptionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "logistics", "get_subscribed_deliveryoptions");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetSubscribedDeliveryOptionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/shipping_providers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262857 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetShippingProviderListResponse> ExecuteLogisticsGetShippingProviderListAsync(this TikTokShopLegacyClient client, Models.LogisticsGetShippingProviderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", "shipping_providers");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetShippingProviderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/shipping_document 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262856 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetShippingDocumentResponse> ExecuteLogisticsGetShippingDocumentAsync(this TikTokShopLegacyClient client, Models.LogisticsGetShippingDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", "shipping_document")
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("document_type", request.DocumentType);

            if (request.DocumentSize is not null)
                flurlReq.SetQueryParam("document_size", request.DocumentSize);

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetShippingDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/ship/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262858 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetShippingInfoResponse> ExecuteLogisticsGetShippingInfoAsync(this TikTokShopLegacyClient client, Models.LogisticsGetShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", "ship", "get")
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /logistics/tracking 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262855 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsUpdateShippingInfoResponse> ExecuteLogisticsUpdateShippingInfoAsync(this TikTokShopLegacyClient client, Models.LogisticsUpdateShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "logistics", "tracking")
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsUpdateShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
