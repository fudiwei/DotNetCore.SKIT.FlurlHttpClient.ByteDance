using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteProductApiExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /product/api/add 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/product-add </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiAddResponse> ExecuteProductApiAddAsync(this ByteDanceMicroAppClient client, Models.ProductApiAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Product.CommonProductInfo.AppId == null)
                request.Product.CommonProductInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "add");

            return await client.SendRequestWithJsonAsync<Models.ProductApiAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/api/modify 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/product-modify </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyResponse> ExecuteProductApiModifyAsync(this ByteDanceMicroAppClient client, Models.ProductApiModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Product.CommonProductInfo.AppId == null)
                request.Product.CommonProductInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "modify");

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/api/modify_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/status-modify </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyStatusResponse> ExecuteProductApiModifyStatusAsync(this ByteDanceMicroAppClient client, Models.ProductApiModifyStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ProductStatusInfo.AppId == null)
                request.ProductStatusInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "modify_status");

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/api/query 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/product-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryResponse> ExecuteProductApiQueryAsync(this ByteDanceMicroAppClient client, Models.ProductApiQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "query");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Resource
        /// <summary>
        /// <para>异步调用 [POST] /product/api/upload_resource 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiUploadResourceResponse> ExecuteProductApiUploadResourceAsync(this ByteDanceMicroAppClient client, Models.ProductApiUploadResourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "upload_resource");

            return await client.SendRequestWithJsonAsync<Models.ProductApiUploadResourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/api/query_resource_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryResourceStatusResponse> ExecuteProductApiQueryResourceStatusAsync(this ByteDanceMicroAppClient client, Models.ProductApiQueryResourceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "query_resource_status");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryResourceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Qualification
        /// <summary>
        /// <para>异步调用 [POST] /product/api/add_qualification 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/product-modify </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/pan-knowledge/qualification-modify </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiAddQualificationResponse> ExecuteProductApiAddQualificationAsync(this ByteDanceMicroAppClient client, Models.ProductApiAddQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "add_qualification");

            return await client.SendRequestWithJsonAsync<Models.ProductApiAddQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
