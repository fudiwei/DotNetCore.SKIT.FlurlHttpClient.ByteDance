using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /apps/token 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/interface-request-credential/get-access-token </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/interface-request-credential/get-access-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTokenResponse> ExecuteAppsTokenAsync(this ByteDanceMicroAppClient client, Models.AppsTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apps", "token")
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("secret", client.Credentials.AppSecret)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendRequestWithJsonAsync<Models.AppsTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/jscode2session 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/log-in/code-2-session </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/log-in/code-2-session </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsJsCode2SessionResponse> ExecuteAppsJsCode2SessionAsync(this ByteDanceMicroAppClient client, Models.AppsJsCode2SessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apps", "jscode2session")
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("secret", client.Credentials.AppSecret);

            if (!string.IsNullOrEmpty(request.Code))
                flurlReq.SetQueryParam("code", request.Code);

            if (!string.IsNullOrEmpty(request.AnoymousCode))
                flurlReq.SetQueryParam("anonymous_code", request.AnoymousCode);

            return await client.SendRequestWithJsonAsync<Models.AppsJsCode2SessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /apps/qrcode 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/qr-code/create-qr-code </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/qr-code/create-qr-code </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsQrcodeResponse> ExecuteAppsQrcodeAsync(this ByteDanceMicroAppClient client, Models.AppsQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "qrcode");

            return await client.SendRequestWithJsonAsync<Models.AppsQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SubscribeNotification
        /// <summary>
        /// <para>异步调用 [POST] /apps/subscribe_notification/developer/v1/notify 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/subscribe-notification/notify </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/subscribe-notification/notify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsSubscribeNotificationDeveloperV1NotifyResponse> ExecuteAppsSubscribeNotificationDeveloperV1NotifyAsync(this ByteDanceMicroAppClient client, Models.AppsSubscribeNotificationDeveloperV1NotifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "subscribe_notification", "developer", "v1", "notify");

            return await client.SendRequestWithJsonAsync<Models.AppsSubscribeNotificationDeveloperV1NotifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Config
        /// <summary>
        /// <para>异步调用 [POST] /apps/share_config 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/other/live-bg-image </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsShareConfigResponse> ExecuteAppsShareConfigAsync(this ByteDanceMicroAppClient client, Models.AppsShareConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "share_config");

            return await client.SendRequestWithJsonAsync<Models.AppsShareConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Live
        /// <summary>
        /// <para>异步调用 [POST] /apps/upload_live_image 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/other/live-bg-image </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsUplodateLiveImageResponse> ExecuteAppsUplodateLiveImageAsync(this ByteDanceMicroAppClient client, Models.AppsUplodateLiveImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.ImageFileName))
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "upload_live_image");

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.ImageFileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"image\"", $"\"{HttpUtility.UrlEncode(request.ImageFileName)}\"");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.AppId)), "app_id");
            if (request.RoomId.HasValue)
                httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.RoomId.ToString())), "room_id");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.Title)), "title");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.PagePath)), "start_page");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
            fileContent.Headers.ContentLength = request.ImageFileBytes?.Length;

            return await client.SendRequestAsync<Models.AppsUplodateLiveImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region Video
        /// <summary>
        /// <para>异步调用 [POST] /apps/convert_video_id/video_id_to_open_item_id 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/other/video-id-convert </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsConvertVideoIdToOpenItemIdResponse> ExecuteAppsConvertVideoIdToOpenItemIdAsync(this ByteDanceMicroAppClient client, Models.AppsConvertVideoIdToOpenItemIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "convert_video_id", "video_id_to_open_item_id");

            return await client.SendRequestWithJsonAsync<Models.AppsConvertVideoIdToOpenItemIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/convert_video_id/open_item_id_to_encrypt_id 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/other/video-id-convert </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsConvertOpenItemIdToEncryptIdResponse> ExecuteAppsConvertOpenItemIdToEncryptIdAsync(this ByteDanceMicroAppClient client, Models.AppsConvertOpenItemIdToEncryptIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "convert_video_id", "open_item_id_to_encrypt_id");

            return await client.SendRequestWithJsonAsync<Models.AppsConvertOpenItemIdToEncryptIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
