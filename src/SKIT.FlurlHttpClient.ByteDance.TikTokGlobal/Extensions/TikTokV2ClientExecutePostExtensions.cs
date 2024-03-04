using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokV2ClientExecutePostExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /post/publish/video/init/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-direct-post ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PostPublishVideoInitResponse> ExecutePostPublishVideoInitAsync(this TikTokV2Client client, Models.PostPublishVideoInitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "post", "publish", "video", "init", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.PostPublishVideoInitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /post/publish/inbox/video/init/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-upload-video ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PostPublishInboxVideoInitResponse> ExecutePostPublishInboxVideoInitAsync(this TikTokV2Client client, Models.PostPublishInboxVideoInitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "post", "publish", "inbox", "video", "init", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.PostPublishInboxVideoInitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{upload_url} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-direct-post ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-upload-video ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PostUploadVideoResponse> ExecutePostUploadVideoAsync(this TikTokV2Client client, Models.PostUploadVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ChunkContentType is null)
                request.ChunkContentType = "video/mp4";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, request.UploadUrl)
                .WithUrl(request.UploadUrl)
                .WithHeader(HttpHeaders.ContentType, request.ChunkContentType)
                .WithHeader(HttpHeaders.ContentLength, request.ChunkBytes.Length)
                .WithHeader(HttpHeaders.ContentRange, $"bytes {request.ChunkContentRangeStart}-{request.ChunkContentRangeEnd}/{request.VideoSize}");

            using HttpContent httpContent = new ByteArrayContent(request.ChunkBytes);
            return await client.SendFlurlRequestAsync<Models.PostUploadVideoResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /post/publish/content/init/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-photo-post ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PostPublishContentInitResponse> ExecutePostPublishContentInitAsync(this TikTokV2Client client, Models.PostPublishContentInitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "post", "publish", "content", "init", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.PostPublishContentInitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /post/publish/creator_info/query/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-query-creator-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PostPublishCreatorInfoQueryResponse> ExecutePostPublishCreatorInfoQueryAsync(this TikTokV2Client client, Models.PostPublishCreatorInfoQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "post", "publish", "creator_info", "query", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.PostPublishCreatorInfoQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /post/publish/status/fetch/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/content-posting-api-reference-get-video-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PostPublishStatusFetchResponse> ExecutePostPublishStatusFetchAsync(this TikTokV2Client client, Models.PostPublishStatusFetchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "post", "publish", "status", "fetch", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.PostPublishStatusFetchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
