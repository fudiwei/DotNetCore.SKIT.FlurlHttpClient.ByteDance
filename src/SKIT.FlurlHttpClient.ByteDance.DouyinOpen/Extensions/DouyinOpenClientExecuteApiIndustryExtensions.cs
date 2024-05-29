using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteApiIndustryExtensions
    {
        #region AppTestRelation
        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/query_app_test_relation 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/test-relation-api ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IndustrySolutionQueryAppTestRelationV1Response> ExecuteIndustrySolutionQueryAppTestRelationV1Async(this DouyinOpenClient client, Models.IndustrySolutionQueryAppTestRelationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "query_app_test_relation")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.IndustrySolutionQueryAppTestRelationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/add_app_test_relation 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/test-relation-api ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IndustrySolutionAddAppTestRelationV1Response> ExecuteIndustrySolutionAddAppTestRelationV1Async(this DouyinOpenClient client, Models.IndustrySolutionAddAppTestRelationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "add_app_test_relation")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.IndustrySolutionAddAppTestRelationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/delete_app_test_relation 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/test-relation-api ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IndustrySolutionDeleteAppTestRelationV1Response> ExecuteIndustrySolutionDeleteAppTestRelationV1Async(this DouyinOpenClient client, Models.IndustrySolutionDeleteAppTestRelationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "delete_app_test_relation")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.IndustrySolutionDeleteAppTestRelationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region AppTestRelation
        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/set_impl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/open-capacity/Industry/industry_mode/solution#_4-1-%E9%85%8D%E7%BD%AE%E5%BC%80%E6%94%BE%E8%83%BD%E5%8A%9B%E5%AE%9E%E7%8E%B0%E6%8E%A5%E5%8F%A3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IndustrySolutionSetImplementationV1Response> ExecuteIndustrySolutionSetImplementationV1Async(this DouyinOpenClient client, Models.IndustrySolutionSetImplementationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "set_impl")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.IndustrySolutionSetImplementationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/industry/v1/solution/query_impl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/open-capacity/Industry/industry_mode/solution#_4-2-%E6%9F%A5%E8%AF%A2%E7%94%9F%E6%95%88%E4%B8%AD%E9%85%8D%E7%BD%AE%E6%8E%A5%E5%8F%A3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IndustrySolutionQueryImplementationV1Response> ExecuteIndustrySolutionQueryImplementationV1Async(this DouyinOpenClient client, Models.IndustrySolutionQueryImplementationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "industry", "v1", "solution", "query_impl")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.IndustrySolutionQueryImplementationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
