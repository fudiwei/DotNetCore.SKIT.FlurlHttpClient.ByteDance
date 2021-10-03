using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteVideoExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /video/upload 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798087398295555 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoUploadResponse> ExecuteVideoUploadAsync(this TikTokClient client, Models.VideoUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "upload")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (string.IsNullOrEmpty(request.VideoContentType))
                request.VideoContentType = "video/mp4";

            if (string.IsNullOrEmpty(request.VideoFileName))
                request.VideoFileName = Guid.NewGuid().ToString("N").ToLower() + ".mp4";

            using var fileContent = new ByteArrayContent(request.VideoFileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent();
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.VideoContentType);
            httpContent.Add(fileContent, "video", request.VideoFileName);

            return await client.SendRequestAsync<Models.VideoUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/part/init 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798087398393859 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoPartInitializeResponse> ExecuteVideoPartInitializeAsync(this TikTokClient client, Models.VideoPartInitializeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "part", "init")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.VideoPartInitializeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/part/upload 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798087226460172 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoPartUploadResponse> ExecuteVideoPartUploadAsync(this TikTokClient client, Models.VideoPartUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "part", "upload")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("upload_id", request.UploadId)
                .SetQueryParam("part_number", request.PartNumber);

            if (string.IsNullOrEmpty(request.VideoContentType))
                request.VideoContentType = "video/mp4";

            if (string.IsNullOrEmpty(request.VideoFileName))
                request.VideoFileName = Guid.NewGuid().ToString("N").ToLower() + ".mp4";

            using var fileContent = new ByteArrayContent(request.VideoFileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent();
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.VideoContentType);
            httpContent.Add(fileContent, "video", request.VideoFileName);

            return await client.SendRequestAsync<Models.VideoPartUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/part/complete 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798087398361091 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoPartCompleteResponse> ExecuteVideoPartCompleteAsync(this TikTokClient client, Models.VideoPartCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "part", "complete")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("upload_id", request.UploadId);

            return await client.SendRequestWithJsonAsync<Models.VideoPartCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/create 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798087398328323 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoCreateResponse> ExecuteVideoCreateAsync(this TikTokClient client, Models.VideoCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "create")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.VideoCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/delete 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806536383383560 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoDeleteResponse> ExecuteVideoDeleteAsync(this TikTokClient client, Models.VideoDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "delete")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.VideoDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /video/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806536383318024 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoListResponse> ExecuteVideoListAsync(this TikTokClient client, Models.VideoListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "video", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.VideoListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /video/data 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806544931325965 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VideoDataResponse> ExecuteVideoDataAsync(this TikTokClient client, Models.VideoDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "video", "data")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.VideoDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
