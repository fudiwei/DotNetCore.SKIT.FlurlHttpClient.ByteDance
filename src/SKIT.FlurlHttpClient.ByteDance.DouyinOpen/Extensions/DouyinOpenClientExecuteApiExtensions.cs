using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteApiExtensions
    {
        #region Industry
        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/query_app_test_relation 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/test-relation-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApiIndustrySolutionQueryAppTestRelationV1Response> ExecuteApiIndustrySolutionQueryAppTestRelationV1Async(this DouyinOpenClient client, Models.ApiIndustrySolutionQueryAppTestRelationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "query_app_test_relation")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ApiIndustrySolutionQueryAppTestRelationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/add_app_test_relation 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/test-relation-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApiIndustrySolutionAddAppTestRelationV1Response> ExecuteApiIndustrySolutionAddAppTestRelationV1Async(this DouyinOpenClient client, Models.ApiIndustrySolutionAddAppTestRelationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "add_app_test_relation")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ApiIndustrySolutionAddAppTestRelationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/delete_app_test_relation 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/test-relation-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApiIndustrySolutionDeleteAppTestRelationV1Response> ExecuteApiIndustrySolutionDeleteAppTestRelationV1Async(this DouyinOpenClient client, Models.ApiIndustrySolutionDeleteAppTestRelationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "delete_app_test_relation")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ApiIndustrySolutionDeleteAppTestRelationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
