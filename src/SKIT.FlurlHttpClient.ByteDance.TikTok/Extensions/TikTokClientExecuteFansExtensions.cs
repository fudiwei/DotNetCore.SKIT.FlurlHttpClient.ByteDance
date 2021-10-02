using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteFansExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /oauth/userinfo 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806527751489550 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthUserInfoResponse> ExecuteOAuthUserInfoAsync(this TikTokClient client, Models.OAuthUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "oauth", "userinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.OAuthUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fans/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806544893675533 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FansListResponse> ExecuteFansListAsync(this TikTokClient client, Models.FansListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fans", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.FansListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /following/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806523481737229 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FollowingListResponse> ExecuteFollowingListAsync(this TikTokClient client, Models.FollowingListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "following", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.FollowingListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fans/check 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6940930610949048334 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FansCheckResponse> ExecuteFansCheckAsync(this TikTokClient client, Models.FansCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fans", "check")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("follower_open_id", request.FollowerOpenId);

            return await client.SendRequestWithJsonAsync<Models.FansCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
