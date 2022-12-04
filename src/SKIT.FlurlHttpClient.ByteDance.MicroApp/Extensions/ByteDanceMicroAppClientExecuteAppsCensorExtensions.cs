using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsCensorExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apps/censor/image 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/content-security/picture-detect-v2 </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/picture-detect </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCensorImageResponse> ExecuteAppsCensorImageAsync(this ByteDanceMicroAppClient client, Models.AppsCensorImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "censor", "image");

            return await client.SendRequestWithJsonAsync<Models.AppsCensorImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
