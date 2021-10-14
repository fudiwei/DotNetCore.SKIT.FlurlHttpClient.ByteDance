using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternaUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/item 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798450331486212 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserItemResponse> ExecuteDataExternalUserItemAsync(this TikTokClient client, Models.DataExternalUserItemRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "item")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserItemResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/fans 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798450331453444 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserFansResponse> ExecuteDataExternalUserFansAsync(this TikTokClient client, Models.DataExternalUserFansRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "fans")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserFansResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/like 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798450331518980 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserLikeResponse> ExecuteDataExternalUserLikeAsync(this TikTokClient client, Models.DataExternalUserLikeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "like")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserLikeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/comment 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798450331420676 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserCommentResponse> ExecuteDataExternalUserCommentAsync(this TikTokClient client, Models.DataExternalUserCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "comment")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/share 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798471810451459 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserShareResponse> ExecuteDataExternalUserShareAsync(this TikTokClient client, Models.DataExternalUserShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "share")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/profile 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798450331551748 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserProfileResponse> ExecuteDataExternalUserProfileAsync(this TikTokClient client, Models.DataExternalUserProfileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "profile")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserProfileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
