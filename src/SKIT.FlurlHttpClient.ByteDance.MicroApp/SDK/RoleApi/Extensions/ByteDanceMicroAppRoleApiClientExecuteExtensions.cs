using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Extensions
{
    public static class ByteDanceMicroAppRoleApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /upload_material 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/upload-qualification-materials </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUploadMaterialResponse> ExecuteAuthEntityUploadMaterialAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUploadMaterialRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.MaterialFileName == null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + (request.MaterialType == 1010 ? ".pdf" : ".jpg");

            if (request.MaterialFileContentType == null)
                request.MaterialFileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForMaterial(request.MaterialFileName);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "upload_material");

            using MultipartFormDataContent httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: request.MaterialFileContentType!, formDataName: "material_file");
            httpContent.Add(new StringContent(request.AppId), "appid");
            httpContent.Add(new StringContent(request.AccessToken!), "access_token");
            httpContent.Add(new StringContent(request.MaterialType.ToString()), "material_type");
            return await client.SendRequestAsync<Models.AuthEntityUploadMaterialResponse>(flurlReq, httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_entity_info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/query-entity-id </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityQueryEntityInfoResponse> ExecuteAuthEntityQueryEntityInfoAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityQueryEntityInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_entity_info");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityQueryEntityInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enable_mountscope 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/enable-mountscope </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityEnableMountScopeResponse> ExecuteAuthEntityEnableMountScopeAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityEnableMountScopeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enable_mountscope");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityEnableMountScopeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Auth
        /// <summary>
        /// <para>异步调用 [POST] /bypartner 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/partner-help-teacher-institution-join </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityByPartnerResponse> ExecuteAuthEntityByPartnerAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityByPartnerRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "bypartner");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityByPartnerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /byself 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/institution-partner-join </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityBySelfResponse> ExecuteAuthEntityBySelfAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityBySelfRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "byself");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityBySelfResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;
        }

        /// <summary>
        /// <para>异步调用 [POST] /get_basic_auth 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/query-basic-qualification </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityGetBasicAuthResponse> ExecuteAuthEntityGetBasicAuthAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityGetBasicAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_basic_auth");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityGetBasicAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /update_basic_auth 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/update-basic-qualification </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUpdateBasicAuthResponse> ExecuteAuthEntityUpdateBasicAuthAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUpdateBasicAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "update_basic_auth");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityUpdateBasicAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /get_class_auth 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/query-category-qualification </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityGetClassAuthResponse> ExecuteAuthEntityGetClassAuthAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityGetClassAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_class_auth");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityGetClassAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /update_class_auth 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/update-category-qualification </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUpdateClassAuthResponse> ExecuteAuthEntityUpdateClassAuthAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUpdateClassAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "update_class_auth");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityUpdateClassAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /add_class_auth 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/add-category-qualification </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityAddClassAuthResponse> ExecuteAuthEntityAddClassAuthAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityAddClassAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "add_class_auth");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityAddClassAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /get_audit_detail 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/get-audit-task-details </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityGetAuditDetailResponse> ExecuteAuthEntityGetAuditDetailAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityGetAuditDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_audit_detail");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityGetAuditDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Role
        /// <summary>
        /// <para>异步调用 [POST] /add_role 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/add-role </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityAddRoleResponse> ExecuteAuthEntityAddRoleAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityAddRoleRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "add_role");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityAddRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /bind_role 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/miniapp-binding-role </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUnbindRoleResponse> ExecuteAuthEntityBindRoleAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUnbindRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "bind_role");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityUnbindRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /unbind_role 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/miniapp-unbinding-role </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUnbindRoleResponse> ExecuteAuthEntityUnbindRoleAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUnbindRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "unbind_role");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityUnbindRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /get_bind_list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/query-miniapp-bound-role </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityGetBindListResponse> ExecuteAuthEntityGetBindListAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityGetBindListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_bind_list");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityGetBindListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /auth_role 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/role-authorization-miniapp </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityAuthRoleResponse> ExecuteAuthEntityAuthRoleAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityAuthRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "auth_role");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityAuthRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /un_auth_role 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/deauthorization-miniapp </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUnauthRoleResponse> ExecuteAuthEntityUnauthRoleAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUnauthRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "un_auth_role");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityUnauthRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /update_authletter 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/update-authorization-letter-of-miniapp </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityUpdateAuthLetterResponse> ExecuteAuthEntityUpdateAuthLetterAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityUpdateAuthLetterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "update_authletter");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityUpdateAuthLetterResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /get_appid_auth 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/query-authorization-applet </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityGetAppIdAuthResponse> ExecuteAuthEntityGetAppIdAuthAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityGetAppIdAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_appid_auth");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityGetAppIdAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MerchantCode
        /// <summary>
        /// <para>异步调用 [POST] /activate_merchantcode 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/merchant-account-activation </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityActivateMerchantCodeResponse> ExecuteAuthEntityActivateMerchantCodeAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityActivateMerchantCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "activate_merchantcode");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityActivateMerchantCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /query_merchantcode_status 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/query-merchant-account-activation-state </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthEntityQueryMerchantCodeStatusResponse> ExecuteAuthEntityQueryMerchantCodeStatusAsync(this ByteDanceMicroAppRoleApiClient client, Models.AuthEntityQueryMerchantCodeStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_merchantcode_status");

            return await client.SendRequestWithJsonAsync<Models.AuthEntityQueryMerchantCodeStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
