using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteReverseExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_order/list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262870 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseSearchReverseOrdersResponse> ExecuteReverseSearchReverseOrdersAsync(this TikTokShopClient client, Models.ReverseSearchReverseOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "reverse_order", "list")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseSearchReverseOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_request/confirm 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262871 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseConfirmReverseRequestResponse> ExecuteReverseConfirmReverseRequestAsync(this TikTokShopClient client, Models.ReverseConfirmReverseRequestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "reverse_request", "confirm")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseConfirmReverseRequestResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_request/reject 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262869 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseRejectReverseRequestResponse> ExecuteReverseRejectReverseRequestAsync(this TikTokShopClient client, Models.ReverseRejectReverseRequestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "reverse_request", "reject")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseRejectReverseRequestResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/order/cancel 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262872 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseCancelOrderResponse> ExecuteReverseCancelOrderAsync(this TikTokShopClient client, Models.ReverseCancelOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "order", "cancel")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseCancelOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /reverse/reverse_reason/list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262873 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseGetRejectReasonListResponse> ExecuteReverseGetRejectReasonListAsync(this TikTokShopClient client, Models.ReverseGetRejectReasonListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "reverse", "reverse_reason", "list")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            if (request.ActionType != null)
                flurlReq.SetQueryParam("reverse_action_type", request.ActionType.Value);

            if (request.ReasonType != null)
                flurlReq.SetQueryParam("reason_type", request.ReasonType.Value);

            if (request.FulfillmentStatus != null)
                flurlReq.SetQueryParam("fulfillment_status", request.FulfillmentStatus.Value);

            return await client.SendRequestWithJsonAsync<Models.ReverseGetRejectReasonListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
