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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/synchronism </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/search </para>
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
                .SetQueryParam("supplier_ext_id", request.ExternalSupplierId);

            return await client.SendRequestWithJsonAsync<Models.POISupplierQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/supplier/query_all 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/query-all-shop-info </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/query-shop-all-tasks </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/task-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQueryTaskV2Response> ExecutePOISupplierQueryTaskV2Async(this TikTokClient client, Models.POISupplierQueryTaskV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "v2", "supplier", "query", "task")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("supplier_task_ids", string.Join(",", request.SupplierTaskIdList));

            return await client.SendRequestWithJsonAsync<Models.POISupplierQueryTaskV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/v2/supplier/query/supplier 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/status-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierQuerySupplierV2Response> ExecutePOISupplierQuerySupplierV2Async(this TikTokClient client, Models.POISupplierQuerySupplierV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "v2", "supplier", "query", "supplier")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("supplier_ext_id", string.Join(",", request.SupplierExternalIdList));

            return await client.SendRequestWithJsonAsync<Models.POISupplierQuerySupplierV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/supplier/match 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/shop/poi-sync-task </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISupplierMatchV2Response> ExecutePOISupplierMatchV2Async(this TikTokClient client, Models.POISupplierMatchV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "supplier", "match")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISupplierMatchV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
