using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokV2ClientExecuteUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /user/info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-api-v2-get-user-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserInfoResponse> ExecuteUserInfoAsync(this TikTokV2Client client, Models.UserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "user", "info/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.UserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Data
        /// <summary>
        /// <para>异步调用 [POST] /user/data/add/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/data-portability-api-add-data-request ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserDataAddResponse> ExecuteUserDataAddAsync(this TikTokV2Client client, Models.UserDataAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user", "data", "add/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.UserDataAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user/data/cancel/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/data-portability-api-cancel-data-request ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserDataCancelResponse> ExecuteUserDataCancelAsync(this TikTokV2Client client, Models.UserDataCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user", "data", "cancel/");

            return await client.SendFlurlRequestAsJsonAsync<Models.UserDataCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user/data/check/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/data-portability-api-check-status-of-data-request ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserDataCheckResponse> ExecuteUserDataCheckAsync(this TikTokV2Client client, Models.UserDataCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user", "data", "check/")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsJsonAsync<Models.UserDataCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user/data/download/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/data-portability-api-download ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserDataDownloadResponse> ExecuteUserDataDownloadAsync(this TikTokV2Client client, Models.UserDataDownloadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user", "data", "download/");

            return await client.SendFlurlRequestAsJsonAsync<Models.UserDataDownloadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
