using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokClientV2ExecuteVideoExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /video/list/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/tiktok-api-v2-video-list/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoListV2Response> ExecuteVideoListV2Async(this TikTokClientV2 client, Models.VideoListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "list/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendRequestWithJsonAsync<Models.VideoListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/query/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/tiktok-api-v2-video-query/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoQueryV2Response> ExecuteVideoQueryV2Async(this TikTokClientV2 client, Models.VideoQueryV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "query/")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendRequestWithJsonAsync<Models.VideoQueryV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
