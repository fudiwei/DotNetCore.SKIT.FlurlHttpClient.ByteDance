using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /order/{version}/orders/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa8094a0bb702c06df242 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderSearchOrdersResponse> ExecuteOrderSearchOrdersAsync(this TikTokShopClient client, Models.OrderSearchOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "order", request.ApiVersion, "orders", "search")
                .SetQueryParam("sort_field", request.SortField)
                .SetQueryParam("sort_order", request.SortOrder)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderSearchOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /order/{version}/orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa8ccc16ffe02b8f167a0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderBatchGetOrderDetailResponse> ExecuteOrderBatchGetOrderDetailAsync(this TikTokShopClient client, Models.OrderBatchGetOrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "order", request.ApiVersion, "orders")
                .SetQueryParam("ids", request.OrderIdList);

            return await client.SendFlurlRequesAsJsontAsync<Models.OrderBatchGetOrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
