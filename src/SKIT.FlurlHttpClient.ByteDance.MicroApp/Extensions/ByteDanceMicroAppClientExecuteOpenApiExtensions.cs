using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteOpenApiExtensions
    {
        #region Auth
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/auth/tp/token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/authorization/access </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthThirdPartyTokenV1Response> ExecuteOpenApiAuthThirdPartyTokenV1Async(this ByteDanceMicroAppClient client, Models.OpenApiAuthThirdPartyTokenV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiAuthThirdPartyTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/auth/pre_auth_code 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/authorization/auth </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthPreAuthCodeV1Response> ExecuteOpenApiAuthPreAuthCodeV1Async(this ByteDanceMicroAppClient client, Models.OpenApiAuthPreAuthCodeV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiAuthPreAuthCodeV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v2/auth/pre_auth_code 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/authorization/auth </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthPreAuthCodeV2Response> ExecuteOpenApiAuthPreAuthCodeV2Async(this ByteDanceMicroAppClient client, Models.OpenApiAuthPreAuthCodeV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v2", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiAuthPreAuthCodeV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/auth/retrieve 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/authorization/find </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthRetrieveV1Response> ExecuteOpenApiAuthRetrieveV1Async(this ByteDanceMicroAppClient client, Models.OpenApiAuthRetrieveV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiAuthRetrieveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region OAuth
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/oauth/token 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/authorization/voucher </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/authorization/update </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiOAuthTokenV1Response> ExecuteOpenApiOAuthTokenV1Async(this ByteDanceMicroAppClient client, Models.OpenApiOAuthTokenV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiOAuthTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ThirdParty
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/template/get_tpl_list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/template/tpl-list </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateGetTemplateListV1Response> ExecuteOpenApiThirdPartyTemplateGetTemplateListV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyTemplateGetTemplateListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "template", "get_tpl_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyTemplateGetTemplateListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/template/get_draft_list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/template/draft-list </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateGetDraftListV1Response> ExecuteOpenApiThirdPartyTemplateGetDraftListV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyTemplateGetDraftListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "template", "get_draft_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyTemplateGetDraftListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/template/add_tpl 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/template/add </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateAddTemplateV1Response> ExecuteOpenApiThirdPartyTemplateAddTemplateV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyTemplateAddTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "template", "add_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyTemplateAddTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/template/del_tpl 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/template/delete </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateDeleteTemplateV1Response> ExecuteOpenApiThirdPartyTemplateDeleteTemplateV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyTemplateDeleteTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "template", "del_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyTemplateDeleteTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/download/webview_file 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/download </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyDownloadWebviewFileV1Response> ExecuteOpenApiThirdPartyDownloadWebviewFileV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyDownloadWebviewFileV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "tp", "download", "webview_file")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyDownloadWebviewFileV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/auth_app_list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/auth-app-list </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyAuthAppListV1Response> ExecuteOpenApiThirdPartyAuthAppListV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyAuthAppListV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyAuthAppListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/poi/supplier/match 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-match </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierMatchV1Response> ExecuteOpenApiThirdPartyPOISupplierMatchV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyPOISupplierMatchV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "poi", "supplier", "match")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyPOISupplierMatchV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/supplier/query/match_task 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/query-match-task </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierQueryMatchTaskV1Response> ExecuteOpenApiThirdPartyPOISupplierQueryMatchTaskV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyPOISupplierQueryMatchTaskV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyPOISupplierQueryMatchTaskV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/supplier/query/match 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-query-match </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierQueryMatchV1Response> ExecuteOpenApiThirdPartyPOISupplierQueryMatchV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyPOISupplierQueryMatchV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyPOISupplierQueryMatchV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/tp/poi/supplier/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-sync </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierSyncV1Response> ExecuteOpenApiThirdPartyPOISupplierSyncV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyPOISupplierSyncV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "tp", "poi", "supplier", "sync")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyPOISupplierSyncV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/supplier/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierQueryV1Response> ExecuteOpenApiThirdPartyPOISupplierQueryV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyPOISupplierQueryV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyPOISupplierQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/tp/poi/base/query/amap 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-query </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOIBaseQueryAMapV1Response> ExecuteOpenApiThirdPartyPOIBaseQueryAMapV1Async(this ByteDanceMicroAppClient client, Models.OpenApiThirdPartyPOIBaseQueryAMapV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiThirdPartyPOIBaseQueryAMapV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MicroApp
        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/code2session 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/session </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppCode2SessionV1Response> ExecuteOpenApiMicroAppCode2SessionV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppCode2SessionV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppCode2SessionV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/upload_material 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/uploadMaterial </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppUploadMaterialV1Response> ExecuteOpenApiMicroAppUploadMaterialV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppUploadMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.MaterialFileName == null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + (request.MaterialType == 8 ? ".pdf" : ".jpg");

            if (request.MaterialFileContentType == null)
                request.MaterialFileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForMaterial(request.MaterialFileName);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "upload_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: request.MaterialFileContentType!, formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");

            return await client.SendRequestAsync<Models.OpenApiMicroAppUploadMaterialV1Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/upload 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/upload </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageUploadV1Response> ExecuteOpenApiMicroAppPackageUploadV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageUploadV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "upload")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageUploadV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/package/audit_hosts 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/audit-hosts </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageAuditHostsV1Response> ExecuteOpenApiMicroAppPackageAuditHostsV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageAuditHostsV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "package", "audit_hosts")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageAuditHostsV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/audit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/audit </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageAuditV1Response> ExecuteOpenApiMicroAppPackageAuditV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageAuditV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "audit")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageAuditV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/revoke_audit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/revoke-audit </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageRevokeAuditV1Response> ExecuteOpenApiMicroAppPackageRevokeAuditV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageRevokeAuditV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "revoke_audit")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageRevokeAuditV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/release 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/revoke-audit </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageReleaseV1Response> ExecuteOpenApiMicroAppPackageReleaseV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageReleaseV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "release")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageReleaseV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/package/rollback 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/rollback </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageRollbackV1Response> ExecuteOpenApiMicroAppPackageRollbackV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageRollbackV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "package", "rollback")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageRollbackV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/package/versions 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/package-management/versions </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageVersionsV1Response> ExecuteOpenApiMicroAppPackageVersionsV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppPackageVersionsV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "package", "versions")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppPackageVersionsV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/setting </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppInfoV1Response> ExecuteOpenApiMicroAppAppInfoV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "info")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/qrcode 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/qrcode </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppQrcodeV1Response> ExecuteOpenApiMicroAppAppQrcodeV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppQrcodeV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "qrcode")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppQrcodeV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/check_app_name 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/check-name </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppCheckAppNameV1Response> ExecuteOpenApiMicroAppAppCheckAppNameV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppCheckAppNameV1Request request, CancellationToken cancellationToken = default)
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

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppCheckAppNameV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_app_name 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/name </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyAppNameV1Response> ExecuteOpenApiMicroAppAppModifyAppNameV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppModifyAppNameV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_app_name")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppModifyAppNameV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_app_intro 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/intro </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyAppIntroductionV1Response> ExecuteOpenApiMicroAppAppModifyAppIntroductionV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppModifyAppIntroductionV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_app_intro")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppModifyAppIntroductionV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_app_icon 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/icon </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyAppIconV1Response> ExecuteOpenApiMicroAppAppModifyAppIconV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppModifyAppIconV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_app_icon")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppModifyAppIconV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/all_categories 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/all-categories </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppAllCategoriesV1Response> ExecuteOpenApiMicroAppAppAllCategoriesV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppAllCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "all_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppAllCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/categories 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/category-audit-info </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppCategoriesV1Response> ExecuteOpenApiMicroAppAppCategoriesV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/add_categories 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/add-category </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppAddCategoriesV1Response> ExecuteOpenApiMicroAppAppAddCategoriesV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppAddCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "add_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppAddCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/del_categories 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/delete-category </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppDeleteCategoriesV1Response> ExecuteOpenApiMicroAppAppDeleteCategoriesV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppDeleteCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "del_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppDeleteCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/supply_categories 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/supply-category </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppSupplyCategoriesV1Response> ExecuteOpenApiMicroAppAppSupplyCategoriesV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppSupplyCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "supply_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppSupplyCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_server_domain 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/sever </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyServerDomainV1Response> ExecuteOpenApiMicroAppAppModifyServerDomainV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppModifyServerDomainV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_server_domain")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppModifyServerDomainV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/app/modify_webview_domain 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/webview </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyWebviewDomainV1Response> ExecuteOpenApiMicroAppAppModifyWebviewDomainV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppModifyWebviewDomainV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "app", "modify_webview_domain")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppModifyWebviewDomainV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/quality_rating 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/quality-rating </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppQualityRatingV1Response> ExecuteOpenApiMicroAppAppQualityRatingV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppQualityRatingV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "quality_rating")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppQualityRatingV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/app/credit_score 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/miniprogram-setting/credit-score </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppCreditScoreV1Response> ExecuteOpenApiMicroAppAppCreditScoreV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppAppCreditScoreV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "app", "credit_score")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppAppCreditScoreV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/video_application_status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/video-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationVideoApplicationStatusV1Response> ExecuteOpenApiMicroAppOperationVideoApplicationStatusV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationVideoApplicationStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "video_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationVideoApplicationStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/video_application 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/video-application </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationVideoApplicationV1Response> ExecuteOpenApiMicroAppOperationVideoApplicationV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationVideoApplicationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "video_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationVideoApplicationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/live_application_status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/live-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationLiveApplicationStatusV1Response> ExecuteOpenApiMicroAppOperationLiveApplicationStatusV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationLiveApplicationStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "live_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationLiveApplicationStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/live_application 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/live-application </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationLiveApplicationV1Response> ExecuteOpenApiMicroAppOperationLiveApplicationV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationLiveApplicationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "live_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationLiveApplicationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/phone_number_application_status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/phone-number-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationPhoneNumberApplicationStatusV1Response> ExecuteOpenApiMicroAppOperationPhoneNumberApplicationStatusV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationPhoneNumberApplicationStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "phone_number_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationPhoneNumberApplicationStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/phone_number_application 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/phone-number-application-status </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationPhoneNumberApplicationV1Response> ExecuteOpenApiMicroAppOperationPhoneNumberApplicationV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationPhoneNumberApplicationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "phone_number_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationPhoneNumberApplicationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/share_tpl_list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/shareTplList </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationShareTemplateListV1Response> ExecuteOpenApiMicroAppOperationShareTemplateListV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationShareTemplateListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "share_tpl_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationShareTemplateListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/add_share_tpl 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/addShareTpl </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationAddShareTemplateV1Response> ExecuteOpenApiMicroAppOperationAddShareTemplateV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationAddShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "add_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationAddShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/modify_share_tpl 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/modifyShareTpl </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationModifyShareTemplateV1Response> ExecuteOpenApiMicroAppOperationModifyShareTemplateV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationModifyShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "modify_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationModifyShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/del_share_tpl 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/delShareTpl </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationDeleteShareTemplateV1Response> ExecuteOpenApiMicroAppOperationDeleteShareTemplateV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationDeleteShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "del_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationDeleteShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/set_default_share_tpl 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/setDefaultShareTpl </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationSetDefaultShareTemplateV1Response> ExecuteOpenApiMicroAppOperationSetDefaultShareTemplateV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationSetDefaultShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "set_default_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationSetDefaultShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/v1/microapp/operation/add_shop_material 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/add-shop-material </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationAddShopMaterialV1Response> ExecuteOpenApiMicroAppOperationAddShopMaterialV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationAddShopMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "v1", "microapp", "operation", "add_shop_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationAddShopMaterialV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /openapi/v1/microapp/operation/query_shop_material 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/auth-app/operation/query-shop-material </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="ByteDanceMicroAppClient" /> 时指定特殊的 <see cref="ByteDanceMicroAppClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationQueryShopMaterialV1Response> ExecuteOpenApiMicroAppOperationQueryShopMaterialV1Async(this ByteDanceMicroAppClient client, Models.OpenApiMicroAppOperationQueryShopMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "openapi", "v1", "microapp", "operation", "query_shop_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AccessToken)
                .SetQueryParam("supplier_ext_id", request.SupplierExternalId);

            return await client.SendRequestWithJsonAsync<Models.OpenApiMicroAppOperationQueryShopMaterialV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
