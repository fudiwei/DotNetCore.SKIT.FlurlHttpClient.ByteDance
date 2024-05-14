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

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/global_products 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509de61bace3e02b7489cba ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCreateGlobalProductResponse> ExecuteProductCreateGlobalProductAsync(this TikTokShopClient client, Models.ProductCreateGlobalProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "global_products");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductCreateGlobalProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/global_products/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/65854fa5a46cdd02bcbd0a18 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSearchGlobalProductsResponse> ExecuteProductSearchGlobalProductsAsync(this TikTokShopClient client, Models.ProductSearchGlobalProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "global_products", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductSearchGlobalProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/global_products/{global_product_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509e2b0bace3e02b7490c96 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetGlobalProductDetailResponse> ExecuteProductGetGlobalProductDetailAsync(this TikTokShopClient client, Models.ProductGetGlobalProductDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "global_products");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetGlobalProductDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/global_products/{global_product_id}/publish 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a64d6defece02be678fd6 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductPublishGlobalProductResponse> ExecuteProductPublishGlobalProductAsync(this TikTokShopClient client, Models.ProductPublishGlobalProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "global_products", request.ProductId, "publish");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductPublishGlobalProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /product/{version}/global_products/{global_product_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509e1bcc16ffe02b8dc3cd7 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateGlobalProductResponse> ExecuteProductUpdateGlobalProductAsync(this TikTokShopClient client, Models.ProductUpdateGlobalProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "product", request.ApiVersion, "global_products", request.ProductId);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductUpdateGlobalProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/global_products/{global_product_id}/inventory/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a64d6defece02be678fd6 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateGlobalProductInventoryResponse> ExecuteProductUpdateGlobalProductInventoryAsync(this TikTokShopClient client, Models.ProductUpdateGlobalProductInventoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "global_products", request.ProductId, "inventory", "update");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductUpdateGlobalProductInventoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /product/{version}/global_products 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a116fdefece02be5ebbb6 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeleteGlobalProductsResponse> ExecuteProductDeleteGlobalProductsAsync(this TikTokShopClient client, Models.ProductDeleteGlobalProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "product", request.ApiVersion, "global_products");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductDeleteGlobalProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
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

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6502fc8da57708028b42b18a ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCreateProductResponse> ExecuteProductCreateProductAsync(this TikTokShopClient client, Models.ProductCreateProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductCreateProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/listing_check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a0ee8f1fd3102b91c6493 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCreateProductListingCheckResponse> ExecuteProductCreateProductListingCheckAsync(this TikTokShopClient client, Models.ProductCreateProductListingCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", "listing_check");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductCreateProductListingCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/65854ffb8f559302d8a6acda ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSearchProductsResponse> ExecuteProductSearchProductsAsync(this TikTokShopClient client, Models.ProductSearchProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductSearchProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/products/{product_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509d85b4a0bb702c057fdda ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetProductDetailResponse> ExecuteProductGetProductDetailAsync(this TikTokShopClient client, Models.ProductGetProductDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "products", request.ProductId);

            if (request.IsReturnUnderReviewVersion is not null)
                flurlReq.SetQueryParam("return_under_review_version", request.IsReturnUnderReviewVersion.Value ? "true" : "false");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetProductDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /product/{version}/products/{product_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509da7d0fcef602bf1caddf ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateProductResponse> ExecuteProductUpdateProductAsync(this TikTokShopClient client, Models.ProductUpdateProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "product", request.ApiVersion, "products", request.ProductId);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductUpdateProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/{product_id}/partial_edit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a98d74a0bb702c06c3289 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateProductPartialResponse> ExecuteProductUpdateProductPartialAsync(this TikTokShopClient client, Models.ProductUpdateProductPartialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", request.ProductId, "partial_edit");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductUpdateProductPartialResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/{product_id}/inventory/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6503068fc20ad60284b38858 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateProductInventoryResponse> ExecuteProductUpdateProductInventoryAsync(this TikTokShopClient client, Models.ProductUpdateProductInventoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", request.ProductId, "inventory", "update");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductUpdateProductInventoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/{product_id}/prices/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650307de5a12ff0294eac8b0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateProductPriceResponse> ExecuteProductUpdateProductPriceAsync(this TikTokShopClient client, Models.ProductUpdateProductPriceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", request.ProductId, "prices", "update");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductUpdateProductPriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/activate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650306ff5a12ff0294eab4a9 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductActivateProductsResponse> ExecuteProductActivateProductsAsync(this TikTokShopClient client, Models.ProductActivateProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", "activate");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductActivateProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/deactivate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509de450fcef602bf1d087c ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeactivateProductsResponse> ExecuteProductDeactivateProductsAsync(this TikTokShopClient client, Models.ProductDeactivateProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", "deactivate");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductDeactivateProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /product/{version}/products 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6503079ebb2a4d028d515acf ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeleteProductsResponse> ExecuteProductDeleteProductsAsync(this TikTokShopClient client, Models.ProductDeleteProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "product", request.ApiVersion, "products");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductDeleteProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/products/recover 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509df0ebace3e02b748ac72 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRecoverProductsResponse> ExecuteProductRecoverProductsAsync(this TikTokShopClient client, Models.ProductRecoverProductsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "products", "recover");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductRecoverProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/{version}/inventory/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a9191c16ffe02b8eec161 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetInventoriesResponse> ExecuteProductGetInventoriesAsync(this TikTokShopClient client, Models.ProductGetInventoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "product", request.ApiVersion, "search", "inventory");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetInventoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/prerequisites 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6571ae94c5524602c081d0bb ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetPrerequisitesResponse> ExecuteProductGetPrerequisitesAsync(this TikTokShopClient client, Models.ProductGetPrerequisitesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "prerequisites");

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetPrerequisitesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /product/{version}/listing_schemas 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/65b0caabb943c102df5843ab ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetListingSchemasResponse> ExecuteProductGetListingSchemasAsync(this TikTokShopClient client, Models.ProductGetListingSchemasRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "product", request.ApiVersion, "listing_schemas")
                .SetQueryParam("category_ids", $"[{string.Join(",", request.CategoryIdList)}]")
                .SetQueryParam("locale", request.Locale);

            return await client.SendFlurlRequesAsJsontAsync<Models.ProductGetListingSchemasResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
