using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteProductsExtensions
    {
        #region Upload
        /// <summary>
        /// <para>异步调用 [POST] /products/upload_files 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262782 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductsUploadFilesResponse> ExecuteProductsUploadFilesAsync(this TikTokShopClient client, Models.ProductsUploadFilesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "products", "upload_files")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ProductsUploadFilesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /products/upload_imgs 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262783 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductsUploadImagesResponse> ExecuteProductsUploadImagesAsync(this TikTokShopClient client, Models.ProductsUploadImagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "products", "upload_imgs")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ProductsUploadImagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
        public static async Task<Models.ProductsCategoriesResponse> ExecuteProductsCategoriesAsync(this TikTokShopClient client, Models.ProductsCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "categories")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ProductsCategoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/brands 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262795 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductsBrandsResponse> ExecuteProductsBrandsAsync(this TikTokShopClient client, Models.ProductsBrandsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "brands")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId)
                .SetQueryParam("page_number", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize);

            if (request.CategoryId != null)
                flurlReq.SetQueryParam("category_id", request.CategoryId);

            if (request.IsOnlyAuthorized != null)
                flurlReq.SetQueryParam("only_authorized", request.IsOnlyAuthorized.Value ? "true" : "false");

            if (request.BrandSuggest != null)
                flurlReq.SetQueryParam("brand_suggest", request.BrandSuggest);

            return await client.SendRequestWithJsonAsync<Models.ProductsBrandsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/attributes 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262796 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductsAttributesResponse> ExecuteProductsAttributesAsync(this TikTokShopClient client, Models.ProductsAttributesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "attributes")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            if (request.CategoryId != null)
                flurlReq.SetQueryParam("category_id", request.CategoryId);

            return await client.SendRequestWithJsonAsync<Models.ProductsAttributesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /products/categories/rules 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262797 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductsCategoriesRulesResponse> ExecuteProductsCategoriesRulesAsync(this TikTokShopClient client, Models.ProductsCategoriesRulesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "products", "categories", "rules")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId)
                .SetQueryParam("category_id", request.CategoryId);

            return await client.SendRequestWithJsonAsync<Models.ProductsCategoriesRulesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/category_recommend 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262806 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductCategoryRecommendResponse> ExecuteProductCategoryRecommendAsync(this TikTokShopClient client, Models.ProductCategoryRecommendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "category_recommend")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ProductCategoryRecommendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
