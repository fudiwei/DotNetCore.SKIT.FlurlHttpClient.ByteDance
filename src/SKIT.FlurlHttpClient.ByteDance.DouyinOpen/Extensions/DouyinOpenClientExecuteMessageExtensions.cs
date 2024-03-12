using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteMessageExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /message/once/send/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/one-time-subscription-message ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MessageOnceSendResponse> ExecuteMessageOnceSendAsync(this DouyinOpenClient client, Models.MessageOnceSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "message", "once", "send/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.MessageOnceSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
