using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteAppsDeveloperToolboxExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/developer_toolbox/image_material/upload/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/image-material/upload-image-material ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsDeveloperToolboxImageMaterialUploadV1Response> ExecuteAppsDeveloperToolboxImageMaterialUploadV1Async(this DouyinMicroAppClient client, Models.AppsDeveloperToolboxImageMaterialUploadV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "developer_toolbox", "image_material", "upload/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsDeveloperToolboxImageMaterialUploadV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/developer_toolbox/image_material/function_config/add/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/image-material/add-function-config ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsDeveloperToolboxImageMaterialFunctionConfigAddV1Response> ExecuteAppsDeveloperToolboxImageMaterialFunctionConfigAddV1Async(this DouyinMicroAppClient client, Models.AppsDeveloperToolboxImageMaterialFunctionConfigAddV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "developer_toolbox", "image_material", "function_config", "add/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsDeveloperToolboxImageMaterialFunctionConfigAddV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/developer_toolbox/image_material/function_config/query_status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/image-material/query-function-config-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsDeveloperToolboxImageMaterialFunctionConfigQueryStatusV1Response> ExecuteAppsDeveloperToolboxImageMaterialFunctionConfigQueryStatusV1Async(this DouyinMicroAppClient client, Models.AppsDeveloperToolboxImageMaterialFunctionConfigQueryStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "developer_toolbox", "image_material", "function_config", "query_status/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("function_id", request.FunctionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsDeveloperToolboxImageMaterialFunctionConfigQueryStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
