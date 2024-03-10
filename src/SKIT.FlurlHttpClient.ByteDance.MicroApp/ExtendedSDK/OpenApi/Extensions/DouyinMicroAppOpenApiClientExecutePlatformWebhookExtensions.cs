using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecutePlatformWebhookExtensions
    {
        #region Webhook
        /// <summary>
        /// <para>异步调用 [GET] /platform/v1/webhook/reset_secret/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/webhook-reset-secret ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenPlatformWebhookResetSecretV1Response> ExecuteOpenPlatformWebhookResetSecretV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenPlatformWebhookResetSecretV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platform", "v1", "webhook", "reset_secret/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenPlatformWebhookResetSecretV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platform/v1/webhook/save_callback_url/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/webhook-save-callbackurl ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenPlatformWebhookSaveCallbackUrlV1Response> ExecuteOpenPlatformWebhookSaveCallbackUrlV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenPlatformWebhookSaveCallbackUrlV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platform", "v1", "webhook", "save_callback_url/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenPlatformWebhookSaveCallbackUrlV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platform/v1/webhook/event_status_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/webhook-get-eventlist ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenPlatformWebhookEventStatusListV1Response> ExecuteOpenPlatformWebhookEventStatusListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenPlatformWebhookEventStatusListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platform", "v1", "webhook", "event_status_list/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenPlatformWebhookEventStatusListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platform/v1/webhook/update_event_status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/develop/webhook-update-eventstatus ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenPlatformWebhookUpdateEventStatusV1Response> ExecuteOpenPlatformWebhookUpdateEventStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenPlatformWebhookUpdateEventStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platform", "v1", "webhook", "update_event_status/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenPlatformWebhookUpdateEventStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
