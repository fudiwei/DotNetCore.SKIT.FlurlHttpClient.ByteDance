using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternalItemExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/base 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/video-data/get-basic-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemBaseResponse> ExecuteDataExternalItemBaseAsync(this TikTokClient client, Models.DataExternalItemBaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "base")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemBaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/like 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/video-data/get-like-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemLikeResponse> ExecuteDataExternalItemLikeAsync(this TikTokClient client, Models.DataExternalItemLikeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "like")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemLikeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/comment 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/video-data/get-comment-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemCommentResponse> ExecuteDataExternalItemCommentAsync(this TikTokClient client, Models.DataExternalItemCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "comment")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/play 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/video-data/get-play-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemPlayResponse> ExecuteDataExternalItemPlayAsync(this TikTokClient client, Models.DataExternalItemPlayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "play")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemPlayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/share 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/video-data/get-share-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemShareResponse> ExecuteDataExternalItemShareAsync(this TikTokClient client, Models.DataExternalItemShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "share")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
