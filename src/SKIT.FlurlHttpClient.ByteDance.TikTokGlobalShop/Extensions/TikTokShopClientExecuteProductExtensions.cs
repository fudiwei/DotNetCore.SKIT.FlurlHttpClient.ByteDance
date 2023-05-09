using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteProductExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /products/search 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262788 </para>
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
                .CreateRequest(request, HttpMethod.Post, "products", "search");

            return await client.SendRequestWithJsonAsync<Models.ProductSearchProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/details 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262789 </para>
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
                .CreateRequest(request, HttpMethod.Get, "products", "details")
                .SetQueryParam("product_id", request.ProductId);

            if (request.RequireAuditVersion != null)
                flurlReq.SetQueryParam("need_audit_version", request.RequireAuditVersion.Value ? "true" : "false");

            return await client.SendRequestWithJsonAsync<Models.ProductGetProductDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262784 </para>
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
                .CreateRequest(request, HttpMethod.Post, "products");

            return await client.SendRequestWithJsonAsync<Models.ProductCreateProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /products 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262784 </para>
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
                .CreateRequest(request, HttpMethod.Put, "products");

            return await client.SendRequestWithJsonAsync<Models.ProductUpdateProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /products/stocks 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262787 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUpdateProductStockResponse> ExecuteProductUpdateProductStockAsync(this TikTokShopClient client, Models.ProductUpdateProductStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, "products", "stocks");

            return await client.SendRequestWithJsonAsync<Models.ProductUpdateProductStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /products/prices 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262793 </para>
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
                .CreateRequest(request, HttpMethod.Put, "products", "prices");

            return await client.SendRequestWithJsonAsync<Models.ProductUpdateProductPriceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /products 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262785 </para>
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
                .CreateRequest(request, HttpMethod.Delete, "products");

            return await client.SendRequestWithJsonAsync<Models.ProductDeleteProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/recover 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262792 </para>
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
                .CreateRequest(request, HttpMethod.Post, "products", "recover");

            return await client.SendRequestWithJsonAsync<Models.ProductRecoverProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/activate 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262791 </para>
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
                .CreateRequest(request, HttpMethod.Post, "products", "activate");

            return await client.SendRequestWithJsonAsync<Models.ProductActivateProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/inactivated_products 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262790 </para>
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
                .CreateRequest(request, HttpMethod.Post, "products", "inactivated_products");

            return await client.SendRequestWithJsonAsync<Models.ProductDeactivateProductsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/save_draft 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262808 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSaveProductDraftResponse> ExecuteProductSaveProductDraftAsync(this TikTokShopClient client, Models.ProductSaveProductDraftRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "products", "save_draft");

            return await client.SendRequestWithJsonAsync<Models.ProductSaveProductDraftResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Upload
        /// <summary>
        /// <para>异步调用 [POST] /products/upload_files 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262782 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUploadFileResponse> ExecuteProductUploadFileAsync(this TikTokShopClient client, Models.ProductUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "products", "upload_files");

            return await client.SendRequestWithJsonAsync<Models.ProductUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/upload_imgs 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262783 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductUploadImageResponse> ExecuteProductUploadImageAsync(this TikTokShopClient client, Models.ProductUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "products", "upload_imgs");

            return await client.SendRequestWithJsonAsync<Models.ProductUploadImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Category
        /// <summary>
        /// <para>异步调用 [GET] /products/categories 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262794 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetCategoryListResponse> ExecuteProductGetCategoryListAsync(this TikTokShopClient client, Models.ProductGetCategoryListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "categories");

            return await client.SendRequestWithJsonAsync<Models.ProductGetCategoryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/brands 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262795 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetBrandListResponse> ExecuteProductGetBrandListAsync(this TikTokShopClient client, Models.ProductGetBrandListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "brands")
                .SetQueryParam("page_number", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize);

            if (request.CategoryId != null)
                flurlReq.SetQueryParam("category_id", request.CategoryId);

            if (request.IsOnlyAuthorized != null)
                flurlReq.SetQueryParam("only_authorized", request.IsOnlyAuthorized.Value ? "true" : "false");

            if (request.BrandSuggest != null)
                flurlReq.SetQueryParam("brand_suggest", request.BrandSuggest);

            return await client.SendRequestWithJsonAsync<Models.ProductGetBrandListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/brand 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/275824 </para>
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
                .CreateRequest(request, HttpMethod.Post, "products", "brand");

            return await client.SendRequestWithJsonAsync<Models.ProductCreateBrandResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/attributes 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262796 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetAttributeListResponse> ExecuteProductGetAttributeListAsync(this TikTokShopClient client, Models.ProductGetAttributeListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "attributes")
                .SetQueryParam("category_id", request.CategoryId);

            return await client.SendRequestWithJsonAsync<Models.ProductGetAttributeListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/categories/rules 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262797 </para>
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
                .CreateRequest(request, HttpMethod.Get, "products", "categories", "rules")
                .SetQueryParam("category_id", request.CategoryId);

            return await client.SendRequestWithJsonAsync<Models.ProductGetCategoryRulesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/category_recommend 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262806 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductRecommendCategoryResponse> ExecuteProductRecommendCategoryAsync(this TikTokShopClient client, Models.ProductRecommendCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "category_recommend");

            return await client.SendRequestWithJsonAsync<Models.ProductRecommendCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
