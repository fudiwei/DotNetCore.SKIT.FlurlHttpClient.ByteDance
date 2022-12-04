using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteTagsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/tags/text/antidirt 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/content-security/content-security-detect </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/open-capacity/content-security/content-security-detect </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TagsTextAntiDirtV2Response> ExecuteTagsTextAntiDirtV2Async(this ByteDanceMicroAppClient client, Models.TagsTextAntiDirtV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "tags", "text", "antidirt")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TagsTextAntiDirtV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/tags/image 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/open-capacity/content-security/picture-detect </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TagsImageV2Response> ExecuteTagsImageV2Async(this ByteDanceMicroAppClient client, Models.TagsImageV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "tags", "image")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TagsImageV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
