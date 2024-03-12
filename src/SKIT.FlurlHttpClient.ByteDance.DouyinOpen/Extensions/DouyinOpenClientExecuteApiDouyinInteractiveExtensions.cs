using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteApiDouyinInteractiveExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /api/douyin/v1/interactive/intention/log/list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/intention-user/log ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DouyinInteractiveIntentionLogListV1Response> ExecuteDouyinInteractiveIntentionLogListV1Async(this DouyinOpenClient client, Models.DouyinInteractiveIntentionLogListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "douyin", "v1", "interactive", "intention", "log", "list/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("event", request.Event)
                .SetQueryParam("query_session", request.QuerySession)
                .SetQueryParam("count", request.Count);

            return await client.SendFlurlRequestAsJsonAsync<Models.DouyinInteractiveIntentionLogListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
