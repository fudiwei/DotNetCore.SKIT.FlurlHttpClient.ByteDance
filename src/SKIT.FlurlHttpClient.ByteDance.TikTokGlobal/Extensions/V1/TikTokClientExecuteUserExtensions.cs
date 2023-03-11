using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokClientExecuteUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /user/info/ 接口。</para>
        /// <para>REF: https://developers.tiktok.com/doc/tiktok-api-v1-user-info/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserInfoResponse> ExecuteUserInfoAsync(this TikTokClient client, Models.UserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "user", "info/");

            return await client.SendRequestWithJsonAsync<Models.UserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
