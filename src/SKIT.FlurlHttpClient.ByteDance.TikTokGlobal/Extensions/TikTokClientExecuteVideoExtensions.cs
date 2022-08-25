using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokClientExecuteVideoExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /video/list 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-video-list/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoListResponse> ExecuteVideoListAsync(this TikTokClient client, Models.VideoListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "list");

            return await client.SendRequestWithJsonAsync<Models.VideoListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/query 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/login-kit-video-query/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoQueryResponse> ExecuteVideoQueryAsync(this TikTokClient client, Models.VideoQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "query")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.VideoQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
