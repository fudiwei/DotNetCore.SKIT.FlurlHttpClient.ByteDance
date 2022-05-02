using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOISPUExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/spu/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/goods-repo/spu-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISPUSyncV2Response> ExecutePOISPUSyncV2Async(this TikTokClient client, Models.POISPUSyncV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "spu", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISPUSyncV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/spu/status_sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/goods-repo/spu-status-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISPUStatusSyncV2Response> ExecutePOISPUStatusSyncV2Async(this TikTokClient client, Models.POISPUStatusSyncV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "spu", "status_sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISPUStatusSyncV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/spu/stock_update 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/goods-repo/spu-repo-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISPUStockUpdateV2Response> ExecutePOISPUStockUpdateV2Async(this TikTokClient client, Models.POISPUStockUpdateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "spu", "stock_update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISPUStockUpdateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/v2/spu/get 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/goods-repo/spu-info-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISPUGetV2Response> ExecutePOISPUGetV2Async(this TikTokClient client, Models.POISPUGetV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "v2", "spu", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("spu_ext_id", request.SPUExternalId)
                .SetQueryParam("need_spu_draft", request.RequireSPUDraft);

            if (request.SPUDraftCount != null)
                flurlReq.SetQueryParam("spu_draft_count", request.SPUDraftCount.Value);

            if (request.SupplierIdForFilterReasonList != null)
                flurlReq.SetQueryParam("supplier_ids_for_filter_reason", string.Join(",", request.SupplierIdForFilterReasonList));

            return await client.SendRequestWithJsonAsync<Models.POISPUGetV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/spu/take_rate/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/goods-repo/take-rate </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISPUTakeRateSyncV2Response> ExecutePOISPUTakeRateSyncV2Async(this TikTokClient client, Models.POISPUTakeRateSyncV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "spu", "take_rate", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISPUTakeRateSyncV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
