using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecutePromiseExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /promise/setSkuShipTime 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/34/569 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromiseSetSKUShipTimeResponse> ExecutePromiseSetSKUShipTimeAsync(this TikTokShopClient client, Models.PromiseSetSKUShipTimeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promise", "setSkuShipTime")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.PromiseSetSKUShipTimeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
