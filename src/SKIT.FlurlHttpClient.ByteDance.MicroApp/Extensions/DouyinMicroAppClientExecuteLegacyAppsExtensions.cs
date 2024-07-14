using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    using SKIT.FlurlHttpClient;

    public static class DouyinMicroAppClientExecuteLegacyAppsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v2/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/get-access-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/interface-request-credential/get-access-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/interface-request-credential/get-access-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTokenV2Response> ExecuteAppsTokenV2Async(this DouyinMicroAppClient client, Models.AppsTokenV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret is null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v2", "token")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v2", "token"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTokenV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v2/jscode2session 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/log-in/code-2-session ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/log-in/code-2-session ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/log-in/code-2-session ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsJsCode2SessionV2Response> ExecuteAppsJsCode2SessionV2Async(this DouyinMicroAppClient client, Models.AppsJsCode2SessionV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret is null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v2", "jscode2session")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v2", "jscode2session"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsJsCode2SessionV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Capacity
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/upload_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/upload-material ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityUploadMaterialV1Response> ExecuteAppsCapacityUploadMaterialV1Async(this DouyinMicroAppClient client, Models.AppsCapacityUploadMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MaterialFileName is null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.MaterialFileContentType is null)
                request.MaterialFileContentType = MimeTypes.GetMimeMapping(request.MaterialFileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "upload_material")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "upload_material"))
                .WithHeader("access-token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: request.MaterialFileContentType, formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");

            return await client.SendFlurlRequestAsync<Models.AppsCapacityUploadMaterialV1Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Capacity/ClueComponent
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/create_clue_component_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/clue-component-info/create ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityCreateClueComponentInfoV1Response> ExecuteAppsCapacityCreateClueComponentInfoV1Async(this DouyinMicroAppClient client, Models.AppsCapacityCreateClueComponentInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "create_clue_component_info")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "create_clue_component_info"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityCreateClueComponentInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_clue_component_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/clue-component-info/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryClueComponentInfoV1Response> ExecuteAppsCapacityQueryClueComponentInfoV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryClueComponentInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_clue_component_info")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "query_clue_component_info"))
                .WithHeader("access-token", request.AccessToken);

            if (request.PageNumber is not null)
                flurlReq.SetQueryParam("page_no", request.PageNumber.Value);

            if (request.PageSize is not null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryClueComponentInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/update_clue_component_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/clue-component-info/update ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityUpdateClueComponentInfoV1Response> ExecuteAppsCapacityUpdateClueComponentInfoV1Async(this DouyinMicroAppClient client, Models.AppsCapacityUpdateClueComponentInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "update_clue_component_info")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "update_clue_component_info"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityUpdateClueComponentInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /api/apps/v1/capacity/delete_clue_component_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/clue-component-info/delete ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityDeleteClueComponentInfoV1Response> ExecuteAppsCapacityDeleteClueComponentInfoV1Async(this DouyinMicroAppClient client, Models.AppsCapacityDeleteClueComponentInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "api", "apps", "v1", "capacity", "delete_clue_component_info")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "delete_clue_component_info"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityDeleteClueComponentInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Capacity/Doudian
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/bind_doudian_account 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/doudian-bind/bind-doudian-account ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityBindDoudianAccountV1Response> ExecuteAppsCapacityBindDoudianAccountV1Async(this DouyinMicroAppClient client, Models.AppsCapacityBindDoudianAccountV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "bind_doudian_account")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "bind_doudian_account"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityBindDoudianAccountV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_bind_doudian_account 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/doudian-bind/query-bind-doudian-account ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryBindDoudianAccountV1Response> ExecuteAppsCapacityQueryBindDoudianAccountV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryBindDoudianAccountV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_bind_doudian_account")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "query_bind_doudian_account"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryBindDoudianAccountV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/create_doudian_app 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/doudian-bind/create-doudian-app ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityCreateDoudianAppV1Response> ExecuteAppsCapacityCreateDoudianAppV1Async(this DouyinMicroAppClient client, Models.AppsCapacityCreateDoudianAppV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "create_doudian_app")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "create_doudian_app"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityCreateDoudianAppV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_doudian_app 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/doudian-bind/query-doudian-app ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryDoudianAppV1Response> ExecuteAppsCapacityQueryDoudianAppV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryDoudianAppV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_doudian_app")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "query_doudian_app"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryDoudianAppV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_doudian_shop_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/doudian-bind/query_doudian_shop_info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryDoudianShopInfoV1Response> ExecuteAppsCapacityQueryDoudianShopInfoV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryDoudianShopInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_doudian_shop_info")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "query_doudian_shop_info"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryDoudianShopInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Capacity/Mount
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/apply_capacity 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/apply-self-mount ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/apply-live-self-mount ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/apply-video-talent-mount ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/capcut-video-template/apply-capacity ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/page-layout-custom/apply-capacity ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityApplyCapacityV1Response> ExecuteAppsCapacityApplyCapacityV1Async(this DouyinMicroAppClient client, Models.AppsCapacityApplyCapacityV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "apply_capacity")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "apply_capacity"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityApplyCapacityV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_apply_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/query-video-self-mount ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/query-live-self-mount ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/query-video-talent-mount ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/capcut-video-template/query-status ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/page-layout-custom/query-capacity-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryApplyStatusV1Response> ExecuteAppsCapacityQueryApplyStatusV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryApplyStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_apply_status")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "capacity", "query_apply_status"))
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("capacity_key", request.CapacityKey);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryApplyStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Censor
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/censor/image 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/content-security/picture-detect-v2 ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/picture-detect ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCensorImageResponse> ExecuteAppsCensorImageAsync(this DouyinMicroAppClient client, Models.AppsCensorImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "censor", "image")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "censor", "image"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCensorImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region CustomerService
        /// <summary>
        /// <para>异步调用 [GET] /api/apps/customer_service/url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/customer-service ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCustomerServiceUrlResponse> ExecuteAppsCustomerServiceUrlAsync(this DouyinMicroAppClient client, Models.AppsCustomerServiceUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "customer_service", "url")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "customer_service", "url"))
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("scene", request.Scene);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCustomerServiceUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Chat
        /// <summary>
        /// <para>异步调用 [GET] /api/apps/chat/customer_service_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/im/customer-service-url ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-08-29 下线。")]
        public static async Task<Models.AppsChatCustomerServiceUrlResponse> ExecuteAppsChatCustomerServiceUrlAsync(this DouyinMicroAppClient client, Models.AppsChatCustomerServiceUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "chat", "customer_service_url")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "chat", "customer_service_url"))
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("scene", request.Scene);

            if (request.OrderId is not null)
                flurlReq.SetQueryParam("order_id", request.OrderId);

            if (request.IMType is not null)
                flurlReq.SetQueryParam("im_type", request.IMType);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsChatCustomerServiceUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Live
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/upload_live_image 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/live-bg-image ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsUploadLiveImageResponse> ExecuteAppsUploadLiveImageAsync(this DouyinMicroAppClient client, Models.AppsUploadLiveImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = MimeTypes.GetMimeMapping(request.ImageFileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "upload_live_image")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "upload_live_image"))
                .WithHeader("access-token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "image");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.Title)), "title");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.PagePath)), "start_page");
            if (request.RoomId is not null)
                httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.RoomId.Value.ToString())), "room_id");

            return await client.SendFlurlRequestAsync<Models.AppsUploadLiveImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/live/set_black_white_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/live-black-white-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsLiveSetBlackWhiteListV1Response> ExecuteAppsLiveSetBlackWhiteListV1Async(this DouyinMicroAppClient client, Models.AppsLiveSetBlackWhiteListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "live", "set_black_white_list")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "v1", "live", "set_black_white_list"))
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsLiveSetBlackWhiteListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Message
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/message/custom/send 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/component/message-push-customer-service#%E5%8F%91%E9%80%81%E5%AE%A2%E6%9C%8D%E6%B6%88%E6%81%AF%E6%8E%A5%E5%8F%A3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsMessageCustomSendResponse> ExecuteAppsMessageCustomSendAsync(this DouyinMicroAppClient client, Models.AppsMessageCustomSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "message", "custom", "send")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "message", "custom", "send"))
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsMessageCustomSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/order/v2/push 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/order/order-sync ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/payment/pushOrder ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsOrderPushV2Response> ExecuteAppsOrderPushV2Async(this DouyinMicroAppClient client, Models.AppsOrderPushV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "order", "v2", "push")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "order", "v2", "push"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsOrderPushV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/order/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/payment/deleteOrder ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsOrderDeleteResponse> ExecuteAppsOrderDeleteAsync(this DouyinMicroAppClient client, Models.AppsOrderDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "order", "delete")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "order", "delete"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsOrderDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/qr-code/create-qr-code ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/getqrcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsQrcodeResponse> ExecuteAppsQrcodeAsync(this DouyinMicroAppClient client, Models.AppsQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "qrcode")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "qrcode"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SubscribeNotification
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/subscribe_notification/developer/v1/notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/notify ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/subscribe-notification/notify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-12-27 下线。")]
        public static async Task<Models.AppsSubscribeNotificationDeveloperNotifyV1Response> ExecuteAppsSubscribeNotificationDeveloperNotifyV1Async(this DouyinMicroAppClient client, Models.AppsSubscribeNotificationDeveloperNotifyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "subscribe_notification", "developer", "v1", "notify")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "subscribe_notification", "developer", "v1", "notify"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsSubscribeNotificationDeveloperNotifyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ShareConfig
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/share_config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/mount/ShareConfig ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsShareConfigResponse> ExecuteAppsShareConfigAsync(this DouyinMicroAppClient client, Models.AppsShareConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "share_config")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "share_config"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsShareConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region TaskBox
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/taskbox/add_task 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/promote/taskbox/taskbox-task-upload ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-01-08 下线。")]
        public static async Task<Models.AppsTaskBoxAddTaskResponse> ExecuteAppsTaskBoxAddTaskAsync(this DouyinMicroAppClient client, Models.AppsTaskBoxAddTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "taskbox", "add_task")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "taskbox", "add_task"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTaskBoxAddTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/taskbox/update_task 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/promote/taskbox/updatetasks ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-01-08 下线。")]
        public static async Task<Models.AppsTaskBoxUpdateTaskResponse> ExecuteAppsTaskBoxUpdateTaskAsync(this DouyinMicroAppClient client, Models.AppsTaskBoxUpdateTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "taskbox", "update_task")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "taskbox", "update_task"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTaskBoxUpdateTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/taskbox/update/status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/promote/taskbox/updatetaskstatus ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-01-08 下线。")]
        public static async Task<Models.AppsTaskBoxUpdateStatusResponse> ExecuteAppsTaskBoxUpdateStatusAsync(this DouyinMicroAppClient client, Models.AppsTaskBoxUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "taskbox", "update", "status")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "taskbox", "update", "status"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTaskBoxUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/taskbox/query_app_task_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/promote/taskbox/taskbox-query-app-task-id ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-01-08 下线。")]
        public static async Task<Models.AppsTaskBoxQueryAppTaskIdResponse> ExecuteAppsTaskBoxQueryAppTaskIdAsync(this DouyinMicroAppClient client, Models.AppsTaskBoxQueryAppTaskIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "taskbox", "query_app_task_id")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "taskbox", "query_app_task_id"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTaskBoxQueryAppTaskIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/taskbox/query_task_video_data 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/promote/taskbox/taskbox-query-task-video-data ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-01-08 下线。")]
        public static async Task<Models.AppsTaskBoxQueryTaskVideoDataResponse> ExecuteAppsTaskBoxQueryTaskVideoDataAsync(this DouyinMicroAppClient client, Models.AppsTaskBoxQueryTaskVideoDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "taskbox", "query_task_video_data")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "taskbox", "query_task_video_data"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTaskBoxQueryTaskVideoDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/taskbox/update_orient_talents/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/promote/taskbox/updateorienttalent ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTaskBoxUpdateOrientTalentsResponse> ExecuteAppsTaskBoxUpdateOrientTalentsAsync(this DouyinMicroAppClient client, Models.AppsTaskBoxUpdateOrientTalentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "taskbox", "update_orient_talents/")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "taskbox", "update_orient_talents/"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTaskBoxUpdateOrientTalentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Video
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/convert_video_id/video_id_to_open_item_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/video-id-convert ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsConvertVideoIdToOpenItemIdResponse> ExecuteAppsConvertVideoIdToOpenItemIdAsync(this DouyinMicroAppClient client, Models.AppsConvertVideoIdToOpenItemIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.AccessKey is null)
                request.AccessKey = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "convert_video_id", "video_id_to_open_item_id")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "convert_video_id", "video_id_to_open_item_id"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsConvertVideoIdToOpenItemIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/convert_video_id/open_item_id_to_encrypt_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/video-id-convert ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsConvertOpenItemIdToEncryptIdResponse> ExecuteAppsConvertOpenItemIdToEncryptIdAsync(this DouyinMicroAppClient client, Models.AppsConvertOpenItemIdToEncryptIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AccessKey is null)
                request.AccessKey = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "convert_video_id", "open_item_id_to_encrypt_id")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "convert_video_id", "open_item_id_to_encrypt_id"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsConvertOpenItemIdToEncryptIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
