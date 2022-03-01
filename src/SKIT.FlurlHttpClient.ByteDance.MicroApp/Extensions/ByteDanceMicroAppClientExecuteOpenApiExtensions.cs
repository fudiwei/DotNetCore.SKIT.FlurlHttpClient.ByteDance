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

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/upload 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/upload </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageUploadResponse> ExecuteOpenApiV1MicroAppPackageUploadAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "upload")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/package/audit_hosts 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/audit-hosts </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageAuditHostsResponse> ExecuteOpenApiV1MicroAppPackageAuditHostsAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageAuditHostsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "package", "audit_hosts")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageAuditHostsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/audit 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/audit </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageAuditResponse> ExecuteOpenApiV1MicroAppPackageAuditAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "audit")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/revoke_audit 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/revoke-audit </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageRevokeAuditResponse> ExecuteOpenApiV1MicroAppPackageRevokeAuditAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageRevokeAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "revoke_audit")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageRevokeAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/release 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/revoke-audit </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageReleaseResponse> ExecuteOpenApiV1MicroAppPackageReleaseAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageReleaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "release")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageReleaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/rollback 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/rollback </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageRollbackResponse> ExecuteOpenApiV1MicroAppPackageRollbackAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageRollbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "rollback")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageRollbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/package/versions 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/package-management/versions </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppPackageVersionsResponse> ExecuteOpenApiV1MicroAppPackageVersionsAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppPackageVersionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "package", "versions")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppPackageVersionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/info 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/setting </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppInfoResponse> ExecuteOpenApiV1MicroAppAppInfoAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "info")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/qrcode 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/qrcode </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppQrcodeResponse> ExecuteOpenApiV1MicroAppAppQrcodeAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "qrcode")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/check_app_name 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/check-name </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppCheckAppNameResponse> ExecuteOpenApiV1MicroAppAppCheckAppNameAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppCheckAppNameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "check_app_name")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken)
                .SetQueryParam("app_name", request.AppName);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppCheckAppNameResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_app_name 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/name </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppModifyAppNameResponse> ExecuteOpenApiV1MicroAppAppModifyAppNameAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppModifyAppNameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_app_name")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppModifyAppNameResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_app_intro 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/intro </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppModifyAppIntroductionResponse> ExecuteOpenApiV1MicroAppAppModifyAppIntroductionAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppModifyAppIntroductionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_app_intro")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppModifyAppIntroductionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_app_icon 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/icon </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppModifyAppIconResponse> ExecuteOpenApiV1MicroAppAppModifyAppIconAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppModifyAppIconRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_app_icon")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppModifyAppIconResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/all_categories 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/all-categories </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppAllCategoriesResponse> ExecuteOpenApiV1MicroAppAppAllCategoriesAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppAllCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "all_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppAllCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/categories 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/category-audit-info </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppCategoriesResponse> ExecuteOpenApiV1MicroAppAppCategoriesAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/add_categories 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/add-category </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppAddCategoriesResponse> ExecuteOpenApiV1MicroAppAppAddCategoriesAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppAddCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "add_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppAddCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/del_categories 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/delete-category </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppDeleteCategoriesResponse> ExecuteOpenApiV1MicroAppAppDeleteCategoriesAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppDeleteCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "del_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppDeleteCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/supply_categories 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/supply-category </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppSupplyCategoriesResponse> ExecuteOpenApiV1MicroAppAppSupplyCategoriesAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppSupplyCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "supply_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppSupplyCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_server_domain 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/sever </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppModifyServerDomainResponse> ExecuteOpenApiV1MicroAppAppModifyServerDomainAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppModifyServerDomainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_server_domain")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppModifyServerDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_webview_domain 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/webview </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppModifyWebviewDomainResponse> ExecuteOpenApiV1MicroAppAppModifyWebviewDomainAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppModifyWebviewDomainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_webview_domain")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppModifyWebviewDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/quality_rating 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/quality-rating </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppQualityRatingResponse> ExecuteOpenApiV1MicroAppAppQualityRatingAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppQualityRatingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "quality_rating")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppQualityRatingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/credit_score 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/credit-score </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppAppCreditScoreResponse> ExecuteOpenApiV1MicroAppAppCreditScoreAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppAppCreditScoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "credit_score")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppAppCreditScoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/video_application_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/operation/video-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppOperationVideoApplicationStatusResponse> ExecuteOpenApiV1MicroAppOperationVideoApplicationStatusAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppOperationVideoApplicationStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "video_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppOperationVideoApplicationStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/video_application 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/operation/video-application </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppOperationVideoApplicationResponse> ExecuteOpenApiV1MicroAppOperationVideoApplicationAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppOperationVideoApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "video_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppOperationVideoApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/live_application_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/operation/live-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppOperationLiveApplicationStatusResponse> ExecuteOpenApiV1MicroAppOperationLiveApplicationStatusAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppOperationLiveApplicationStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "live_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppOperationLiveApplicationStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/live_application 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/operation/live-application </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppOperationLiveApplicationResponse> ExecuteOpenApiV1MicroAppOperationLiveApplicationAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppOperationLiveApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "live_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppOperationLiveApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/phone_number_application_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/operation/phone-number-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppOperationPhoneNumberApplicationStatusResponse> ExecuteOpenApiV1MicroAppOperationPhoneNumberApplicationStatusAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppOperationPhoneNumberApplicationStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "phone_number_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppOperationPhoneNumberApplicationStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/phone_number_application 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/auth-app/operation/phone-number-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiV1MicroAppOperationPhoneNumberApplicationResponse> ExecuteOpenApiV1MicroAppOperationPhoneNumberApplicationAsync(this ByteDanceMicroAppClient client, Models.OpenApiV1MicroAppOperationPhoneNumberApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "phone_number_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiV1MicroAppOperationPhoneNumberApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
