using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteFulfillmentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/search 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentSearchPackagesResponse> ExecuteFulfillmentSearchPackagesAsync(this TikTokShopClient client, Models.FulfillmentSearchPackagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "search");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentSearchPackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/detail 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262840 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetPackageDetailResponse> ExecuteFulfillmentGetPackageDetailAsync(this TikTokShopClient client, Models.FulfillmentGetPackageDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fulfillment", "detail")
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<Models.FulfillmentGetPackageDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/shipping_info 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262834 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetPackageShippingInfoResponse> ExecuteFulfillmentGetPackageShippingInfoAsync(this TikTokShopClient client, Models.FulfillmentGetPackageShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fulfillment", "shipping_info")
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<Models.FulfillmentGetPackageShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/shipping_document 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262832 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetPackageShippingDocumentResponse> ExecuteFulfillmentGetPackageShippingDocumentAsync(this TikTokShopClient client, Models.FulfillmentGetPackageShippingDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fulfillment", "shipping_document")
                .SetQueryParam("package_id", request.PackageId)
                .SetQueryParam("document_type", request.DocumentType);

            if (request.DocumentSize != null)
                flurlReq.SetQueryParam("document_size", request.DocumentSize);

            return await client.SendRequestWithJsonAsync<Models.FulfillmentGetPackageShippingDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/rts 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentShipPackageResponse> ExecuteFulfillmentShipPackageAsync(this TikTokShopClient client, Models.FulfillmentShipPackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "rts");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentShipPackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/batch_rts 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262844 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentBatchShipPackageResponse> ExecuteFulfillmentBatchShipPackageAsync(this TikTokShopClient client, Models.FulfillmentBatchShipPackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "batch_rts");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentBatchShipPackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/package_pickup_config/list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetPackagePickupConfigResponse> ExecuteFulfillmentGetPackagePickupConfigAsync(this TikTokShopClient client, Models.FulfillmentGetPackagePickupConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fulfillment", "package_pickup_config", "list")
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<Models.FulfillmentGetPackagePickupConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/shipping_info/update 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262833 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUpdatePackageShippingInfoResponse> ExecuteFulfillmentUpdatePackageShippingInfoAsync(this TikTokShopClient client, Models.FulfillmentUpdatePackageShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "shipping_info", "update");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentUpdatePackageShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/delivery 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262842 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUpdatePackageDeliveryStatusResponse> ExecuteFulfillmentUpdatePackageDeliveryStatusAsync(this TikTokShopClient client, Models.FulfillmentUpdatePackageDeliveryStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "delivery");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentUpdatePackageDeliveryStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/order_split/verify 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262829 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentVerifyOrderSplitResponse> ExecuteFulfillmentVerifyOrderSplitAsync(this TikTokShopClient client, Models.FulfillmentVerifyOrderSplitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "order_split", "verify");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentVerifyOrderSplitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/order_split/confirm 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262830 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentConfirmOrderSplitResponse> ExecuteFulfillmentConfirmOrderSplitAsync(this TikTokShopClient client, Models.FulfillmentConfirmOrderSplitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "order_split", "confirm");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentConfirmOrderSplitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/package/remove 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262838 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentRemovePackageOrdersResponse> ExecuteFulfillmentRemovePackageOrdersAsync(this TikTokShopClient client, Models.FulfillmentRemovePackageOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "package", "remove");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentRemovePackageOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region PreCombinePackage
        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/pre_combine_pkg/list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262831 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentSearchPreCombinePackagesResponse> ExecuteFulfillmentSearchPreCombinePackagesAsync(this TikTokShopClient client, Models.FulfillmentSearchPreCombinePackagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "fulfillment", "pre_combine_pkg", "list")
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.FulfillmentSearchPreCombinePackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/pre_combine_pkg/confirm 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262839 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentConfirmPreCombinePackageResponse> ExecuteFulfillmentConfirmPreCombinePackageAsync(this TikTokShopClient client, Models.FulfillmentConfirmPreCombinePackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "pre_combine_pkg", "confirm");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentConfirmPreCombinePackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Upload
        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/uploadimage 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUploadImageResponse> ExecuteFulfillmentUploadImageAsync(this TikTokShopClient client, Models.FulfillmentUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "uploadimage");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentUploadImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/uploadfile 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUploadFileResponse> ExecuteFulfillmentUploadFileAsync(this TikTokShopClient client, Models.FulfillmentUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fulfillment", "uploadfile");

            return await client.SendRequestWithJsonAsync<Models.FulfillmentUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
