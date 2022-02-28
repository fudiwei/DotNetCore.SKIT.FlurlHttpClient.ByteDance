using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteOpenApiExtensions
    {
        #region Auth
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/auth/tp/token 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/access </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1AuthThirdPartyTokenResponse> ExecuteOpenApiV1AuthThirdPartyTokenAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1AuthThirdPartyTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.ComponentAppSecret == null)
                request.ComponentAppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "auth", "tp", "token")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_appsecret", request.ComponentAppSecret)
                .SetQueryParam("component_ticket", request.ComponentTicket);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1AuthThirdPartyTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/auth/pre_auth_code 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/auth </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1AuthPreAuthCodeResponse> ExecuteOpenApiV1AuthPreAuthCodeAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1AuthPreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1AuthPreAuthCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v2/auth/pre_auth_code 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/auth </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV2AuthPreAuthCodeResponse> ExecuteOpenApiV2AuthPreAuthCodeAsync(this ByteDanceMicroAppClient client, Models.OpenApiV2AuthPreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v2", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV2AuthPreAuthCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/auth/retrieve 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/find </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1AuthRetrieveResponse> ExecuteOpenApiV1AuthRetrieveAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1AuthRetrieveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "auth", "retrieve")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("authorization_appid", request.AuthorizerAppId);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1AuthRetrieveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region OAuth
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/oauth/token 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/voucher </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/update </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1OAuthTokenResponse> ExecuteOpenApiV1OAuthTokenAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1OAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "oauth", "token")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("grant_type", request.GrantType);

            if (request.AuthCode != null)
                flurlReq.SetQueryParam("authorization_code", request.AuthCode);

            if (request.AuthorizerRefreshToken != null)
                flurlReq.SetQueryParam("authorizer_refresh_token", request.AuthorizerRefreshToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1OAuthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ThirdParty
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/template/get_tpl_list 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/template/tpl-list </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyTemplateGetTemplateListResponse> ExecuteOpenApiV1ThirdPartyTemplateGetTemplateListAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyTemplateGetTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "template", "get_tpl_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyTemplateGetTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/template/get_draft_list 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/template/draft-list </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyTemplateGetDraftListResponse> ExecuteOpenApiV1ThirdPartyTemplateGetDraftListAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyTemplateGetDraftListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "template", "get_draft_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyTemplateGetDraftListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/template/add_tpl 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/template/add </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyTemplateAddTemplateResponse> ExecuteOpenApiV1ThirdPartyTemplateAddTemplateAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyTemplateAddTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "template", "add_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyTemplateAddTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/template/del_tpl 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/template/delete </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyTemplateDeleteTemplateResponse> ExecuteOpenApiV1ThirdPartyTemplateDeleteTemplateAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyTemplateDeleteTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "template", "del_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyTemplateDeleteTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/download/webview_file 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/download </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyDownloadWebviewFileResponse> ExecuteOpenApiV1ThirdPartyDownloadWebviewFileAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyDownloadWebviewFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "download", "webview_file")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyDownloadWebviewFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/auth_app_list 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/auth-app-list </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyAuthAppListResponse> ExecuteOpenApiV1ThirdPartyAuthAppListAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyAuthAppListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "auth_app_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyAuthAppListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/poi/supplier/match 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/supplier-match </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyPOISupplierMatchResponse> ExecuteOpenApiV1ThirdPartyPOISupplierMatchAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyPOISupplierMatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "poi", "supplier", "match")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyPOISupplierMatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/supplier/query/match_task 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/query-match-task </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyPOISupplierQueryMatchTaskResponse> ExecuteOpenApiV1ThirdPartyPOISupplierQueryMatchTaskAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyPOISupplierQueryMatchTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "poi", "supplier", "query", "match_task")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("task_ids", string.Join(",", request.TaskIdList));

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyPOISupplierQueryMatchTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/supplier/query/match 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/supplier-query-match </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyPOISupplierQueryMatchResponse> ExecuteOpenApiV1ThirdPartyPOISupplierQueryMatchAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyPOISupplierQueryMatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "poi", "supplier", "query", "match")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("supplier_ext_ids", string.Join(",", request.SupplierExternalIds));

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyPOISupplierQueryMatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/poi/supplier/sync 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/supplier-sync </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyPOISupplierSyncResponse> ExecuteOpenApiV1ThirdPartyPOISupplierSyncAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyPOISupplierSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "poi", "supplier", "sync")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyPOISupplierSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/supplier/query 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/supplier-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyPOISupplierQueryResponse> ExecuteOpenApiV1ThirdPartyPOISupplierQueryAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyPOISupplierQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "poi", "supplier", "query")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("supplier_ext_id", request.SupplierExternalId);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyPOISupplierQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/base/query/amap 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/tp/supplier-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1ThirdPartyPOIBaseQueryAMapResponse> ExecuteOpenApiV1ThirdPartyPOIBaseQueryAMapAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1ThirdPartyPOIBaseQueryAMapRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "poi", "base", "query", "amap")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("amap_id", request.AMapId);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1ThirdPartyPOIBaseQueryAMapResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MicroApp
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/code2session 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/session </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppCode2SessionResponse> ExecuteOpenApiV1MicroAppCode2SessionAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppCode2SessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "code2session")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("anonymous_code", request.AnoymousCode);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppCode2SessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/upload_material 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/uploadMaterial </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppUploadMaterialResponse> ExecuteOpenApiV1MicroAppUploadMaterialAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppUploadMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.MaterialFileName == null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + (request.MaterialType == 8 ? ".pdf" : ".jpg");

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "upload_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.MaterialFileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"material_file\"", $"\"{HttpUtility.UrlEncode(request.MaterialFileName)}\"");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentLength = request.MaterialFileBytes?.Length;

            return await client.SendRequestAsync<Models.OpenApiV1MicroAppUploadMaterialResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
