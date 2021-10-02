using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteYuncExtensions
    {
        #region WMS
        /// <summary>
        /// <para>异步调用 [POST] /yunc/pushOutboundFeedback 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/842 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncPushOutboundFeedbackResponse> ExecuteYuncPushOutboundFeedbackAsync(this TikTokShopClient client, Models.YuncPushOutboundFeedbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "pushOutboundFeedback")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncPushOutboundFeedbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/adjustInventory 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/930 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncAdjustInventoryResponse> ExecuteYuncAdjustInventoryAsync(this TikTokShopClient client, Models.YuncAdjustInventoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "adjustInventory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncAdjustInventoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/wmsInboundCallback 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/929 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncWMSInboundCallbackResponse> ExecuteYuncWMSInboundCallbackAsync(this TikTokShopClient client, Models.YuncWMSInboundCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "wmsInboundCallback")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncWMSInboundCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ERP
        /// <summary>
        /// <para>异步调用 [POST] /yunc/shopWarehouseRefQuery 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/839 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncShopWarehouseRefQueryResponse> ExecuteYuncShopWarehouseRefQueryAsync(this TikTokShopClient client, Models.YuncShopWarehouseRefQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "shopWarehouseRefQuery")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncShopWarehouseRefQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/erpCargoSinglePush 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/890 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncERPCargoSinglePushResponse> ExecuteYuncERPCargoSinglePushAsync(this TikTokShopClient client, Models.YuncERPCargoSinglePushRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "erpCargoSinglePush")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncERPCargoSinglePushResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/createOutboundOrderToB 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/868 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncCreateOutboundOrderToBusinessResponse> ExecuteYuncCreateOutboundOrderToBusinessAsync(this TikTokShopClient client, Models.YuncCreateOutboundOrderToBusinessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "createOutboundOrderToB")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncCreateOutboundOrderToBusinessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/cancelOutboundOrderToB 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/745 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncCancelOutboundOrderToBusinessResponse> ExecuteYuncCancelOutboundOrderToBusinessAsync(this TikTokShopClient client, Models.YuncCancelOutboundOrderToBusinessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "cancelOutboundOrderToB")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncCancelOutboundOrderToBusinessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/erpInboundCreate 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/899 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncERPInboundCreateResponse> ExecuteYuncERPInboundCreateAsync(this TikTokShopClient client, Models.YuncERPInboundCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "erpInboundCreate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncERPInboundCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/erpInboundCancel 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/928 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncERPInboundCancelResponse> ExecuteYuncERPInboundCancelAsync(this TikTokShopClient client, Models.YuncERPInboundCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "erpInboundCancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncERPInboundCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
