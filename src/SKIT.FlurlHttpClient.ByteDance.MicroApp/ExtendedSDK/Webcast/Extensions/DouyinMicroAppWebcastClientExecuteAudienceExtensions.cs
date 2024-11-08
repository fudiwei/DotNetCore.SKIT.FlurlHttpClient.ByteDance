using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    public static class DouyinMicroAppWebcastClientExecuteAudienceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /audience/join_game 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/audience-play ]]> 
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastAudienceJoinGameResponse> ExecuteWebcastAudienceJoinGameAsync(this DouyinMicroAppWebcastClient client, Models.WebcastAudienceJoinGameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "audience", "join_game")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastAudienceJoinGameResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /audience/leave_game 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/audience-play ]]> 
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastAudienceLeaveGameResponse> ExecuteWebcastAudienceLeaveGameAsync(this DouyinMicroAppWebcastClient client, Models.WebcastAudienceLeaveGameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "audience", "leave_game")
                .WithHeader("X-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastAudienceLeaveGameResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
