using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteOrderExtensions
    {
        #region Encryption
        /// <summary>
        /// <para>异步调用 [POST] /order/batchDecrypt 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/982 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderBatchDecryptResponse> ExecuteOrderBatchDecryptAsync(this TikTokShopClient client, Models.OrderBatchDecryptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "batchDecrypt")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderBatchDecryptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/batchEncrypt 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/487 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderBatchEncryptResponse> ExecuteOrderBatchEncryptAsync(this TikTokShopClient client, Models.OrderBatchEncryptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "batchEncrypt")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderBatchEncryptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/batchSensitive 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/508 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderBatchSensitiveResponse> ExecuteOrderBatchSensitiveAsync(this TikTokShopClient client, Models.OrderBatchSensitiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "batchSensitive")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderBatchSensitiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/BatchSearchIndex 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/516 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderBatchSearchIndexResponse> ExecuteOrderBatchSearchIndexAsync(this TikTokShopClient client, Models.OrderBatchSearchIndexRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "BatchSearchIndex")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderBatchSearchIndexResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
