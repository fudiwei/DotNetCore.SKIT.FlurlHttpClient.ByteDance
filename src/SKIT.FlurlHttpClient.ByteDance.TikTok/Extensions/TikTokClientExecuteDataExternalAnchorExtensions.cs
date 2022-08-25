using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternalAnchorExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /data/external/anchor/mp_item_click_distribution 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/mini-app-list/get-video-click-distribution </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalAnchorMpItemClickDistributionResponse> ExecuteDataExternalAnchorMpItemClickDistributionAsync(this TikTokClient client, Models.DataExternalAnchorMpItemClickDistributionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "anchor", "mp_item_click_distribution")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("mp_id", request.MiniAppId)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalAnchorMpItemClickDistributionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
