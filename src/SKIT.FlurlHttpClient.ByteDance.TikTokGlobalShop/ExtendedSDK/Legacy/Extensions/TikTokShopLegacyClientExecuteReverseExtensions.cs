using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyClientExecuteReverseExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_order/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262870 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseSearchReverseOrdersResponse> ExecuteReverseSearchReverseOrdersAsync(this TikTokShopLegacyClient client, Models.ReverseSearchReverseOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "reverse", "reverse_order", "list");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReverseSearchReverseOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_request/confirm 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262871 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseConfirmReverseRequestResponse> ExecuteReverseConfirmReverseRequestAsync(this TikTokShopLegacyClient client, Models.ReverseConfirmReverseRequestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "reverse", "reverse_request", "confirm");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReverseConfirmReverseRequestResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/reverse_request/reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262869 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseRejectReverseRequestResponse> ExecuteReverseRejectReverseRequestAsync(this TikTokShopLegacyClient client, Models.ReverseRejectReverseRequestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "reverse", "reverse_request", "reject");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReverseRejectReverseRequestResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /reverse/order/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262872 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseCancelOrderResponse> ExecuteReverseCancelOrderAsync(this TikTokShopLegacyClient client, Models.ReverseCancelOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "reverse", "order", "cancel");

            return await client.SendFlurlRequesAsJsontAsync<Models.ReverseCancelOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /reverse/reverse_reason/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262873 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseGetRejectReasonListResponse> ExecuteReverseGetRejectReasonListAsync(this TikTokShopLegacyClient client, Models.ReverseGetRejectReasonListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "reverse", "reverse_reason", "list");

            if (request.ActionType is not null)
                flurlReq.SetQueryParam("reverse_action_type", request.ActionType.Value);

            if (request.ReasonType is not null)
                flurlReq.SetQueryParam("reason_type", request.ReasonType.Value);

            if (request.FulfillmentStatus is not null)
                flurlReq.SetQueryParam("fulfillment_status", request.FulfillmentStatus.Value);

            return await client.SendFlurlRequesAsJsontAsync<Models.ReverseGetRejectReasonListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
