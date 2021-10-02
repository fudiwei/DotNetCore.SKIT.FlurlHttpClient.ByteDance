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
    public static class TikTokClientExecuteJSExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /js/getticket 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798514798004236 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.JSGetTicketResponse> ExecuteJSGetTicketAsync(this TikTokClient client, Models.JSGetTicketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "js", "getticket")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.JSGetTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
