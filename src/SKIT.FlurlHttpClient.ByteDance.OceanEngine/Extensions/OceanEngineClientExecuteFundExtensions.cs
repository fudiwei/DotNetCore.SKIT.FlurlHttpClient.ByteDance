using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteFundExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /2/fund/shared_wallet_balance/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1703323812831239 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FundSharedWalletBalanceGetResponse> ExecuteFundSharedWalletBalanceGetAsync(this OceanEngineClient client, Models.FundSharedWalletBalanceGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "fund", "shared_wallet_balance", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FundSharedWalletBalanceGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
