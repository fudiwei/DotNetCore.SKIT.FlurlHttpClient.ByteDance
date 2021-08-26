using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteV2Extensions
    {
        #region Tags
        /// <summary>
        /// <para>异步调用 [POST] /v2/tags/text/antidirt 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/content-security/content-security-detect </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/open-capacity/content-security/content-security-detect </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.V2TagsTextAntiDirtResponse> ExecuteV2TagsTextAntiDirtAsync(this ByteDanceMicroAppClient client, Models.V2TagsTextAntiDirtRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "tags", "text", "antidirt")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.V2TagsTextAntiDirtResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/tags/image 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/open-capacity/content-security/picture-detect </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.V2TagsImageResponse> ExecuteV2TagsImageAsync(this ByteDanceMicroAppClient client, Models.V2TagsImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "tags", "image")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.V2TagsImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
