using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteWebcastExtensions
    {
        #region LiveData
        /// <summary>
        /// <para>异步调用 [POST] /live_data/task/start 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskStartResponse> ExecuteWebcastLiveDataTaskStartAsync(this ByteDanceMicroAppClient client, Models.WebcastLiveDataTaskStartRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "live_data", "task", "start")
                .WithUrl($"{client.EndpointForWebcastAPI}/live_data/task/start")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WebcastLiveDataTaskStartResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /live_data/task/stop 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskStopResponse> ExecuteWebcastLiveDataTaskStopAsync(this ByteDanceMicroAppClient client, Models.WebcastLiveDataTaskStopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "live_data", "task", "stop")
                .WithUrl($"{client.EndpointForWebcastAPI}/live_data/task/stop")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WebcastLiveDataTaskStopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /live_data/task/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskGetResponse> ExecuteWebcastLiveDataTaskGetAsync(this ByteDanceMicroAppClient client, Models.WebcastLiveDataTaskGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "live_data", "task", "get")
                .WithUrl($"{client.EndpointForWebcastAPI}/live_data/task/get")
                .WithHeader("access-token", request.AccessToken)
                .WithHeader("appid", request.AppId)
                .WithHeader("roomid", request.RoomId)
                .WithHeader("msg_type", request.MessageType);

            return await client.SendRequestWithJsonAsync<Models.WebcastLiveDataTaskGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /live_data/task/fail_data/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLiveDataTaskFailDataGetResponse> ExecuteWebcastLiveDataTaskFailDataGetAsync(this ByteDanceMicroAppClient client, Models.WebcastLiveDataTaskFailDataGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "live_data", "task", "fail_data", "get")
                .WithUrl($"{client.EndpointForWebcastAPI}/live_data/task/fail_data/get")
                .WithHeader("access-token", request.AccessToken)
                .WithHeader("appid", request.AppId)
                .WithHeader("roomid", request.RoomId)
                .WithHeader("msg_type", request.MessageType)
                .WithHeader("page_num", request.PageNumber)
                .WithHeader("page_size", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.WebcastLiveDataTaskFailDataGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Gift
        /// <summary>
        /// <para>异步调用 [POST] /gift/top_gift 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/danmu </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastGiftTopGiftResponse> ExecuteWebcastGiftTopGiftAsync(this ByteDanceMicroAppClient client, Models.WebcastGiftTopGiftRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "gift", "top_gift")
                .WithUrl($"{client.EndpointForWebcastAPI}/gift/top_gift")
                .WithHeader("x-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WebcastGiftTopGiftResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LinkMic
        /// <summary>
        /// <para>异步调用 [POST] /linkmic/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/mic </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastLinkMicQueryResponse> ExecuteWebcastLinkMicQueryAsync(this ByteDanceMicroAppClient client, Models.WebcastLinkMicQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "linkmic", "query")
                .WithUrl($"{client.EndpointForWebcastAPI}/linkmic/query")
                .WithHeader("x-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WebcastLinkMicQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
