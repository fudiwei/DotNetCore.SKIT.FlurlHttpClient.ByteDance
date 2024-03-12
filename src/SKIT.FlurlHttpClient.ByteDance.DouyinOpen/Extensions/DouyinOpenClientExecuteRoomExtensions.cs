using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteRoomExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /room/data/room_id/get/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/live-data/live-id ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RoomDataRoomIdGetResponse> ExecuteRoomDataRoomIdGetAsync(this DouyinOpenClient client, Models.RoomDataRoomIdGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "room", "data", "room_id", "get/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp);

            return await client.SendFlurlRequestAsJsonAsync<Models.RoomDataRoomIdGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /room/data/interactive/get/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/live-data/live-interactive-data ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RoomDataInteractiveGetResponse> ExecuteRoomDataInteractiveGetAsync(this DouyinOpenClient client, Models.RoomDataInteractiveGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "room", "data", "interactive", "get/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("live_id", request.LiveId)
                .SetQueryParam("room_id", request.RoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.RoomDataInteractiveGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /room/data/audience/get/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/live-data/live-audience-data ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RoomDataAudienceGetResponse> ExecuteRoomDataAudienceGetAsync(this DouyinOpenClient client, Models.RoomDataAudienceGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "room", "data", "audience", "get/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("live_id", request.LiveId)
                .SetQueryParam("room_id", request.RoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.RoomDataAudienceGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /room/data/base/get/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/live-data/live-base-data ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RoomDataBaseGetResponse> ExecuteRoomDataBaseGetAsync(this DouyinOpenClient client, Models.RoomDataBaseGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "room", "data", "base", "get/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("live_id", request.LiveId)
                .SetQueryParam("room_id", request.RoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.RoomDataBaseGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
