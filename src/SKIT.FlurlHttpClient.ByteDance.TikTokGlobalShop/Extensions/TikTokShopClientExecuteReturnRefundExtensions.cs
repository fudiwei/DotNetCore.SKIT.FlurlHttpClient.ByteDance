using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteReturnRefundExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /return_refund/{version}/reject_reasons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab658defece02be706f98 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundGetRejectReasonsResponse> ExecuteReturnRefundGetRejectReasonsAsync(this TikTokShopClient client, Models.ReturnRefundGetRejectReasonsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "return_refund", request.ApiVersion, "reject_reasons");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundGetRejectReasonsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Cancellations
        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/cancellations 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aecb64a0bb702c076b03d ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundCreateCancellationResponse> ExecuteReturnRefundCreateCancellationAsync(this TikTokShopClient client, Models.ReturnRefundCreateCancellationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "cancellations");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundCreateCancellationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/cancellations/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab68bc16ffe02b8f2ea41 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundSearchCancellationsResponse> ExecuteReturnRefundSearchCancellationsAsync(this TikTokShopClient client, Models.ReturnRefundSearchCancellationsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "cancellations", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundSearchCancellationsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/cancellations/{cancel_id}/approve 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab6eff1fd3102b92e6a92 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundApproveCancellationResponse> ExecuteReturnRefundApproveCancellationAsync(this TikTokShopClient client, Models.ReturnRefundApproveCancellationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "cancellations", request.CancelId, "approve");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundApproveCancellationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/cancellations/{cancel_id}/reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab6df0fcef602bf34528f ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundRejectCancellationResponse> ExecuteReturnRefundRejectCancellationAsync(this TikTokShopClient client, Models.ReturnRefundRejectCancellationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "cancellations", request.CancelId, "reject");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundRejectCancellationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Orders
        /// <summary>
        /// <para>异步调用 [GET] /return_refund/{version}/orders/{order_id}/aftersale_eligibility 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab645c16ffe02b8f2e1c1 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundGetOrderAftersaleEligibilityResponse> ExecuteReturnRefundGetOrderAftersaleEligibilityAsync(this TikTokShopClient client, Models.ReturnRefundGetOrderAftersaleEligibilityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "return_refund", request.ApiVersion, "orders", request.OrderId, "aftersale_eligibility");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundGetOrderAftersaleEligibilityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Refunds
        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/refunds/calculate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab630defece02be706871 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundCalculateRefundResponse> ExecuteReturnRefundCalculateRefundAsync(this TikTokShopClient client, Models.ReturnRefundCalculateRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "refunds", "calculate");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundCalculateRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Returns
        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/returns 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ae5fc4a0bb702c075d05d ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundCreateReturnResponse> ExecuteReturnRefundCreateReturnAsync(this TikTokShopClient client, Models.ReturnRefundCreateReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "returns");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundCreateReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/returns/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab69edefece02be70785b ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundSearchReturnsResponse> ExecuteReturnRefundSearchReturnsAsync(this TikTokShopClient client, Models.ReturnRefundSearchReturnsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "returns", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundSearchReturnsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/returns/{return_id}/approve 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab6c2c16ffe02b8f2efcf ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundApproveReturnResponse> ExecuteReturnRefundApproveReturnAsync(this TikTokShopClient client, Models.ReturnRefundApproveReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "returns", request.ReturnId, "approve");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundApproveReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /return_refund/{version}/returns/{return_id}/reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab6d14a0bb702c06faec4 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundRejectReturnResponse> ExecuteReturnRefundRejectReturnAsync(this TikTokShopClient client, Models.ReturnRefundRejectReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "return_refund", request.ApiVersion, "returns", request.ReturnId, "reject");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundRejectReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /return_refund/{version}/returns/{return_id}/records 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab676f1fd3102b92e6027 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnRefundGetReturnRecordsResponse> ExecuteReturnRefundGetReturnRecordsAsync(this TikTokShopClient client, Models.ReturnRefundGetReturnRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "return_refund", request.ApiVersion, "returns", request.ReturnId, "records");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReturnRefundGetReturnRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
