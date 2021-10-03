using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteImageExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /image/upload 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798493293807628 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImageUploadResponse> ExecuteImageUploadAsync(this TikTokClient client, Models.ImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "image", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            if (string.IsNullOrEmpty(request.ImageContentType))
                request.ImageContentType = "image/jpeg";

            if (string.IsNullOrEmpty(request.ImageFileName))
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            using var fileContent = new ByteArrayContent(request.ImageFileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent();
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.ImageContentType);
            httpContent.Add(fileContent, "image", request.ImageFileName);

            return await client.SendRequestAsync<Models.ImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /image/create 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798493293774860 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImageCreateResponse> ExecuteImageCreateAsync(this TikTokClient client, Models.ImageCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "image", "create")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.ImageCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
