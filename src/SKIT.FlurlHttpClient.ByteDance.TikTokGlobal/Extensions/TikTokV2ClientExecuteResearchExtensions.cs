using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokV2ClientExecuteResearchExtensions
    {
        #region Adlib
        /// <summary>
        /// <para>异步调用 [POST] /research/adlib/ad/query/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/commercial-content-api-query-ads ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchAdlibAdQueryResponse> ExecuteResearchAdlibAdQueryAsync(this TikTokV2Client client, Models.ResearchAdlibAdQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "adlib", "ad", "query/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchAdlibAdQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/adlib/ad/detail/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/commercial-content-api-get-ad-details ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchAdlibAdDetailResponse> ExecuteResearchAdlibAdDetailAsync(this TikTokV2Client client, Models.ResearchAdlibAdDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "adlib", "ad", "detail/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchAdlibAdDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/adlib/ad/report/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/commercial-content-api-get-ad-report ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchAdlibAdReportResponse> ExecuteResearchAdlibAdReportAsync(this TikTokV2Client client, Models.ResearchAdlibAdReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "adlib", "ad", "report/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchAdlibAdReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/adlib/advertiser/query/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/commercial-content-api-query-advertisers ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchAdlibAdvertiserQueryResponse> ExecuteResearchAdlibAdvertiserQueryAsync(this TikTokV2Client client, Models.ResearchAdlibAdvertiserQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "adlib", "advertiser", "query/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchAdlibAdvertiserQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/adlib/commercial_content/query/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/commercial-content-api-query-commercial-content ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchAdlibCommercialContentQueryResponse> ExecuteResearchAdlibCommercialContentQueryAsync(this TikTokV2Client client, Models.ResearchAdlibCommercialContentQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "adlib", "commercial_content", "query/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchAdlibCommercialContentQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Playlist
        /// <summary>
        /// <para>异步调用 [POST] /research/playlist/info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-playlist-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchPlaylistInfoResponse> ExecuteResearchPlaylistInfoAsync(this TikTokV2Client client, Models.ResearchPlaylistInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "playlist", "info/");

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchPlaylistInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region User
        /// <summary>
        /// <para>异步调用 [POST] /research/user/info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-user-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchUserInfoResponse> ExecuteResearchUserInfoAsync(this TikTokV2Client client, Models.ResearchUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "user", "info/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/user/liked_videos/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-user-liked-videos ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchUserLikedVideosResponse> ExecuteResearchUserLikedVideosAsync(this TikTokV2Client client, Models.ResearchUserLikedVideosRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "user", "liked_videos/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchUserLikedVideosResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/user/pinned_videos/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-user-pinned-videos ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchUserPinnedVideosResponse> ExecuteResearchUserPinnedVideosAsync(this TikTokV2Client client, Models.ResearchUserPinnedVideosRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "user", "pinned_videos/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchUserPinnedVideosResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/user/reposted_videos/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-user-reposted-videos ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchUserRepostedVideosResponse> ExecuteResearchUserRepostedVideosAsync(this TikTokV2Client client, Models.ResearchUserRepostedVideosRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "user", "reposted_videos/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchUserRepostedVideosResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/user/followers/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-user-followers ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchUserFollowersResponse> ExecuteResearchUserFollowersAsync(this TikTokV2Client client, Models.ResearchUserFollowersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "user", "followers/");

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchUserFollowersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/user/following/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-user-following ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchUserFollowingResponse> ExecuteResearchUserFollowingAsync(this TikTokV2Client client, Models.ResearchUserFollowingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "user", "following/");

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchUserFollowingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Video
        /// <summary>
        /// <para>异步调用 [POST] /research/video/query/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-videos ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchVideoQueryResponse> ExecuteResearchVideoQueryAsync(this TikTokV2Client client, Models.ResearchVideoQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "video", "query/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchVideoQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /research/video/comment/list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/research-api-specs-query-video-comments ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ResearchVideoCommentListResponse> ExecuteResearchVideoCommentListAsync(this TikTokV2Client client, Models.ResearchVideoCommentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "research", "video", "comment", "list/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.ResearchVideoCommentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
