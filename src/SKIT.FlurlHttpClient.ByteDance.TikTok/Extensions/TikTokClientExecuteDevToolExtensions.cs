using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDevToolExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /devtool/micapp/is_legal 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/mini-app-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DevToolMicroAppIsLegalResponse> ExecuteDevToolMicroAppIsLegalAsync(this TikTokClient client, Models.DevToolMicroAppIsLegalRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "devtool", "micapp", "is_legal")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("micapp_id", request.MicroAppId);

            return await client.SendRequestWithJsonAsync<Models.DevToolMicroAppIsLegalResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
