using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOIServiceProviderExtensions
    {
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
    }
}
