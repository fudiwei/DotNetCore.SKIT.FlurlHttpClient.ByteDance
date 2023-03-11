using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteShopExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /shop/get_authorized_shop 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262739 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopGetAuthorizedShopResponse> ExecuteShopGetAuthorizedShopAsync(this TikTokShopClient client, Models.ShopGetAuthorizedShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "shop", "get_authorized_shop")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.ShopGetAuthorizedShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
