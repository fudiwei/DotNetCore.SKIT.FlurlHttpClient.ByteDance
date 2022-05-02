using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apps/order/v2/push 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/order/push </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsOrderPushV2Response> ExecuteAppsOrderPushV2Async(this ByteDanceMicroAppClient client, Models.AppsOrderPushV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "order", "v2", "push");

            return await client.SendRequestWithJsonAsync<Models.AppsOrderPushV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
