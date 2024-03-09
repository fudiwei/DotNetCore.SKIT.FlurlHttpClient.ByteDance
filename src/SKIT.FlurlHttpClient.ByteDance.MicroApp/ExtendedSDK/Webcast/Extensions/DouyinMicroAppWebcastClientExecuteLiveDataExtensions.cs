using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    public static class DouyinMicroAppWebcastClientExecuteLiveDataExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /live_data/task/start 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskStartResponse> ExecuteWebcastLiveDataTaskStartAsync(this DouyinMicroAppWebcastClient client, Models.WebcastLiveDataTaskStartRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "live_data", "task", "start")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastLiveDataTaskStartResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /live_data/task/stop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskStopResponse> ExecuteWebcastLiveDataTaskStopAsync(this DouyinMicroAppWebcastClient client, Models.WebcastLiveDataTaskStopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "live_data", "task", "stop")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastLiveDataTaskStopResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /live_data/task/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskGetResponse> ExecuteWebcastLiveDataTaskGetAsync(this DouyinMicroAppWebcastClient client, Models.WebcastLiveDataTaskGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "live_data", "task", "get")
                .WithHeader("access-token", request.AccessToken)
                .WithHeader("appid", request.AppId)
                .WithHeader("roomid", request.RoomId)
                .WithHeader("msg_type", request.MessageType);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastLiveDataTaskGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /live_data/task/fail_data/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskFailDataGetResponse> ExecuteWebcastLiveDataTaskFailDataGetAsync(this DouyinMicroAppWebcastClient client, Models.WebcastLiveDataTaskFailDataGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "live_data", "task", "fail_data", "get")
                .WithHeader("access-token", request.AccessToken)
                .WithHeader("appid", request.AppId)
                .WithHeader("roomid", request.RoomId)
                .WithHeader("msg_type", request.MessageType)
                .WithHeader("page_num", request.PageNumber)
                .WithHeader("page_size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastLiveDataTaskFailDataGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
