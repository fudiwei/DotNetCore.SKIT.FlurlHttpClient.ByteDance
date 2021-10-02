using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteEnterpriseMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/upload 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798342919571459 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaUploadResponse> ExecuteEnterpriseMediaUploadAsync(this TikTokClient client, Models.EnterpriseMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "media", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            if (string.IsNullOrEmpty(request.MediaFileName))
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower();

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new ByteArrayContent(request.MediaFileBytes ?? new byte[0]), "media", request.MediaFileName);

            return await client.SendRequestAsync<Models.EnterpriseMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/temp/upload 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798342919604227 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaTempUploadResponse> ExecuteEnterpriseMediaTempUploadAsync(this TikTokClient client, Models.EnterpriseMediaTempUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "media", "temp", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            if (string.IsNullOrEmpty(request.MediaFileName))
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower();

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new ByteArrayContent(request.MediaFileBytes ?? new byte[0]), "media", request.MediaFileName);

            return await client.SendRequestAsync<Models.EnterpriseMediaTempUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/media/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798342919538691 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaListResponse> ExecuteEnterpriseMediaListAsync(this TikTokClient client, Models.EnterpriseMediaListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "media", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseMediaListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/delete 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798342919505923 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaDeleteResponse> ExecuteEnterpriseMediaDeleteAsync(this TikTokClient client, Models.EnterpriseMediaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "media", "delete")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(request.MediaId), "media_id");

            return await client.SendRequestAsync<Models.EnterpriseMediaDeleteResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
