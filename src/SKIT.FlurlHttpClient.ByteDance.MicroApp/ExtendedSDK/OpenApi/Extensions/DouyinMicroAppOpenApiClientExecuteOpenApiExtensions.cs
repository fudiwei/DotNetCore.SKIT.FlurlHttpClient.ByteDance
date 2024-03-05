using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteOpenApiExtensions
    {
        #region Auth
        /// <summary>
        /// <para>异步调用 [GET] /v1/auth/tp/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/componentaccesstoken ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthThirdPartyTokenV1Response> ExecuteOpenApiAuthThirdPartyTokenV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthThirdPartyTokenV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppSecret is null)
                request.ComponentAppSecret = client.Credentials.ComponentAppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "auth", "tp", "token")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_appsecret", request.ComponentAppSecret)
                .SetQueryParam("component_ticket", request.ComponentTicket);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthThirdPartyTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/auth/pre_auth_code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/preauthcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthPreAuthCodeV2Response> ExecuteOpenApiAuthPreAuthCodeV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthPreAuthCodeV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "auth", "pre_auth_code")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthPreAuthCodeV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/auth/gen_link 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/genlink ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthGenerateLinkV2Response> ExecuteOpenApiAuthGenerateLinkV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthGenerateLinkV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "auth", "gen_link")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthGenerateLinkV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/auth/retrieve 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/findauthorizationcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAuthRetrieveV1Response> ExecuteOpenApiAuthRetrieveV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiAuthRetrieveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "auth", "retrieve")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("authorization_appid", request.AuthorizerAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiAuthRetrieveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region OAuth
        /// <summary>
        /// <para>异步调用 [GET] /v1/oauth/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authorizeraccesstoken ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authorizerrefreshtoken ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiOAuthTokenV1Response> ExecuteOpenApiOAuthTokenV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiOAuthTokenV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "oauth", "token")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("grant_type", request.GrantType);

            if (request.AuthCode is not null)
                flurlReq.SetQueryParam("authorization_code", request.AuthCode);

            if (request.AuthorizerRefreshToken is not null)
                flurlReq.SetQueryParam("authorizer_refresh_token", request.AuthorizerRefreshToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiOAuthTokenV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ThirdParty
        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/auth_app_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/authapplist ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyAuthAppListV1Response> ExecuteOpenApiThirdPartyAuthAppListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyAuthAppListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "auth_app_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyAuthAppListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/tp/upload_pic_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/upload-pic-material ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyUploadPictureMaterialV1Response> ExecuteOpenApiThirdPartyUploadPictureMaterialV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyUploadPictureMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MaterialFileName is null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "upload_pic_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: "image/jpeg", formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");

            return await client.SendFlurlRequestAsync<Models.OpenApiThirdPartyUploadPictureMaterialV1Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ThirdParty/Domain
        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/download/webview_file 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/domain/download ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyDownloadWebviewFileV1Response> ExecuteOpenApiThirdPartyDownloadWebviewFileV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyDownloadWebviewFileV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "download", "webview_file")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyDownloadWebviewFileV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ThirdParty/POI
        /// <summary>
        /// <para>异步调用 [POST] /v1/tp/poi/supplier/match 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-match ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierMatchV1Response> ExecuteOpenApiThirdPartyPOISupplierMatchV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyPOISupplierMatchV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "poi", "supplier", "match")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOISupplierMatchV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/poi/supplier/query/match_task 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/query-match-task ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierQueryMatchTaskV1Response> ExecuteOpenApiThirdPartyPOISupplierQueryMatchTaskV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyPOISupplierQueryMatchTaskV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "poi", "supplier", "query", "match_task")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("task_ids", string.Join(",", request.TaskIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOISupplierQueryMatchTaskV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/poi/supplier/query/match 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-query-match ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierQueryMatchV1Response> ExecuteOpenApiThirdPartyPOISupplierQueryMatchV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyPOISupplierQueryMatchV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "poi", "supplier", "query", "match")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("supplier_ext_ids", string.Join(",", request.SupplierExternalIds));

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOISupplierQueryMatchV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/tp/poi/supplier/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-sync ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierSyncV1Response> ExecuteOpenApiThirdPartyPOISupplierSyncV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyPOISupplierSyncV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "poi", "supplier", "sync")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOISupplierSyncV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/poi/supplier/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOISupplierQueryV1Response> ExecuteOpenApiThirdPartyPOISupplierQueryV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyPOISupplierQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "poi", "supplier", "query")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("supplier_ext_id", request.SupplierExternalId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOISupplierQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/poi/base/query/amap 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/thirdparty/API/tp/supplier-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyPOIBaseQueryAMapV1Response> ExecuteOpenApiThirdPartyPOIBaseQueryAMapV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyPOIBaseQueryAMapV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "poi", "base", "query", "amap")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("amap_id", request.AMapId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOIBaseQueryAMapV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ThirdParty/Template
        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/template/get_tpl_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/tpl-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateGetTemplateListV1Response> ExecuteOpenApiThirdPartyTemplateGetTemplateListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateGetTemplateListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "template", "get_tpl_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateGetTemplateListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/template/get_draft_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/draft-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-12-28 下线。")]
        public static async Task<Models.OpenApiThirdPartyTemplateGetDraftListV1Response> ExecuteOpenApiThirdPartyTemplateGetDraftListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateGetDraftListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "template", "get_draft_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateGetDraftListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/tp/template/get_tpl_app_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/tpl-app-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateGetTemplateAppListV1Response> ExecuteOpenApiThirdPartyTemplateGetTemplateAppListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateGetTemplateAppListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "template", "get_tpl_app_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateGetTemplateAppListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/tp/template/add_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/add ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateAddTemplateV1Response> ExecuteOpenApiThirdPartyTemplateAddTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateAddTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "template", "add_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateAddTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/tp/template/del_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/delete ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiThirdPartyTemplateDeleteTemplateV1Response> ExecuteOpenApiThirdPartyTemplateDeleteTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateDeleteTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "template", "del_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateDeleteTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region MicroApp
        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/code2session 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/login/code2session ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppCode2SessionV1Response> ExecuteOpenApiMicroAppCode2SessionV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppCode2SessionV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "code2session")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("anonymous_code", request.AnoymousCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppCode2SessionV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/upload_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/uploadMaterial ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppUploadMaterialV1Response> ExecuteOpenApiMicroAppUploadMaterialV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppUploadMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MaterialFileName is null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + (request.MaterialType == 8 ? ".pdf" : ".jpg");

            if (request.MaterialFileContentType is null)
                request.MaterialFileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForMaterial(request.MaterialFileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "upload_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: request.MaterialFileContentType!, formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");

            return await client.SendFlurlRequestAsync<Models.OpenApiMicroAppUploadMaterialV1Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region MicroApp/App
        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/app/info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppInfoV1Response> ExecuteOpenApiMicroAppAppInfoV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "app", "info")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/qrcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppQrcodeV1Response> ExecuteOpenApiMicroAppAppQrcodeV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppQrcodeV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "qrcode")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppQrcodeV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/app/check_app_name 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/check-name ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppCheckAppNameV1Response> ExecuteOpenApiMicroAppAppCheckAppNameV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppCheckAppNameV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "app", "check_app_name")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken)
                .SetQueryParam("app_name", request.AppName);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppCheckAppNameV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/modify_app_name 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-name ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyAppNameV1Response> ExecuteOpenApiMicroAppAppModifyAppNameV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppModifyAppNameV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "modify_app_name")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppModifyAppNameV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/modify_app_intro 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-intro ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyAppIntroductionV1Response> ExecuteOpenApiMicroAppAppModifyAppIntroductionV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppModifyAppIntroductionV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "modify_app_intro")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppModifyAppIntroductionV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/modify_app_icon 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-icon ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyAppIconV1Response> ExecuteOpenApiMicroAppAppModifyAppIconV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppModifyAppIconV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "modify_app_icon")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppModifyAppIconV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/app/all_categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/all-categories ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppAllCategoriesV1Response> ExecuteOpenApiMicroAppAppAllCategoriesV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppAllCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "app", "all_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppAllCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/app/categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/category-audit-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppCategoriesV1Response> ExecuteOpenApiMicroAppAppCategoriesV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "app", "categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/add_categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/add-category ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppAddCategoriesV1Response> ExecuteOpenApiMicroAppAppAddCategoriesV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppAddCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "add_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppAddCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/del_categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/delete-category ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppDeleteCategoriesV1Response> ExecuteOpenApiMicroAppAppDeleteCategoriesV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppDeleteCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "del_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppDeleteCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/supply_categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/supply-category ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppSupplyCategoriesV1Response> ExecuteOpenApiMicroAppAppSupplyCategoriesV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppSupplyCategoriesV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "supply_categories")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppSupplyCategoriesV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/modify_server_domain 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-domain ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyServerDomainV1Response> ExecuteOpenApiMicroAppAppModifyServerDomainV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppModifyServerDomainV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "modify_server_domain")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppModifyServerDomainV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/app/modify_webview_domain 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-webview ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppModifyWebviewDomainV1Response> ExecuteOpenApiMicroAppAppModifyWebviewDomainV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppModifyWebviewDomainV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "app", "modify_webview_domain")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppModifyWebviewDomainV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/app/quality_rating 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/quality-rating ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppQualityRatingV1Response> ExecuteOpenApiMicroAppAppQualityRatingV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppQualityRatingV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "app", "quality_rating")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppQualityRatingV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/app/credit_score 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/credit-score ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppAppCreditScoreV1Response> ExecuteOpenApiMicroAppAppCreditScoreV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppAppCreditScoreV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "app", "credit_score")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppAppCreditScoreV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MicroApp/Operation
        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/operation/video_application_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/video-application-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationVideoApplicationStatusV1Response> ExecuteOpenApiMicroAppOperationVideoApplicationStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationVideoApplicationStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "operation", "video_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationVideoApplicationStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/video_application 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/video-application ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationVideoApplicationV1Response> ExecuteOpenApiMicroAppOperationVideoApplicationV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationVideoApplicationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "video_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationVideoApplicationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/operation/live_application_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/live-application-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationLiveApplicationStatusV1Response> ExecuteOpenApiMicroAppOperationLiveApplicationStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationLiveApplicationStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "operation", "live_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationLiveApplicationStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/live_application 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/live-application ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationLiveApplicationV1Response> ExecuteOpenApiMicroAppOperationLiveApplicationV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationLiveApplicationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "live_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationLiveApplicationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/operation/phone_number_application_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/phone-number-application-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationPhoneNumberApplicationStatusV1Response> ExecuteOpenApiMicroAppOperationPhoneNumberApplicationStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationPhoneNumberApplicationStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "operation", "phone_number_application_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationPhoneNumberApplicationStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/phone_number_application 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/phone-number-application ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationPhoneNumberApplicationV1Response> ExecuteOpenApiMicroAppOperationPhoneNumberApplicationV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationPhoneNumberApplicationV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "phone_number_application")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationPhoneNumberApplicationV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/operation/share_tpl_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/shareTplList ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationShareTemplateListV1Response> ExecuteOpenApiMicroAppOperationShareTemplateListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationShareTemplateListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "operation", "share_tpl_list")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationShareTemplateListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/add_share_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/addShareTpl ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationAddShareTemplateV1Response> ExecuteOpenApiMicroAppOperationAddShareTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationAddShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "add_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationAddShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/modify_share_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/modifyShareTpl ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationModifyShareTemplateV1Response> ExecuteOpenApiMicroAppOperationModifyShareTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationModifyShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "modify_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationModifyShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/del_share_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/delShareTpl ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationDeleteShareTemplateV1Response> ExecuteOpenApiMicroAppOperationDeleteShareTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationDeleteShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "del_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationDeleteShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/set_default_share_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/setDefaultShareTpl ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationSetDefaultShareTemplateV1Response> ExecuteOpenApiMicroAppOperationSetDefaultShareTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationSetDefaultShareTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "set_default_share_tpl")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationSetDefaultShareTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/operation/add_shop_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/add-shop-material ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationAddShopMaterialV1Response> ExecuteOpenApiMicroAppOperationAddShopMaterialV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationAddShopMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "operation", "add_shop_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationAddShopMaterialV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/operation/query_shop_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/query-shop-material ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppOperationQueryShopMaterialV1Response> ExecuteOpenApiMicroAppOperationQueryShopMaterialV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppOperationQueryShopMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "operation", "query_shop_material")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken)
                .SetQueryParam("supplier_ext_id", request.SupplierExternalId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppOperationQueryShopMaterialV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MicroApp/Package
        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/package/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/upload-code ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageUploadV1Response> ExecuteOpenApiMicroAppPackageUploadV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageUploadV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "package", "upload")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageUploadV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/package/audit_hosts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/audit-hosts ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageAuditHostsV1Response> ExecuteOpenApiMicroAppPackageAuditHostsV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageAuditHostsV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "package", "audit_hosts")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageAuditHostsV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/microapp/package/audit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/audit-code ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageAuditV2Response> ExecuteOpenApiMicroAppPackageAuditV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageAuditV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "microapp", "package", "audit")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageAuditV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/package/revoke_audit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/revoke-audit ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageRevokeAuditV1Response> ExecuteOpenApiMicroAppPackageRevokeAuditV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageRevokeAuditV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "package", "revoke_audit")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageRevokeAuditV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/package/release 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/release ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageReleaseV1Response> ExecuteOpenApiMicroAppPackageReleaseV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageReleaseV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "package", "release")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageReleaseV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/microapp/package/rollback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/rollback ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageRollbackV1Response> ExecuteOpenApiMicroAppPackageRollbackV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageRollbackV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "microapp", "package", "rollback")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageRollbackV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/microapp/package/versions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/versions ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiMicroAppPackageVersionsV1Response> ExecuteOpenApiMicroAppPackageVersionsV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiMicroAppPackageVersionsV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "microapp", "package", "versions")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("authorizer_access_token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiMicroAppPackageVersionsV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Settle
        /// <summary>
        /// <para>异步调用 [POST] /v1/settle/pre_check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/developer-settle/predict-check ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSettlePreCheckV1Response> ExecuteOpenApiSettlePreCheckV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiSettlePreCheckV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "settle", "pre_check")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiSettlePreCheckV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/settle/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/developer-settle/settle-apply ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSettleApplyV1Response> ExecuteOpenApiSettleApplyV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiSettleApplyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "settle", "apply")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiSettleApplyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/settle/get_apply_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/developer-settle/get-apply-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSettleGetApplyStatusV1Response> ExecuteOpenApiSettleGetApplyStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiSettleGetApplyStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "settle", "get_apply_status")
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("apply_id", request.ApplyId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiSettleGetApplyStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}