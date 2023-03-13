using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteSupplyChainExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /supply_chain/package_shipment_confirmation 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/273914 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SupplyChainSyncPackageFulfillmentDataResponse> ExecuteSupplyChainSyncPackageFulfillmentDataAsync(this TikTokShopClient client, Models.SupplyChainSyncPackageFulfillmentDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "supply_chain", "package_shipment_confirmation")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.SupplyChainSyncPackageFulfillmentDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
