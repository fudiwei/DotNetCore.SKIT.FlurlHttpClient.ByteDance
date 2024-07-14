using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteLegacyCommentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/comment/open/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/evolution/obtain-evolution ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CommentOpenGetResponse> ExecuteCommentOpenGetAsync(this DouyinMicroAppClient client, Models.CommentOpenGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "comment", "open", "get")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "comment", "open", "get"));

            return await client.SendFlurlRequestAsJsonAsync<Models.CommentOpenGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/comment/developer/reply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/evolution/developer-comment-reply ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CommentDeveloperReplyResponse> ExecuteCommentDeveloperReplyAsync(this DouyinMicroAppClient client, Models.CommentDeveloperReplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "comment", "developer", "reply")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "comment", "developer", "reply"));

            return await client.SendFlurlRequestAsJsonAsync<Models.CommentDeveloperReplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/comment/developer/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/evolution/developer-delete-reply ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CommentDeveloperDeleteResponse> ExecuteCommentDeveloperDeleteAsync(this DouyinMicroAppClient client, Models.CommentDeveloperDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "comment", "developer", "delete")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "comment", "developer", "delete"));

            return await client.SendFlurlRequestAsJsonAsync<Models.CommentDeveloperDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
