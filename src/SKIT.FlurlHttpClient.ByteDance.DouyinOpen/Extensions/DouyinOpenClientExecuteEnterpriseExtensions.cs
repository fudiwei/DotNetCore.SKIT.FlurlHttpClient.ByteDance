using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteEnterpriseExtensions
    {
        #region IM
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/message/send 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/message-management-enterprise/message-to-user ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseIMMessageSendResponse> ExecuteEnterpriseIMMessageSendAsync(this DouyinOpenClient client, Models.EnterpriseIMMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "enterprise", "im", "message", "send")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.EnterpriseIMMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Media
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/upload-material-interface ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaUploadResponse> ExecuteEnterpriseMediaUploadAsync(this DouyinOpenClient client, Models.EnterpriseMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "enterprise", "media", "upload")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.MediaFileName is null)
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.MediaContentType is null)
                request.MediaContentType = "image/jpeg";

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MediaFileName, fileBytes: request.MediaFileBytes, fileContentType: request.MediaContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.EnterpriseMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/temp/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/upload-temp-material-interface ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaTempUploadResponse> ExecuteEnterpriseMediaTempUploadAsync(this DouyinOpenClient client, Models.EnterpriseMediaTempUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "enterprise", "media", "temp", "upload")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.MediaFileName is null)
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower();

            if (request.MediaContentType is null)
                request.MediaContentType = MimeTypes.Binary;

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MediaFileName, fileBytes: request.MediaFileBytes, fileContentType: request.MediaContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.EnterpriseMediaTempUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/media/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/material-list-interface ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaListResponse> ExecuteEnterpriseMediaListAsync(this DouyinOpenClient client, Models.EnterpriseMediaListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "enterprise", "media", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.EnterpriseMediaListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/delete-material-interface ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaDeleteResponse> ExecuteEnterpriseMediaDeleteAsync(this DouyinOpenClient client, Models.EnterpriseMediaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "enterprise", "media", "delete")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.EnterpriseMediaDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
