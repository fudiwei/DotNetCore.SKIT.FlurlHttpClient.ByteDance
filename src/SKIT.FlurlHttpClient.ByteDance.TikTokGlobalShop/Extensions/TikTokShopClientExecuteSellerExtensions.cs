using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteSellerExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /seller/global/active_shops 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262743 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SellerGlobalActiveShopsResponse> ExecuteSellerGlobalActiveShopsAsync(this TikTokShopClient client, Models.SellerGlobalActiveShopsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "seller", "global", "active_shops")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.SellerGlobalActiveShopsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /seller/manage_global_product/check 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262744 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SellerManageGlobalProductCheckResponse> ExecuteSellerManageGlobalProductCheckAsync(this TikTokShopClient client, Models.SellerManageGlobalProductCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "seller", "manage_global_product", "check")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.SellerManageGlobalProductCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
