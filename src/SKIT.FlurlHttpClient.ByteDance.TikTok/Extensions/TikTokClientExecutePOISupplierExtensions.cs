using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOISupplierExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /poi/supplier/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798600688961547 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierSyncResponse> ExecutePOISupplierSyncAsync(this TikTokClient client, Models.POISupplierSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "supplier", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISupplierSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/supplier/query 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798600688928779 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQueryResponse> ExecutePOISupplierQueryAsync(this TikTokClient client, Models.POISupplierQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "supplier", "query")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("supplier_ext_id", request.SupplierExternalId);

            return await client.SendRequestWithJsonAsync<Models.POISupplierQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/supplier/query_all 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/7005578946813184030 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQueryAllResponse> ExecutePOISupplierQueryAllAsync(this TikTokClient client, Models.POISupplierQueryAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "supplier", "query_all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISupplierQueryAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/supplier/query_callback 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/7005579747056977928 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQueryCallbackResponse> ExecutePOISupplierQueryCallbackAsync(this TikTokClient client, Models.POISupplierQueryCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "supplier", "query_callback")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("task_id", request.TaskId);

            return await client.SendRequestWithJsonAsync<Models.POISupplierQueryCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/v2/supplier/query/task 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6948301678441482243 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQueryTaskResponse> ExecutePOISupplierQueryTaskAsync(this TikTokClient client, Models.POISupplierQueryTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "v2", "supplier", "query", "task")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("supplier_task_ids", string.Join(",", request.SupplierTaskIdList));

            return await client.SendRequestWithJsonAsync<Models.POISupplierQueryTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/v2/supplier/query/supplier 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6948302162829101059 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQuerySupplierResponse> ExecutePOISupplierQuerySupplierAsync(this TikTokClient client, Models.POISupplierQuerySupplierRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "v2", "supplier", "query", "supplier")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("supplier_ext_id", string.Join(",", request.SupplierExternalIdList));

            return await client.SendRequestWithJsonAsync<Models.POISupplierQuerySupplierResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/supplier/match 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6948299842175141926 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierMatchResponse> ExecutePOISupplierMatchAsync(this TikTokClient client, Models.POISupplierMatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "supplier", "match")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISupplierMatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
