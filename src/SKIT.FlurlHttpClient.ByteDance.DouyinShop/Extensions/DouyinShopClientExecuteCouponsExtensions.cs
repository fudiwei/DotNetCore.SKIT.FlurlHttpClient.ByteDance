using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteCouponsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /coupons/cancelVerify 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/52/668 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CouponsCancelVerifyResponse> ExecuteCouponsCancelVerifyAsync(this DouyinShopClient client, Models.CouponsCancelVerifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "coupons", "cancelVerify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CouponsCancelVerifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /coupons/abandon 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/52/669 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CouponsAbandonResponse> ExecuteCouponsAbandonAsync(this DouyinShopClient client, Models.CouponsAbandonRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "coupons", "abandon")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CouponsAbandonResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /coupons/syncV2 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/52/712 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CouponsSyncV2Response> ExecuteCouponsSyncV2Async(this DouyinShopClient client, Models.CouponsSyncV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "coupons", "syncV2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CouponsSyncV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /coupons/verifyV2 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/52/797 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CouponsVerifyV2Response> ExecuteCouponsVerifyV2Async(this DouyinShopClient client, Models.CouponsVerifyV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "coupons", "verifyV2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CouponsVerifyV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
