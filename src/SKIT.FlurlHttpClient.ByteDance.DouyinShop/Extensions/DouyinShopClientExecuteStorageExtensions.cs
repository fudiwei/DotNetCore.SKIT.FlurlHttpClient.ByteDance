using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteStorageExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /storage/notifySaleReturnStatus 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/538 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.StorageNotifySaleReturnStatusResponse> ExecuteStorageNotifySaleReturnStatusAsync(this DouyinShopClient client, Models.StorageNotifySaleReturnStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "storage", "notifySaleReturnStatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.StorageNotifySaleReturnStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
