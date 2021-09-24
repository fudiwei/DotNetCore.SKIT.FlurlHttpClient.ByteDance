using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteBTASExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /btas/listBrand 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/49/575 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BTASListBrandResponse> ExecuteBTASListBrandAsync(this TikTokShopClient client, Models.BTASListBrandRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "btas", "listBrand")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BTASListBrandResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /btas/shipping 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/49/489 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BTASShippingResponse> ExecuteBTASShippingAsync(this TikTokShopClient client, Models.BTASShippingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "btas", "shipping")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BTASShippingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /btas/getInspectionOrder 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/49/473 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BTASGetInspectionOrderResponse> ExecuteBTASGetInspectionOrderAsync(this TikTokShopClient client, Models.BTASGetInspectionOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "btas", "getInspectionOrder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BTASGetInspectionOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /btas/saveInspectionOnline 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/49/572 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BTASSaveInspectionOnlineResponse> ExecuteBTASSaveInspectionOnlineAsync(this TikTokShopClient client, Models.BTASSaveInspectionOnlineRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "btas", "saveInspectionOnline")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BTASSaveInspectionOnlineResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /btas/getOrderInspectionResult 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/49/573 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BTASGetOrderInspectionResultResponse> ExecuteBTASGetOrderInspectionResultAsync(this TikTokShopClient client, Models.BTASGetOrderInspectionResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "btas", "getOrderInspectionResult")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BTASGetOrderInspectionResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /btas/saveInspectionInfo 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/49/574 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BTASSaveInspectionInformationResponse> ExecuteBTASSaveInspectionInformationAsync(this TikTokShopClient client, Models.BTASSaveInspectionInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "btas", "saveInspectionInfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BTASSaveInspectionInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
