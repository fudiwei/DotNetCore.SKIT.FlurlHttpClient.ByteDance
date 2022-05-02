using System;
using System.Net.Http;
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/tools-ability/material-management/upload-material-interface </para>
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
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.MediaFileName == null)
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.MediaContentType == null)
                request.MediaContentType = "image/jpeg";

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MediaFileName, fileBytes: request.MediaFileBytes, fileContentType: request.MediaContentType!, formDataName: "media");
            return await client.SendRequestAsync<Models.EnterpriseMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/temp/upload 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/tools-ability/material-management/upload-temp-material-interface </para>
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
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.MediaFileName == null)
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower();

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MediaFileName, fileBytes: request.MediaFileBytes, fileContentType: request.MediaContentType!, formDataName: "media");
            return await client.SendRequestAsync<Models.EnterpriseMediaTempUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/media/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/tools-ability/material-management/material-list-interface </para>
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
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseMediaListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/delete 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/tools-ability/material-management/delete-material-interface </para>
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
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseMediaDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
