using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteSandboxExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /sandbox/webhook/event/send 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806514870765575 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SandboxWebhookEventSendResponse> ExecuteSandboxWebhookEventSendAsync(this TikTokClient client, Models.SandboxWebhookEventSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "sandbox", "webhook", "event", "send")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(request.EventType, Encoding.UTF8), "event_type");

            return await client.SendRequestAsync<Models.SandboxWebhookEventSendResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
