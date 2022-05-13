using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteGoodLifeExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/get 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/life.capacity.fulfilment/certificate.get </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateGetV1Response> ExecuteGoodLifeFulfilmentCertificateGetV1Async(this TikTokClient client, Models.GoodLifeFulfilmentCertificateGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.EncryptedCode != null)
                flurlReq.SetQueryParam("encrypted_code", request.EncryptedCode);

            if (request.Code != null)
                flurlReq.SetQueryParam("code", request.Code);

            if (request.OrderId != null)
                flurlReq.SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/certificate/verify 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/life.capacity.fulfilment/certificate.verify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateVerifyV1Response> ExecuteGoodLifeFulfilmentCertificateVerifyV1Async(this TikTokClient client, Models.GoodLifeFulfilmentCertificateVerifyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "certificate", "verify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateVerifyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
