using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteMaterialExtensions
    {
        #region Material
        /// <summary>
        /// <para>异步调用 [POST] /material/searchMaterial 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/943 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialSearchMaterialResponse> ExecuteMaterialSearchMaterialAsync(this DouyinShopClient client, Models.MaterialSearchMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "searchMaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialSearchMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/queryMaterialDetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/950 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialQueryMaterialDetailResponse> ExecuteMaterialQueryMaterialDetailAsync(this DouyinShopClient client, Models.MaterialQueryMaterialDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "queryMaterialDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialQueryMaterialDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/editMaterial 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/956 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialEditMaterialResponse> ExecuteMaterialEditMaterialAsync(this DouyinShopClient client, Models.MaterialEditMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "editMaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialEditMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/deleteMaterial 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/944 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialDeleteMaterialResponse> ExecuteMaterialDeleteMaterialAsync(this DouyinShopClient client, Models.MaterialDeleteMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "deleteMaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialDeleteMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/moveMaterialToRecycleBin 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/951 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialMoveMaterialToRecyleBinResponse> ExecuteMaterialMoveMaterialToRecyleBinAsync(this DouyinShopClient client, Models.MaterialMoveMaterialToRecyleBinRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "moveMaterialToRecycleBin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialMoveMaterialToRecyleBinResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/recoverMaterial 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/954 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialRecoverMaterialResponse> ExecuteMaterialRecoverMaterialAsync(this DouyinShopClient client, Models.MaterialRecoverMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "recoverMaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialRecoverMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Folder
        /// <summary>
        /// <para>异步调用 [POST] /material/searchFolder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/952 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialSearchFolderResponse> ExecuteMaterialSearchFolderAsync(this DouyinShopClient client, Models.MaterialSearchFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "searchFolder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialSearchFolderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/getFolderInfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/953 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialGetFolderInformationResponse> ExecuteMaterialGetFolderInformationAsync(this DouyinShopClient client, Models.MaterialGetFolderInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "getFolderInfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialGetFolderInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/createFolder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/946 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialCreateFolderResponse> ExecuteMaterialCreateFolderAsync(this DouyinShopClient client, Models.MaterialCreateFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "createFolder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialCreateFolderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/editFolder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/948 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialEditFolderResponse> ExecuteMaterialEditFolderAsync(this DouyinShopClient client, Models.MaterialEditFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "editFolder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialEditFolderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/deleteFolder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/945 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialDeleteFolderResponse> ExecuteMaterialDeleteFolderAsync(this DouyinShopClient client, Models.MaterialDeleteFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "deleteFolder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialDeleteFolderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/moveFolderToRecycleBin 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/947 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialMoveFolderToRecyleBinResponse> ExecuteMaterialMoveFolderToRecyleBinAsync(this DouyinShopClient client, Models.MaterialMoveFolderToRecyleBinRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "moveFolderToRecycleBin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialMoveFolderToRecyleBinResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/recoverFolder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/1096 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialRecoverFolderResponse> ExecuteMaterialRecoverFolderAsync(this DouyinShopClient client, Models.MaterialRecoverFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "recoverFolder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialRecoverFolderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [POST] /material/uploadVideoAsync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/949 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialUploadVideoAsyncResponse> ExecuteMaterialUploadVideoAsyncAsync(this DouyinShopClient client, Models.MaterialUploadVideoAsyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "uploadVideoAsync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialUploadVideoAsyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /material/uploadImageSync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/69/955 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MaterialUploadImageSyncResponse> ExecuteMaterialUploadImageSyncAsync(this DouyinShopClient client, Models.MaterialUploadImageSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "material", "uploadImageSync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MaterialUploadImageSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
