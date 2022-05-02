using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteEventExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /event/status/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/develop/webhooks/get-event-subscription-status </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EventStatusListResponse> ExecuteEventStatusListAsync(this TikTokClient client, Models.EventStatusListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "event", "status", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EventStatusListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /event/status/update 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/develop/webhooks/update-event-subscription-status </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EventStatusUpdateResponse> ExecuteEventStatusUpdateAsync(this TikTokClient client, Models.EventStatusUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "event", "status", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EventStatusUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
