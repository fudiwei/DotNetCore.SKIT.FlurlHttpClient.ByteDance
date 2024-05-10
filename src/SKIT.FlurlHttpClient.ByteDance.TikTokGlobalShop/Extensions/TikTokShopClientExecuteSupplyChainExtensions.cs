using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteSupplyChainExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /supply_chain/{version}/packages/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ac12b4a0bb702c070e7c3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SupplyChainSyncPackagesResponse> ExecuteSupplyChainSyncPackagesAsync(this TikTokShopClient client, Models.SupplyChainSyncPackagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "supply_chain", request.ApiVersion, "packages", "sync");

            return await client.SendFlurlRequesAsJsontAsync<Models.SupplyChainSyncPackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
