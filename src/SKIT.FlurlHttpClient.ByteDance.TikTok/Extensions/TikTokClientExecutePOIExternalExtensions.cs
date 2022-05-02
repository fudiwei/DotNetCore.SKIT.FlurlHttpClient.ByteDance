using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOIExternalExtensions
    {
        #region Hotel
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/commit 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/trade-system/place-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelOrderCommitResponse> ExecutePOIExternalHotelOrderCommitAsync(this TikTokClient client, Models.POIExternalHotelOrderCommitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "hotel", "order", "commit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelOrderCommitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/status 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/trade-system/payment-status-notice </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelOrderStatusResponse> ExecutePOIExternalHotelOrderStatusAsync(this TikTokClient client, Models.POIExternalHotelOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "hotel", "order", "status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelOrderStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/cancel 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/trade-system/cancel-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelOrderCancelResponse> ExecutePOIExternalHotelOrderCancelAsync(this TikTokClient client, Models.POIExternalHotelOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "hotel", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/ext/hotel/sku 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/goods-repo/sku-pull </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelSKUResponse> ExecutePOIExternalHotelSKUAsync(this TikTokClient client, Models.POIExternalHotelSKURequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "ext", "hotel", "sku")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("spu_ext_id", request.SPUExternalId)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelSKUResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region PresaleGroupon
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/create 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/trade-system/place-presell-ticket-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponOrderCreateResponse> ExecutePOIExternalPresaleGrouponOrderCreateAsync(this TikTokClient client, Models.POIExternalPresaleGrouponOrderCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponOrderCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/commit 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/trade-system/confirm-presell-ticket-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponOrderCommitResponse> ExecutePOIExternalPresaleGrouponOrderCommitAsync(this TikTokClient client, Models.POIExternalPresaleGrouponOrderCommitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "commit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponOrderCommitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/cancel 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/trade-system/cancel-presell-ticket-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponOrderCancelResponse> ExecutePOIExternalPresaleGrouponOrderCancelAsync(this TikTokClient client, Models.POIExternalPresaleGrouponOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
