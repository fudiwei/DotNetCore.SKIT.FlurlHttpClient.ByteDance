using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteFBTExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /fbt/{version}/merchants/onboarded_regions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/670d583a1ce48d030862011f ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FBTGetMerchantOnboardedRegionsResponse> ExecuteFBTGetMerchantOnboardedRegionsAsync(this TikTokShopClient client, Models.FBTGetMerchantOnboardedRegionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fbt", request.ApiVersion, "merchants", "onboarded_regions");

            return await client.SendFlurlRequesAsJsontAsync<Models.FBTGetMerchantOnboardedRegionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fbt/{version}/warehouses 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/670d588b192d3d0308430d56 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FBTGetWarehousesResponse> ExecuteFBTGetWarehousesAsync(this TikTokShopClient client, Models.FBTGetWarehousesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fbt", request.ApiVersion, "warehouses");

            return await client.SendFlurlRequesAsJsontAsync<Models.FBTGetWarehousesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fbt/{version}/inbound_orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/670d585aa88d11032480e0fc ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FBTGetInboundOrdersResponse> ExecuteFBTGetInboundOrdersAsync(this TikTokShopClient client, Models.FBTGetInboundOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fbt", request.ApiVersion, "inbound_orders")
                .SetQueryParam("ids", string.Join(",", request.InboundOrderIdList));

            return await client.SendFlurlRequesAsJsontAsync<Models.FBTGetInboundOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fbt/{version}/inventory/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/670d5868c78b9802f796ab81 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FBTGetInventoriesResponse> ExecuteFBTGetInventoriesAsync(this TikTokShopClient client, Models.FBTGetInventoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fbt", request.ApiVersion, "inventory", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FBTGetInventoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fbt/{version}/inventory_records/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/670d584ba83c5f030f3071e4 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FBTGetInventoryRecordsResponse> ExecuteFBTGetInventoryRecordsAsync(this TikTokShopClient client, Models.FBTGetInventoryRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fbt", request.ApiVersion, "inventory_records", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FBTGetInventoryRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fbt/{version}/goods/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/670d587d6921310398a3af3d ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FBTGetGoodsResponse> ExecuteFBTGetGoodsAsync(this TikTokShopClient client, Models.FBTGetGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fbt", request.ApiVersion, "goods", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FBTGetGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
