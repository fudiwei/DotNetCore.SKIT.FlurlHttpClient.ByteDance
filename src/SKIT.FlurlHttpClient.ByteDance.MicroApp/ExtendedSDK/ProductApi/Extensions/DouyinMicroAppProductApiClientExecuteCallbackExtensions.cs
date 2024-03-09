using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    public static class DouyinMicroAppProductApiClientExecuteCallbackExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /sync_callback_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSyncCallbackUrlResponse> ExecuteProductSyncCallbackUrlAsync(this DouyinMicroAppProductApiClient client, Models.ProductSyncCallbackUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "sync_callback_url");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductSyncCallbackUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
