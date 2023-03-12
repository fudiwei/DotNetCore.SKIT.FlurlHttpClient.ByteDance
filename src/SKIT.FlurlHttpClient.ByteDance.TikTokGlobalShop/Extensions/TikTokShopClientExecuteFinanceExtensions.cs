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
        public static async Task<Models.FinanceTransactionsSearchResponse> ExecuteFinanceTransactionsSearchAsync(this TikTokShopClient client, Models.FinanceTransactionsSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "finance", "transactions", "search")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.FinanceTransactionsSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /finance/settlements/search 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262880 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceSettlementsSearchResponse> ExecuteFinanceSettlementsSearchAsync(this TikTokShopClient client, Models.FinanceSettlementsSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "finance", "settlements", "search")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.FinanceSettlementsSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /finance/order/settlements 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262880 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceOrderSettlementsResponse> ExecuteFinanceOrderSettlementsAsync(this TikTokShopClient client, Models.FinanceOrderSettlementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "finance", "order", "settlements")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId)
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.FinanceOrderSettlementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
