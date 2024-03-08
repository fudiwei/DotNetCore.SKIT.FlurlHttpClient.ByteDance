using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteLegacyThirdPartyExtensions
    {
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "auth_app_list"))
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
        [Obsolete("相关接口或字段于 2024-01-23 下线。")]
        public static async Task<Models.OpenApiThirdPartyUploadPictureMaterialV1Response> ExecuteOpenApiThirdPartyUploadPictureMaterialV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyUploadPictureMaterialV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MaterialFileName is null)
                request.MaterialFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "upload_pic_material")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "upload_pic_material"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MaterialFileName, fileBytes: request.MaterialFileBytes, fileContentType: "image/jpeg", formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");

            return await client.SendFlurlRequestAsync<Models.OpenApiThirdPartyUploadPictureMaterialV1Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Domain
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "download", "webview_file"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyDownloadWebviewFileV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region POI
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "poi", "supplier", "match"))
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "poi", "supplier", "query", "match_task"))
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "poi", "supplier", "query", "match"))
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "poi", "supplier", "sync"))
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "poi", "supplier", "query"))
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
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "poi", "base", "query", "amap"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("amap_id", request.AMapId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyPOIBaseQueryAMapV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Template
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
        [Obsolete("相关接口或字段于 2024-01-23 下线。")]
        public static async Task<Models.OpenApiThirdPartyTemplateGetTemplateListV1Response> ExecuteOpenApiThirdPartyTemplateGetTemplateListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateGetTemplateListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "template", "get_tpl_list")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "template", "get_tpl_list"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateGetTemplateListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        [Obsolete("相关接口或字段于 2024-01-23 下线。")]
        public static async Task<Models.OpenApiThirdPartyTemplateGetTemplateAppListV1Response> ExecuteOpenApiThirdPartyTemplateGetTemplateAppListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateGetTemplateAppListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "tp", "template", "get_tpl_app_list")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "template", "get_tpl_app_list"))
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
        [Obsolete("相关接口或字段于 2024-01-23 下线。")]
        public static async Task<Models.OpenApiThirdPartyTemplateAddTemplateV1Response> ExecuteOpenApiThirdPartyTemplateAddTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateAddTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "template", "add_tpl")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "template", "add_tpl"))
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
        [Obsolete("相关接口或字段于 2024-01-23 下线。")]
        public static async Task<Models.OpenApiThirdPartyTemplateDeleteTemplateV1Response> ExecuteOpenApiThirdPartyTemplateDeleteTemplateV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiThirdPartyTemplateDeleteTemplateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "tp", "template", "del_tpl")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "tp", "template", "del_tpl"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiThirdPartyTemplateDeleteTemplateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
