using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteShopExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /shop/brandList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/13/54 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopBandListResponse> ExecuteShopBandListAsync(this TikTokShopClient client, Models.ShopBandListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "shop", "brandList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ShopBandListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /shop/getShopCategory 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/13/821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopGetShopCategoryResponse> ExecuteShopGetShopCategoryAsync(this TikTokShopClient client, Models.ShopGetShopCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "shop", "getShopCategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ShopGetShopCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
