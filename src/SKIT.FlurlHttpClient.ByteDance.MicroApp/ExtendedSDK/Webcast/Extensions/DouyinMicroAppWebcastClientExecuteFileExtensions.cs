using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    public static class DouyinMicroAppWebcastClientExecuteFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /file/card_image/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/image-upload ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastFileCardImageUploadResponse> ExecuteWebcastFileCardImageUploadAsync(this DouyinMicroAppWebcastClient client, Models.WebcastFileCardImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "file", "card_image", "upload")
                .WithHeader("X-Token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "image_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.ImageId)), "image_id");

            return await client.SendFlurlRequestAsync<Models.WebcastFileCardImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /file/card_image/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/image-review-status-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastFileCardImageGetResponse> ExecuteWebcastFileCardImageGetAsync(this DouyinMicroAppWebcastClient client, Models.WebcastFileCardImageGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "file", "card_image", "get")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastFileCardImageGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /file/card_image/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/image-delete ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastFileCardImageDeleteResponse> ExecuteWebcastFileCardImageDeleteAsync(this DouyinMicroAppWebcastClient client, Models.WebcastFileCardImageDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "file", "card_image", "delete")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastFileCardImageDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
