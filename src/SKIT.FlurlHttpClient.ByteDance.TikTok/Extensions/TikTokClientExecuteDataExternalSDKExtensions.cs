using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternalSDKExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /data/external/sdk_share 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/sdk-share-video-data/get-share-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalSDKShareResponse> ExecuteDataExternalSDKShareAsync(this TikTokClient client, Models.DataExternalSDKShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "sdk_share")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.DataExternalSDKShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
