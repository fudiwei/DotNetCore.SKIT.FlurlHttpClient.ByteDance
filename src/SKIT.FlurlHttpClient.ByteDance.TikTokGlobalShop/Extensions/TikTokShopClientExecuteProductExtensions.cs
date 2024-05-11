using System;
using System.Net.Http;
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
    }
}
