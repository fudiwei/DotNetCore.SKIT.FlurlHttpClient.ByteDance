using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOICommonExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /poi/common/plan/detail 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/common-plan-detail </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICommonPlanDetailResponse> ExecutePOICommonPlanDetailAsync(this TikTokClient client, Models.POICommonPlanDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "common", "plan", "detail")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICommonPlanDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/common/plan/talent/detail 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/common-plan-talent-detail </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICommonPlanTalentDetailResponse> ExecutePOICommonPlanTalentDetailAsync(this TikTokClient client, Models.POICommonPlanTalentDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "common", "plan", "talent", "detail")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICommonPlanTalentDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/common/plan/talent/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/common-plan-talent-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICommonPlanTalentListResponse> ExecutePOICommonPlanTalentListAsync(this TikTokClient client, Models.POICommonPlanTalentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "common", "plan", "talent", "list")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICommonPlanTalentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/common/plan/talent/media/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/common-plan-talent-media-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICommonPlanTalentMediaListResponse> ExecutePOICommonPlanTalentMediaListAsync(this TikTokClient client, Models.POICommonPlanTalentMediaListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "common", "plan", "talent", "media", "list")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICommonPlanTalentMediaListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/plan/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/plan-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIPlanListResponse> ExecutePOIPlanListAsync(this TikTokClient client, Models.POIPlanListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "plan", "list")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIPlanListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/common/plan/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/save-common-plan </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICommonPlanSaveResponse> ExecutePOICommonPlanSaveAsync(this TikTokClient client, Models.POICommonPlanSaveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "common", "plan", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICommonPlanSaveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/common/plan/update/status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/cps/update-common-plan-status </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICommonPlanUpdateStatusResponse> ExecutePOICommonPlanUpdateStatusAsync(this TikTokClient client, Models.POICommonPlanUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "common", "plan", "update", "status")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICommonPlanUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
