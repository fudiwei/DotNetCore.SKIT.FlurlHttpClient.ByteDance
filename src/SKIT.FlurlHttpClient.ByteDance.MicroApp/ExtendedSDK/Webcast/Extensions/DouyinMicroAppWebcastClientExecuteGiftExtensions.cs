using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    public static class DouyinMicroAppWebcastClientExecuteGiftExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /gift/top_gift 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastGiftTopGiftResponse> ExecuteWebcastGiftTopGiftAsync(this DouyinMicroAppWebcastClient client, Models.WebcastGiftTopGiftRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "gift", "top_gift")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastGiftTopGiftResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
