using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteRecycleExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /recycle/buyerGetOrderList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/914 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleBuyerGetOrderListResponse> ExecuteRecycleBuyerGetOrderListAsync(this TikTokShopClient client, Models.RecycleBuyerGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "buyerGetOrderList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleBuyerGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/buyerGetOrderDetail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/914 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleBuyerGetOrderDetailResponse> ExecuteRecycleBuyerGetOrderDetailAsync(this TikTokShopClient client, Models.RecycleBuyerGetOrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "buyerGetOrderDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleBuyerGetOrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/createPrice 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/904 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleCreatePriceResponse> ExecuteRecycleCreatePriceAsync(this TikTokShopClient client, Models.RecycleCreatePriceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "createPrice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleCreatePriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/changePrice 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/908 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleChangePriceResponse> ExecuteRecycleChangePriceAsync(this TikTokShopClient client, Models.RecycleChangePriceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "changePrice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleChangePriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/qualityTestingResult 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/907 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleQualityTestingResultResponse> ExecuteRecycleQualityTestingResultAsync(this TikTokShopClient client, Models.RecycleQualityTestingResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "qualityTestingResult")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleQualityTestingResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/applyChangePrice 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/909 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleApplyChangePriceResponse> ExecuteRecycleApplyChangePriceAsync(this TikTokShopClient client, Models.RecycleApplyChangePriceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "applyChangePrice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleApplyChangePriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/confirmReceive 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/906 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleConfirmReceiveResponse> ExecuteRecycleConfirmReceiveAsync(this TikTokShopClient client, Models.RecycleConfirmReceiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "confirmReceive")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleConfirmReceiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/sellSucceed 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/910 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleSellSucceedResponse> ExecuteRecycleSellSucceedAsync(this TikTokShopClient client, Models.RecycleSellSucceedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "sellSucceed")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleSellSucceedResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /recycle/logisticsBack 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/68/911 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RecycleLogisticsBackResponse> ExecuteRecycleLogisticsBackAsync(this TikTokShopClient client, Models.RecycleLogisticsBackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "recycle", "logisticsBack")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RecycleLogisticsBackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
