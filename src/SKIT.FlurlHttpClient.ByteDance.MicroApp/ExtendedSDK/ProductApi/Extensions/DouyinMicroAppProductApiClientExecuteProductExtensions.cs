using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    public static class DouyinMicroAppProductApiClientExecuteProductExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-add ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiAddResponse> ExecuteProductApiAddAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Product.CommonProductInfo.AppId is null)
                request.Product.CommonProductInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "add")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-modify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyResponse> ExecuteProductApiModifyAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Product.CommonProductInfo.AppId is null)
                request.Product.CommonProductInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "modify")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/status-modify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyStatusResponse> ExecuteProductApiModifyStatusAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiModifyStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ProductStatusInfo.AppId is null)
                request.ProductStatusInfo.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "modify_status")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiModifyStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_no_audit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-modify-no-audit ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyNoAuditResponse> ExecuteProductApiModifyNoAuditAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiModifyNoAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ProductInfo is not null)
            {
                if (request.ProductInfo.AppId is null)
                    request.ProductInfo.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "modify_no_audit")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiModifyNoAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryResponse> ExecuteProductApiQueryAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_review 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/queryReview ]]>
        /// </para>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryReviewResponse> ExecuteProductApiQueryReviewAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryReviewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_review");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryReviewResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_template_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/query-test-course ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryTemplateInfoResponse> ExecuteProductApiQueryTemplateInfoAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryTemplateInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_template_info");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryTemplateInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_class_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product/queryClassInfo ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryClassInfoResponse> ExecuteProductApiQueryClassInfoAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryClassInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_class_info");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryClassInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Resource
        /// <summary>
        /// <para>异步调用 [POST] /upload_resource 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiUploadResourceResponse> ExecuteProductApiUploadResourceAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiUploadResourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "upload_resource");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiUploadResourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_resource_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/resource-upload-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryResourceStatusResponse> ExecuteProductApiQueryResourceStatusAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryResourceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_resource_status");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryResourceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Qualification
        /// <summary>
        /// <para>异步调用 [POST] /add_qualification 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-add ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiAddQualificationResponse> ExecuteProductApiAddQualificationAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiAddQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "add_qualification")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiAddQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_qualification 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-modify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyQualificationResponse> ExecuteProductApiModifyQualificationAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiModifyQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "modify_qualification")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiModifyQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_qualification 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/qualification-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryQualificationResponse> ExecuteProductApiQueryQualificationAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryQualificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_qualification");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region RefundRule
        /// <summary>
        /// <para>异步调用 [POST] /query_refund_rule_meta 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/refund-meta-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiQueryRefundRuleMetaResponse> ExecuteProductApiQueryRefundRuleMetaAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiQueryRefundRuleMetaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_refund_rule_meta")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiQueryRefundRuleMetaResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_refund_rule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-refund-rule-modify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiModifyRefundRuleResponse> ExecuteProductApiModifyRefundRuleAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiModifyRefundRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "modify_refund_rule")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiModifyRefundRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Callback
        /// <summary>
        /// <para>异步调用 [POST] /sync_callback_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/sync-callback-url ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductApiSyncCallbackUrlResponse> ExecuteProductApiSyncCallbackUrlAsync(this DouyinMicroAppProductApiClient client, Models.ProductApiSyncCallbackUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "sync_callback_url");

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductApiSyncCallbackUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
