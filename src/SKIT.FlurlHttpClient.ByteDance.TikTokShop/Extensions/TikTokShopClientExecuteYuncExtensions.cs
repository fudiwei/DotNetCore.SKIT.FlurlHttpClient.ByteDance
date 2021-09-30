using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteYuncExtensions
    {
        #region WMS
        /// <summary>
        /// <para>异步调用 [POST] /yunc/pushOutboundFeedback 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/842 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncPushOutboundFeedbackResponse> ExecuteYuncPushOutboundFeedbackAsync(this TikTokShopClient client, Models.YuncPushOutboundFeedbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "pushOutboundFeedback")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncPushOutboundFeedbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/adjustInventory 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/930 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncAdjustInventoryResponse> ExecuteYuncAdjustInventoryAsync(this TikTokShopClient client, Models.YuncAdjustInventoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "adjustInventory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncAdjustInventoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /yunc/wmsInboundCallback 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/50/929 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.YuncWMSInboundCallbackResponse> ExecuteYuncWMSInboundCallbackAsync(this TikTokShopClient client, Models.YuncWMSInboundCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "yunc", "wmsInboundCallback")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.YuncWMSInboundCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
