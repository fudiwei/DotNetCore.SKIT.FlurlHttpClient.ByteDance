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
        public static async Task<Models.ReverseOrderListResponse> ExecuteReverseOrderListAsync(this TikTokShopClient client, Models.ReverseOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "reverse_order", "list")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_request/confirm 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262871 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseRequestConfirmResponse> ExecuteReverseRequestConfirmAsync(this TikTokShopClient client, Models.ReverseRequestConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "reverse_request", "confirm")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseRequestConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_request/reject 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262869 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseRequestRejectResponse> ExecuteReverseRequestRejectAsync(this TikTokShopClient client, Models.ReverseRequestRejectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "reverse_request", "reject")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseRequestRejectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/order/cancel 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262872 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseOrderCancelResponse> ExecuteReverseOrderCancelAsync(this TikTokShopClient client, Models.ReverseOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "reverse", "order", "cancel")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ReverseOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /reverse/reverse_reason/list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262873 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseReasonListResponse> ExecuteReverseReasonListAsync(this TikTokShopClient client, Models.ReverseReasonListRequest request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.ReverseReasonListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
