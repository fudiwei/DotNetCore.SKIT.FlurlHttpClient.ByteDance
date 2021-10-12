using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOIExternalExtensions
    {
        #region Hotel
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/hotel/order/commit 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806532054812686 </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc/6848806510630307854 </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc/6848806501990041614 </para>
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
        #endregion

        #region PresaleGroupon
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/create 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6875919211626121220 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponCreateResponse> ExecutePOIExternalPresaleGrouponCreateAsync(this TikTokClient client, Models.POIExternalPresaleGrouponCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/commit 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6875919211626072068 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponCommitResponse> ExecutePOIExternalPresaleGrouponCommitAsync(this TikTokClient client, Models.POIExternalPresaleGrouponCommitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "commit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponCommitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /poi/ext/presale_groupon/order/cancel 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6875919211626022916 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIExternalPresaleGrouponCancelResponse> ExecutePOIExternalPresaleGrouponCancelAsync(this TikTokClient client, Models.POIExternalPresaleGrouponCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "ext", "presale_groupon", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIExternalPresaleGrouponCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
