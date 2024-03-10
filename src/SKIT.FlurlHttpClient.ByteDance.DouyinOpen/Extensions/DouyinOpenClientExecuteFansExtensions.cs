using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteFansExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /fans/check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-management/fans-judge ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FansCheckResponse> ExecuteFansCheckAsync(this DouyinOpenClient client, Models.FansCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fans", "check")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("follower_open_id", request.FollowerOpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.FansCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
