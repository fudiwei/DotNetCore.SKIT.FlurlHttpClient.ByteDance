using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokClientV2ExecuteUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /user/info/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/tiktok-api-v2-get-user-info/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserInfoV2Response> ExecuteUserInfoV2Async(this TikTokClientV2 client, Models.UserInfoV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "user", "info/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendRequestWithJsonAsync<Models.UserInfoV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
