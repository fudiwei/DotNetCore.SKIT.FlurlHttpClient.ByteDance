using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteBusinessPlatformExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /2/business_platform/partner_organization/list 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1710414874245133 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BusinessPlatformPartnerOrganizationListResponse> ExecuteBusinessPlatformPartnerOrganizationListAsync(this OceanEngineClient client, Models.BusinessPlatformPartnerOrganizationListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "business_platform", "partner_organization", "list")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.BusinessPlatformPartnerOrganizationListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
