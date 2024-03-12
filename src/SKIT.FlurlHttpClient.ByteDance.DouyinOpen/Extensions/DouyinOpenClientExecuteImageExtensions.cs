using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteImageExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /image/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/video-management/douyin/publish-img/upload ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-07-06 下线。")]
        public static async Task<Models.ImageUploadResponse> ExecuteImageUploadAsync(this DouyinOpenClient client, Models.ImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageContentType is null)
                request.ImageContentType = "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "image", "upload")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageContentType, formDataName: "image");
            return await client.SendFlurlRequestAsync<Models.ImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /image/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/video-management/douyin/publish-img/publish ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-07-06 下线。")]
        public static async Task<Models.ImageCreateResponse> ExecuteImageCreateAsync(this DouyinOpenClient client, Models.ImageCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "image", "create")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ImageCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
