using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi
{
    public static class ByteDanceMicroAppProductApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /add 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-add </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiAddResponse> ExecuteProductApiAddAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Product.CommonProductInfo.AppId == null)
                request.Product.CommonProductInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "add")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-modify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyResponse> ExecuteProductApiModifyAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Product.CommonProductInfo.AppId == null)
                request.Product.CommonProductInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "modify")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/status-modify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyStatusResponse> ExecuteProductApiModifyStatusAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiModifyStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ProductStatusInfo.AppId == null)
                request.ProductStatusInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "modify_status")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_no_audit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-modify-no-audit </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyNoAuditResponse> ExecuteProductApiModifyNoAuditAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiModifyNoAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ProductInfo != null)
            {
                if (request.ProductInfo.AppId == null)
                    request.ProductInfo.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "modify_no_audit")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyNoAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryResponse> ExecuteProductApiQueryAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_review 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/queryReview </para>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryReviewResponse> ExecuteProductApiQueryReviewAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryReviewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_review");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryReviewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_template_info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/query-test-course </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryTemplateInfoResponse> ExecuteProductApiQueryTemplateInfoAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryTemplateInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_template_info");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryTemplateInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_class_info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product/queryClassInfo </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryClassInfoResponse> ExecuteProductApiQueryClassInfoAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryClassInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_class_info");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryClassInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Resource
        /// <summary>
        /// <para>异步调用 [POST] /upload_resource 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiUploadResourceResponse> ExecuteProductApiUploadResourceAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiUploadResourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "upload_resource");

            return await client.SendRequestWithJsonAsync<Models.ProductApiUploadResourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_resource_status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryResourceStatusResponse> ExecuteProductApiQueryResourceStatusAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryResourceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_resource_status");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryResourceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Qualification
        /// <summary>
        /// <para>异步调用 [POST] /add_qualification 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-add </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiAddQualificationResponse> ExecuteProductApiAddQualificationAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiAddQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "add_qualification")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiAddQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_qualification 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-modify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyQualificationResponse> ExecuteProductApiModifyQualificationAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiModifyQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "modify_qualification")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_qualification 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryQualificationResponse> ExecuteProductApiQueryQualificationAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_qualification");

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region RefundRule
        /// <summary>
        /// <para>异步调用 [POST] /query_refund_rule_meta 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/refund-meta-query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryRefundRuleMetaResponse> ExecuteProductApiQueryRefundRuleMetaAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiQueryRefundRuleMetaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_refund_rule_meta")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiQueryRefundRuleMetaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_refund_rule 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-refund-rule-modify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyRefundRuleResponse> ExecuteProductApiModifyRefundRuleAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiModifyRefundRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "modify_refund_rule")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendRequestWithJsonAsync<Models.ProductApiModifyRefundRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Callback
        /// <summary>
        /// <para>异步调用 [POST] /sync_callback_url 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiSyncCallbackUrlResponse> ExecuteProductApiSyncCallbackUrlAsync(this ByteDanceMicroAppProductApiClient client, Models.ProductApiSyncCallbackUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "sync_callback_url");

            return await client.SendRequestWithJsonAsync<Models.ProductApiSyncCallbackUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
