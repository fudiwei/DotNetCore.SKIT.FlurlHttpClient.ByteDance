using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokClientExecuteShareExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /share/video/upload/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/web-video-kit-with-web/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShareVideoUploadResponse> ExecuteShareVideoUploadAsync(this TikTokClient client, Models.ShareVideoUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.VideoFileName is null)
                request.VideoFileName = Guid.NewGuid().ToString("N").ToLower() + ".mp4";

            if (request.VideoContentType is null)
                request.VideoContentType = "video/mp4";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "share", "video", "upload/")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.VideoFileName, fileBytes: request.VideoFileBytes, fileContentType: request.VideoContentType!, formDataName: "video");
            return await client.SendFlurlRequestAsync<Models.ShareVideoUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
