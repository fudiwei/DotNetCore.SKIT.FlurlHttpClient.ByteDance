using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteAftersaleExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /afterSale/timeExtend 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/242 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleTimeExtendResponse> ExecuteAftersaleTimeExtendAsync(this DouyinShopClient client, Models.AftersaleTimeExtendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "timeExtend")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleTimeExtendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/buyerExchange 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/241 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleBuyerExchangeResponse> ExecuteAftersaleBuyerExchangeAsync(this DouyinShopClient client, Models.AftersaleBuyerExchangeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "buyerExchange")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleBuyerExchangeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/addOrderRemark 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/585 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleAddOrderRemarkResponse> ExecuteAftersaleAddOrderRemarkAsync(this DouyinShopClient client, Models.AftersaleAddOrderRemarkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "addOrderRemark")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleAddOrderRemarkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/submitEvidence 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/255 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleSubmitEvidenceResponse> ExecuteAftersaleSubmitEvidenceAsync(this DouyinShopClient client, Models.AftersaleSubmitEvidenceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "submitEvidence")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleSubmitEvidenceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/OpenAfterSaleChannel 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/764 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleOpenAfterSaleChannelResponse> ExecuteAftersaleOpenAfterSaleChannelAsync(this DouyinShopClient client, Models.AftersaleOpenAfterSaleChannelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "OpenAfterSaleChannel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleOpenAfterSaleChannelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/buyerExchangeConfirm 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/768 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleBuyerExchangeConfirmResponse> ExecuteAftersaleBuyerExchangeConfirmAsync(this DouyinShopClient client, Models.AftersaleBuyerExchangeConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "buyerExchangeConfirm")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleBuyerExchangeConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/CancelSendGoodsSuccess 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/816 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleCancelSendGoodsSuccessResponse> ExecuteAftersaleCancelSendGoodsSuccessAsync(this DouyinShopClient client, Models.AftersaleCancelSendGoodsSuccessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "CancelSendGoodsSuccess")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleCancelSendGoodsSuccessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/returnGoodsToWareHouseSuccess 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/815 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleReturnGoodsToWareHouseSuccessResponse> ExecuteAftersaleReturnGoodsToWareHouseSuccessAsync(this DouyinShopClient client, Models.AftersaleReturnGoodsToWareHouseSuccessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "returnGoodsToWareHouseSuccess")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleReturnGoodsToWareHouseSuccessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/Operate 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/560 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleOperateResponse> ExecuteAftersaleOperateAsync(this DouyinShopClient client, Models.AftersaleOperateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "Operate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleOperateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/applyLogisticsIntercept 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/897 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleApplyLogisticsInterceptResponse> ExecuteAftersaleApplyLogisticsInterceptAsync(this DouyinShopClient client, Models.AftersaleApplyLogisticsInterceptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "applyLogisticsIntercept")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleApplyLogisticsInterceptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/refundListSearch 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/254 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleRefundListSearchResponse> ExecuteAftersaleRefundListSearchAsync(this DouyinShopClient client, Models.AftersaleRefundListSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "refundListSearch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleRefundListSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/List 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/254 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleListResponse> ExecuteAftersaleListAsync(this DouyinShopClient client, Models.AftersaleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "List")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /afterSale/Detail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/17/1095 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AftersaleDetailResponse> ExecuteAftersaleDetailAsync(this DouyinShopClient client, Models.AftersaleDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "afterSale", "Detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AftersaleDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
