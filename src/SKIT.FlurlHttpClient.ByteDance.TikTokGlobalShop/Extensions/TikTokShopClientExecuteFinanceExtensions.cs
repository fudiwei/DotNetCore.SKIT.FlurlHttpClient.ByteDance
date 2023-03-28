using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteFinanceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /finance/transactions/search 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262881 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceSearchTransactionsResponse> ExecuteFinanceSearchTransactionsAsync(this TikTokShopClient client, Models.FinanceSearchTransactionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "finance", "transactions", "search");

            return await client.SendRequestWithJsonAsync<Models.FinanceSearchTransactionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /finance/settlements/search 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262880 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceSearchSettlementsResponse> ExecuteFinanceSearchSettlementsAsync(this TikTokShopClient client, Models.FinanceSearchSettlementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "finance", "settlements", "search");

            return await client.SendRequestWithJsonAsync<Models.FinanceSearchSettlementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /finance/order/settlements 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262880 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceGetOrderSettlementListResponse> ExecuteFinanceGetOrderSettlementListAsync(this TikTokShopClient client, Models.FinanceGetOrderSettlementListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "finance", "order", "settlements")
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.FinanceGetOrderSettlementListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
