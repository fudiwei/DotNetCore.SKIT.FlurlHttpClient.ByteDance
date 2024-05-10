using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyClientExecuteShopExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /shop/get_authorized_shop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262739 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShopGetAuthorizedShopListResponse> ExecuteShopGetAuthorizedShopListAsync(this TikTokShopLegacyClient client, Models.ShopGetAuthorizedShopListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "shop", "get_authorized_shop");

            return await client.SendFlurlRequesAsJsontAsync<Models.ShopGetAuthorizedShopListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
