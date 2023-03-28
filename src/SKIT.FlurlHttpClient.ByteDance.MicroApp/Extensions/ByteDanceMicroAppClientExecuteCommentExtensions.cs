using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteCommentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /comment/open/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/evolution/obtain-evolution </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CommentOpenGetResponse> ExecuteCommentOpenGetAsync(this ByteDanceMicroAppClient client, Models.CommentOpenGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "comment", "open", "get");

            return await client.SendRequestWithJsonAsync<Models.CommentOpenGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
