using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    public static class DouyinMicroAppWebcastClientExecuteQuizExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /quiz/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/get_quiz_list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastQuizGetResponse> ExecuteWebcastQuizGetAsync(this DouyinMicroAppWebcastClient client, Models.WebcastQuizGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "quiz", "get")
                .WithHeader("X-Token", request.AccessToken);

            if (request.Level is not null)
                flurlReq.SetQueryParam("level", request.Level.Value);

            if (request.Type is not null)
                flurlReq.SetQueryParam("type", request.Type.Value);

            if (request.Number is not null)
                flurlReq.SetQueryParam("num", request.Number.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastQuizGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
