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
    }
}
