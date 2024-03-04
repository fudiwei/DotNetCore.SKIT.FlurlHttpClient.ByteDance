using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteCustomerCenterExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /2/customer_center/advertiser/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710520884224 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerCenterAdvertiserListResponse> ExecuteCustomerCenterAdvertiserListAsync(this OceanEngineClient client, Models.CustomerCenterAdvertiserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "2", "customer_center", "advertiser", "list")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomerCenterAdvertiserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
