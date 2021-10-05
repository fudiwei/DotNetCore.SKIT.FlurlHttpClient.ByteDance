using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteEnterpriseIMExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/message/send 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798087226329100 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMMessageSendResponse> ExecuteEnterpriseIMMessageSendAsync(this TikTokClient client, Models.EnterpriseIMMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "im", "message", "send")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseIMMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
