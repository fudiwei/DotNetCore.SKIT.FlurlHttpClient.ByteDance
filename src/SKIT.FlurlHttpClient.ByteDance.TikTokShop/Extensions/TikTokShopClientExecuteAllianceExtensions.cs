using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteAllianceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /alliance/getOrderList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/46/469 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AllianceGetOrderListResponse> ExecuteAllianceGetOrderListAsync(this TikTokShopClient client, Models.AllianceGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "alliance", "getOrderList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AllianceGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region MaterialsProducts
        /// <summary>
        /// <para>异步调用 [POST] /alliance/materialsProductsSearch 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/61/924 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AllianceMaterialsProductsSearchResponse> ExecuteAllianceMaterialsProductsSearchAsync(this TikTokShopClient client, Models.AllianceMaterialsProductsSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "alliance", "materialsProductsSearch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AllianceMaterialsProductsSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /alliance/materialsProductsDetails 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/61/1356 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AllianceMaterialsProductsDetailsResponse> ExecuteAllianceMaterialsProductsDetailsAsync(this TikTokShopClient client, Models.AllianceMaterialsProductsDetailsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "alliance", "materialsProductsDetails")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AllianceMaterialsProductsDetailsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
