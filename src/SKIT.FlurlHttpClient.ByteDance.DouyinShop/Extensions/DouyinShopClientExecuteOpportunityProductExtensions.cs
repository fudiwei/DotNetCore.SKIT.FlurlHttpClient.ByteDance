using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteOpportunityProductExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /opptyProduct/apply 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/738 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpportunityProductApplyResponse> ExecuteOpportunityProductApplyAsync(this DouyinShopClient client, Models.OpportunityProductApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "opptyProduct", "apply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpportunityProductApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /opptyProduct/clue 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/739 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpportunityProductClueResponse> ExecuteOpportunityProductClueAsync(this DouyinShopClient client, Models.OpportunityProductClueRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "opptyProduct", "clue")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpportunityProductClueResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /opptyProduct/getApplyProgress 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/740 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpportunityProductGetApplyProgressResponse> ExecuteOpportunityProductGetApplyProgressAsync(this DouyinShopClient client, Models.OpportunityProductGetApplyProgressRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "opptyProduct", "getApplyProgress")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpportunityProductGetApplyProgressResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
