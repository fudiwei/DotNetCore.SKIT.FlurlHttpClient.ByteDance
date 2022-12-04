using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteNamekExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /namek/fulfilment/prepare 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/tripartite.code/create/ </para>
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
                .CreateRequest(request, HttpMethod.Get, "namek", "fulfilment", "prepare")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.EncryptedData != null)
                flurlReq.SetQueryParam("encrypted_data", request.EncryptedData);

            if (request.Code != null)
                flurlReq.SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.NamekFulfilmentPrepareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
