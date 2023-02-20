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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-add </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-modify </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/status-modify </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-query </para>
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

        /// <summary>
        /// <para>异步调用 [POST] /product/api/query_review 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/queryReview </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryReviewResponse> ExecuteProductApiQueryReviewAsync(this ByteDanceMicroAppClient client, Models.ProductApiQueryReviewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "query_review");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryReviewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Resource
        /// <summary>
        /// <para>异步调用 [POST] /product/api/upload_resource 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload-query </para>
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-modify </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-modify </para>
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

        #region RefundRule
        /// <summary>
        /// <para>异步调用 [POST] /product/api/query_refund_rule_meta 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/refund-meta-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryRefundRuleMetaResponse> ExecuteProductApiQueryRefundRuleMetaAsync(this ByteDanceMicroAppClient client, Models.ProductApiQueryRefundRuleMetaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "query_refund_rule_meta")
                .WithHeader("Aweme-Check-Type", request.CheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryRefundRuleMetaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/api/modify_refund_rule 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-refund-rule-modify </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyRefundRuleResponse> ExecuteProductApiModifyRefundRuleAsync(this ByteDanceMicroAppClient client, Models.ProductApiModifyRefundRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "modify_refund_rule")
                .WithHeader("Aweme-Check-Type", request.CheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyRefundRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Callback
        /// <summary>
        /// <para>异步调用 [POST] /product/api/sync_callback_url 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiSyncCallbackUrlResponse> ExecuteProductApiSyncCallbackUrlAsync(this ByteDanceMicroAppClient client, Models.ProductApiSyncCallbackUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "api", "sync_callback_url");

            return await client.SendRequestWithJsonAsync<Models.ProductApiSyncCallbackUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
