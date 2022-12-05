using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteIOPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /iop/roleGet 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/672 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPRoleGetResponse> ExecuteIOPRoleGetAsync(this DouyinShopClient client, Models.IOPRoleGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "roleGet")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPRoleGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/orderList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/673 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPOrderListResponse> ExecuteIOPOrderListAsync(this DouyinShopClient client, Models.IOPOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "orderList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/orderInfo 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/678 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPOrderInformationResponse> ExecuteIOPOrderInformationAsync(this DouyinShopClient client, Models.IOPOrderInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "orderInfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPOrderInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Seller
        /// <summary>
        /// <para>异步调用 [POST] /iop/sellerDistribute 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/958 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPSellerDistributeResponse> ExecuteIOPSellerDistributeAsync(this DouyinShopClient client, Models.IOPSellerDistributeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "sellerDistribute")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPSellerDistributeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/sellerCancleDistribute 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/958 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPSellerCancelDistributeResponse> ExecuteIOPSellerCancelDistributeAsync(this DouyinShopClient client, Models.IOPSellerCancelDistributeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "sellerCancleDistribute")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPSellerCancelDistributeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/sellerSupplierList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/958 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPSellerSupplierListResponse> ExecuteIOPSellerSupplierListAsync(this DouyinShopClient client, Models.IOPSellerSupplierListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "sellerSupplierList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPSellerSupplierListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/sellerOrderList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/960 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPSellerOrderListResponse> ExecuteIOPSellerOrderListAsync(this DouyinShopClient client, Models.IOPSellerOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "sellerOrderList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPSellerOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/sellerOrderInfo 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/959 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPSellerOrderInformationResponse> ExecuteIOPSellerOrderInformationAsync(this DouyinShopClient client, Models.IOPSellerOrderInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "sellerOrderInfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPSellerOrderInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Waybill
        /// <summary>
        /// <para>异步调用 [POST] /iop/waybillGet 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/674 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPWaybillGetResponse> ExecuteIOPWaybillGetAsync(this DouyinShopClient client, Models.IOPWaybillGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "waybillGet")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPWaybillGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/waybillCancel 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/675 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPWaybillCancelResponse> ExecuteIOPWaybillCancelAsync(this DouyinShopClient client, Models.IOPWaybillCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "waybillCancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPWaybillCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/waybillReturn 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/675 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPWaybillReturnResponse> ExecuteIOPWaybillReturnAsync(this DouyinShopClient client, Models.IOPWaybillReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "waybillReturn")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPWaybillReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /iop/waybillUpdate 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/59/677 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IOPWaybillUpdateResponse> ExecuteIOPWaybillUpdateAsync(this DouyinShopClient client, Models.IOPWaybillUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "iop", "waybillUpdate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IOPWaybillUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
