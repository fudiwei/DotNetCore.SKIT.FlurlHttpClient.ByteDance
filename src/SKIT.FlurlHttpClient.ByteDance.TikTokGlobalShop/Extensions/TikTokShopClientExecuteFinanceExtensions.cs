using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteFinanceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /finance/{version}/orders/{order_id}/statement_transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a6734defece02be67d724 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceGetOrderStatementTransactionsResponse> ExecuteFinanceGetOrderStatementTransactionsAsync(this TikTokShopClient client, Models.FinanceGetOrderStatementTransactionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "finance", request.ApiVersion, "orders", request.OrderId, "statement_transactions");

            return await client.SendFlurlRequesAsJsontAsync<Models.FinanceGetOrderStatementTransactionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /finance/{version}/statements/{statement_id}/statement_transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a6749defece02be67da87 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceGetStatementTransactionsResponse> ExecuteFinanceGetStatementTransactionsAsync(this TikTokShopClient client, Models.FinanceGetStatementTransactionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "finance", request.ApiVersion, "statements", request.StatementId, "statement_transactions")
                .SetQueryParam("sort_field", request.SortField)
                .SetQueryParam("sort_order", request.SortOrder)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FinanceGetStatementTransactionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /finance/{version}/statements 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a676f0fcef602bf2b91f0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceGetStatementsResponse> ExecuteFinanceGetStatementsAsync(this TikTokShopClient client, Models.FinanceGetStatementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "finance", request.ApiVersion, "statements")
                .SetQueryParam("statement_time_ge", request.SettlementTimestampGreaterThan)
                .SetQueryParam("statement_time_lt", request.SettlementTimestampLessThan)
                .SetQueryParam("payment_status", request.PaymentStatus)
                .SetQueryParam("sort_field", request.SortField)
                .SetQueryParam("sort_order", request.SortOrder)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FinanceGetStatementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /finance/{version}/payments 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a676f0fcef602bf2b91f0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceGetPaymentsResponse> ExecuteFinanceGetPaymentsAsync(this TikTokShopClient client, Models.FinanceGetPaymentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "finance", request.ApiVersion, "payments")
                .SetQueryParam("create_time_ge", request.CreateTimestampGreaterThan)
                .SetQueryParam("create_time_lt", request.CreateTimestampLessThan)
                .SetQueryParam("sort_field", request.SortField)
                .SetQueryParam("sort_order", request.SortOrder)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FinanceGetPaymentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /finance/{version}/withdrawals 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a675af1fd3102b925d283 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FinanceGetWithdrawalsResponse> ExecuteFinanceGetWithdrawalsAsync(this TikTokShopClient client, Models.FinanceGetWithdrawalsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "finance", request.ApiVersion, "withdrawals")
                .SetQueryParam("types", request.TypeList is null ? null : string.Join(",", request.TypeList))
                .SetQueryParam("create_time_ge", request.CreateTimestampGreaterThan)
                .SetQueryParam("create_time_lt", request.CreateTimestampLessThan)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FinanceGetWithdrawalsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
