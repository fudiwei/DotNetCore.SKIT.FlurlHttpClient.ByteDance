using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    // TODO: 独立化 ExtendedSDK
    public static class DouyinOpenClientExecuteNamekExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /namek/fulfilment/prepare 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/tripartite.code/create/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NamekFulfilmentPrepareResponse> ExecuteNamekFulfilmentPrepareAsync(this DouyinOpenClient client, Models.NamekFulfilmentPrepareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "namek", "fulfilment", "prepare")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_data", request.EncryptedData)
                .SetQueryParam("code", request.Code);

            return await client.SendFlurlRequestAsJsonAsync<Models.NamekFulfilmentPrepareResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
