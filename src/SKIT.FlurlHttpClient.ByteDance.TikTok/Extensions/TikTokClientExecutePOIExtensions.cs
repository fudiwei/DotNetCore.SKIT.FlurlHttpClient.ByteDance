using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOIExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /poi/search/keyword 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/video-management/douyin/search-video/video-poi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISearchKeywordResponse> ExecutePOISearchKeywordAsync(this TikTokClient client, Models.POISearchKeywordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "search", "keyword")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("keyword", request.Keyword)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            if (request.City != null)
                flurlReq.SetQueryParam("city", request.City);

            return await client.SendRequestWithJsonAsync<Models.POISearchKeywordResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/get-douyin-poi-id </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIQueryResponse> ExecutePOIQueryAsync(this TikTokClient client, Models.POIQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "query")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("amap_id", request.AMapId);

            return await client.SendRequestWithJsonAsync<Models.POIQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/base/query/amap 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-basic-ability/get-douyin-id-by-autoNavi-id </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIBaseQueryAMapResponse> ExecutePOIBaseQueryAMapAsync(this TikTokClient client, Models.POIBaseQueryAMapRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "base", "query", "amap")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("amap_id", request.AMapId);

            return await client.SendRequestWithJsonAsync<Models.POIBaseQueryAMapResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Common
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
        #endregion

        #region Coupon
        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/coupon/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/coupon/coupon-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICouponSyncV2Response> ExecutePOICouponSyncV2Async(this TikTokClient client, Models.POICouponSyncV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "coupon", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICouponSyncV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/coupon/sync/coupon_available 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/coupon/coupon-update </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICouponSyncCouponAvailableV2Response> ExecutePOICouponSyncCouponAvailableV2Async(this TikTokClient client, Models.POICouponSyncCouponAvailableV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "coupon", "sync", "coupon_available")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICouponSyncCouponAvailableV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region External
        #region External/Hotel
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/commit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/place-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelOrderCommitResponse> ExecutePOIExternalHotelOrderCommitAsync(this TikTokClient client, Models.POIExternalHotelOrderCommitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "hotel", "order", "commit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelOrderCommitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/payment-status-notice </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelOrderStatusResponse> ExecutePOIExternalHotelOrderStatusAsync(this TikTokClient client, Models.POIExternalHotelOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "hotel", "order", "status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelOrderStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/cancel 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/cancel-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelOrderCancelResponse> ExecutePOIExternalHotelOrderCancelAsync(this TikTokClient client, Models.POIExternalHotelOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "hotel", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/ext/hotel/sku 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/sku-pull </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalHotelSKUResponse> ExecutePOIExternalHotelSKUAsync(this TikTokClient client, Models.POIExternalHotelSKURequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "ext", "hotel", "sku")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("spu_ext_id", request.SPUExternalId)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.POIExternalHotelSKUResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region External/PresaleGroupon
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/create 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/place-presell-ticket-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponOrderCreateResponse> ExecutePOIExternalPresaleGrouponOrderCreateAsync(this TikTokClient client, Models.POIExternalPresaleGrouponOrderCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponOrderCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/commit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/confirm-presell-ticket-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponOrderCommitResponse> ExecutePOIExternalPresaleGrouponOrderCommitAsync(this TikTokClient client, Models.POIExternalPresaleGrouponOrderCommitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "commit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponOrderCommitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/cancel 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/cancel-presell-ticket-order </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponOrderCancelResponse> ExecutePOIExternalPresaleGrouponOrderCancelAsync(this TikTokClient client, Models.POIExternalPresaleGrouponOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /poi/order/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/client-message-sync/order-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderSyncResponse> ExecutePOIOrderSyncAsync(this TikTokClient client, Models.POIOrderSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.DateTimeUnixMilliseconds == null)
                request.DateTimeUnixMilliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/order/status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/order-status-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderStatusResponse> ExecutePOIOrderStatusAsync(this TikTokClient client, Models.POIOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/order/confirm 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/cancel-presell-ticket </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderConfirmResponse> ExecutePOIOrderConfirmAsync(this TikTokClient client, Models.POIOrderConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "confirm")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/order/confirm/prepare 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/pre-cancel-presell-ticket </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderConfirmPrepareResponse> ExecutePOIOrderConfirmPrepareAsync(this TikTokClient client, Models.POIOrderConfirmPrepareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "confirm", "prepare")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderConfirmPrepareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/order/confirm/cancel_prepare 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/cancel-precancel-presell-ticket </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderConfirmCancelPrepareResponse> ExecutePOIOrderConfirmCancelPrepareAsync(this TikTokClient client, Models.POIOrderConfirmCancelPrepareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "confirm", "cancel_prepare")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderConfirmCancelPrepareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/order/bill/token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/get-download-bill-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderBillTokenResponse> ExecutePOIOrderBillTokenAsync(this TikTokClient client, Models.POIOrderBillTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "order", "bill", "token")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendRequestWithJsonAsync<Models.POIOrderBillTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/order/list/token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/trade-system/get-download-order-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderListTokenResponse> ExecutePOIOrderListTokenAsync(this TikTokClient client, Models.POIOrderListTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "order", "list", "token")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("order_date", request.OrderDateString);

            return await client.SendRequestWithJsonAsync<Models.POIOrderListTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ServiceProvider
        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/service_provider/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/7005579747057027080 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIServiceProviderSyncV2Response> ExecutePOIServiceProviderSyncV2Async(this TikTokClient client, Models.POIServiceProviderSyncV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "service_provider", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIServiceProviderSyncV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SKU
        /// <summary>
        /// <para>异步调用 [POST] /poi/sku/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/sku-sync </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POISKUSyncResponse> ExecutePOISKUSyncAsync(this TikTokClient client, Models.POISKUSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "sku", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POISKUSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SPU
        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/spu/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/spu-sync </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/spu-status-sync </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/spu-repo-sync </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/spu-info-query </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/goods-repo/take-rate </para>
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
        #endregion

        #region Supplier
        /// <summary>
        /// <para>异步调用 [POST] /poi/supplier/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/synchronism/ </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/search </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/query-all-shop-info </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/query-shop-all-tasks </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/task-query </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/status-query </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/shop/poi-sync-task </para>
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
        #endregion
    }
}
