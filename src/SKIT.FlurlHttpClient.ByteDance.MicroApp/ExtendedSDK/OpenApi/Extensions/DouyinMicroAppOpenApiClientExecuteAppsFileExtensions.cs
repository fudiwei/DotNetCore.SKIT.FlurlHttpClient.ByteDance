using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    using SKIT.FlurlHttpClient;

    public static class DouyinMicroAppOpenApiClientExecuteAppsFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apps/v2/file/upload_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/uploadMaterial-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsFileUploadMaterialV2Response> ExecuteOpenAppsFileUploadMaterialV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsFileUploadMaterialV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MaterialFileName is null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + (request.MaterialType == 8 ? ".pdf" : ".jpg");

            if (request.MaterialFileContentType is null)
                request.MaterialFileContentType = MimeTypes.GetMimeMapping(request.MaterialFileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v2", "file", "upload_material")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: request.MaterialFileContentType, formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");

            return await client.SendFlurlRequestAsync<Models.OpenAppsFileUploadMaterialV2Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
