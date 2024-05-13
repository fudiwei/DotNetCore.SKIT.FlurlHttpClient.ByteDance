using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteLogisticsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /logistics/{version}/warehouses 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa418defece02be6e66b6 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetWarehousesResponse> ExecuteLogisticsGetWarehousesAsync(this TikTokShopClient client, Models.LogisticsGetWarehousesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", request.ApiVersion, "warehouses");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetWarehousesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/{version}/global_warehouses 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa3f0defece02be6e5ffb ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetGlobalWarehousesResponse> ExecuteLogisticsGetGlobalWarehousesAsync(this TikTokShopClient client, Models.LogisticsGetGlobalWarehousesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", request.ApiVersion, "global_warehouses");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetGlobalWarehousesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/{version}/warehouses/{warehouse_id}/delivery_options 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa46ebace3e02b75d9afa ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetWarehouseDeliveryOptionsResponse> ExecuteLogisticsGetWarehouseDeliveryOptionsAsync(this TikTokShopClient client, Models.LogisticsGetWarehouseDeliveryOptionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", request.ApiVersion, "warehouses", request.WarehouseId, "delivery_options");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetWarehouseDeliveryOptionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /logistics/{version}/delivery_options/{delivery_option_id}/shipping_providers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa48d4a0bb702c06d85cd ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LogisticsGetDeliveryOptionShippingProvidersResponse> ExecuteLogisticsGetDeliveryOptionShippingProvidersAsync(this TikTokShopClient client, Models.LogisticsGetDeliveryOptionShippingProvidersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "logistics", request.ApiVersion, "delivery_options", request.DeliveryOptionId, "shipping_providers");

            return await client.SendFlurlRequesAsJsontAsync<Models.LogisticsGetDeliveryOptionShippingProvidersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
