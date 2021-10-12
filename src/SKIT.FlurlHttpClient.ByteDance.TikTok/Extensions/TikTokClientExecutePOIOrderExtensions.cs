using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOIOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /poi/order/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798579239290892 </para>
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
    }
}
