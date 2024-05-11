using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteProductExtensions
    {
        #region Brand
        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/brands 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6503075656e2bb0289dd5d01 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetBrandsResponse> ExecuteProductGetBrandsAsync(this TikTokShopClient client, Models.ProductGetBrandsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "brands")
                .SetQueryParam("category_id", request.CategoryId)
                .SetQueryParam("brand_name", request.BrandName)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            if (request.IsAuthorized is not null)
                flurlReq.SetQueryParam("is_authorized", request.IsAuthorized.Value ? "true" : "false");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetBrandsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/brands 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a0926f1fd3102b91bbfb0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCreateBrandResponse> ExecuteProductCreateBrandAsync(this TikTokShopClient client, Models.ProductCreateBrandRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "brands");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductCreateBrandResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Category
        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6503075656e2bb0289dd5d01 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetCategoriesResponse> ExecuteProductGetCategoriesAsync(this TikTokShopClient client, Models.ProductGetCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "categories")
                .SetQueryParam("locale", request.Locale);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/categories/{category_id}/rules 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6503075656e2bb0289dd5d01 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetCategoryRulesResponse> ExecuteProductGetCategoryRulesAsync(this TikTokShopClient client, Models.ProductGetCategoryRulesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "categories", request.CategoryId, "rules");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetCategoryRulesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/categories/{category_id}/attributes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509c5784a0bb702c0561cc8 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetCategoryAttributesResponse> ExecuteProductGetCategoryAttributesAsync(this TikTokShopClient client, Models.ProductGetCategoryAttributesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "categories", request.CategoryId, "attributes")
                .SetQueryParam("locale", request.Locale);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetCategoryAttributesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/categories/recommend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509bae1f1fd3102b91379d4 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRecommendCategoriesResponse> ExecuteProductRecommendCategoriesAsync(this TikTokShopClient client, Models.ProductRecommendCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "categories", "recommend");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductRecommendCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Global
        #region Global/Category
        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/global_categories 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a03f8f1fd3102b91b338a ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetGlobalCategoriesResponse> ExecuteProductGetGlobalCategoriesAsync(this TikTokShopClient client, Models.ProductGetGlobalCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "global_categories")
                .SetQueryParam("locale", request.Locale);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetGlobalCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/categories/{category_id}/global_rules 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a056df1fd3102b91b5b8e ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetGlobalCategoryRulesResponse> ExecuteProductGetGlobalCategoryRulesAsync(this TikTokShopClient client, Models.ProductGetGlobalCategoryRulesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "categories", request.CategoryId, "global_rules");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetGlobalCategoryRulesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/categories/{category_id}/global_attributes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a0483c16ffe02b8dfc80a ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetGlobalCategoryAttributesResponse> ExecuteProductGetGlobalCategoryAttributesAsync(this TikTokShopClient client, Models.ProductGetGlobalCategoryAttributesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "categories", request.CategoryId, "global_attributes")
                .SetQueryParam("locale", request.Locale);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetGlobalCategoryAttributesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/global_categories/recommend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a9354f1fd3102b92a853b ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRecommendGlobalCategoriesResponse> ExecuteProductRecommendGlobalCategoriesAsync(this TikTokShopClient client, Models.ProductRecommendGlobalCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "global_categories", "recommend");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductRecommendGlobalCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Upload
        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/images/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509df95defece02be598a22 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUploadImageResponse> ExecuteProductUploadImageAsync(this TikTokShopClient client, Models.ProductUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.ImageFileName) ?? "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "images", "upload");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "data");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.UseCase)), "use_case");

            return await client.SendFlurlRequestAsync<Models.ProductUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/files/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509dffdc16ffe02b8dc10c5 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUploadFileResponse> ExecuteProductUploadFileAsync(this TikTokShopClient client, Models.ProductUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower();

            if (request.FileContentType is null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForFile(request.FileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "files", "upload");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "data");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.FileName)), "name");

            return await client.SendFlurlRequestAsync<Models.ProductUploadFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
