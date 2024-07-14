using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    using SKIT.FlurlHttpClient;

    public static class TikTokShopClientExecuteFulfillmentExtensions
    {
        #region Orders
        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/{version}/orders/split_attributes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa9210fcef602bf32ae5b ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetOrderSplitAttributesResponse> ExecuteFulfillmentGetOrderSplitAttributesAsync(this TikTokShopClient client, Models.FulfillmentGetOrderSplitAttributesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fulfillment", request.ApiVersion, "orders", "split_attributes");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentGetOrderSplitAttributesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/{version}/orders/{order_id}/tracking 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa630c16ffe02b8f11803 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetOrderTrackingResponse> ExecuteFulfillmentGetOrderTrackingAsync(this TikTokShopClient client, Models.FulfillmentGetOrderTrackingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fulfillment", request.ApiVersion, "orders", request.OrderId, "tracking");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentGetOrderTrackingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/orders/{order_id}/shipping_services/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa6b2bace3e02b75dda4e ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentSearchOrderShippingServicesResponse> ExecuteFulfillmentSearchOrderShippingServicesAsync(this TikTokShopClient client, Models.FulfillmentSearchOrderShippingServicesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "orders", request.OrderId, "shipping_services", "query");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentSearchOrderShippingServicesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/orders/{order_id}/split 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa8890fcef602bf329fcc ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentSplitOrderResponse> ExecuteFulfillmentSplitOrderAsync(this TikTokShopClient client, Models.FulfillmentSplitOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "orders", request.OrderId, "split");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentSplitOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/orders/{order_id}/packages 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6503c95456e2bb0289ee4e81 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUpdateOrderPackagesResponse> ExecuteFulfillmentUpdateOrderPackagesAsync(this TikTokShopClient client, Models.FulfillmentUpdateOrderPackagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "orders", request.OrderId, "packages");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentUpdateOrderPackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/orders/{order_id}/shipping_info/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650ab7c40fcef602bf346f3a ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUpdateOrderShippingInfoResponse> ExecuteFulfillmentUpdateOrderShippingInfoAsync(this TikTokShopClient client, Models.FulfillmentUpdateOrderShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "orders", request.OrderId, "shipping_info", "update");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentUpdateOrderShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Packages
        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa132bace3e02b75d40d8 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentCreatePackageResponse> ExecuteFulfillmentCreatePackageAsync(this TikTokShopClient client, Models.FulfillmentCreatePackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentCreatePackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa592bace3e02b75db748 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentSearchPackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/{version}/packages/{package_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa39fbace3e02b75d8617 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "fulfillment", request.ApiVersion, "packages", request.PackageId);

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentGetPackageDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/{version}/packages/{package_id}/shipping_documents 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa5fac16ffe02b8f112ca ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetPackageShippingDocumentsResponse> ExecuteFulfillmentGetPackageShippingDocumentsAsync(this TikTokShopClient client, Models.FulfillmentGetPackageShippingDocumentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fulfillment", request.ApiVersion, "packages", request.PackageId, "shipping_documents");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentGetPackageShippingDocumentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/{version}/packages/{package_id}/handover_time_slots 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa5360fcef602bf324492 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentGetPackageHandoverTimeSlotsResponse> ExecuteFulfillmentGetPackageHandoverTimeSlotsAsync(this TikTokShopClient client, Models.FulfillmentGetPackageHandoverTimeSlotsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fulfillment", request.ApiVersion, "packages", request.PackageId, "handover_time_slots");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentGetPackageHandoverTimeSlotsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/{package_id}/shipping_info/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa666c16ffe02b8f1203c ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", request.PackageId, "shipping_info", "update");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentUpdatePackageShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/{package_id}/ship 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa4f1defece02be6e7cb1 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", request.PackageId, "ship");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentShipPackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/ship 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa3ebbace3e02b75d8bd4 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentBatchShipPackagesResponse> ExecuteFulfillmentBatchShipPackagesAsync(this TikTokShopClient client, Models.FulfillmentBatchShipPackagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", "ship");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentBatchShipPackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/deliver 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa332c16ffe02b8f0ba82 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentBatchUpdatePackagesDeliveryStatusResponse> ExecuteFulfillmentBatchUpdatePackagesDeliveryStatusAsync(this TikTokShopClient client, Models.FulfillmentBatchUpdatePackagesDeliveryStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", "deliver");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentBatchUpdatePackagesDeliveryStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Package/Combine
        /// <summary>
        /// <para>异步调用 [GET] /fulfillment/{version}/combinable_packages/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa481bace3e02b75d9e32 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentSearchCombinablePackagesResponse> ExecuteFulfillmentSearchCombinablePackagesAsync(this TikTokShopClient client, Models.FulfillmentSearchCombinablePackagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fulfillment", request.ApiVersion, "combinable_packages", "search")
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentSearchCombinablePackagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/combine 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa99adefece02be6f07c9 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentCombinePackageResponse> ExecuteFulfillmentCombinePackageAsync(this TikTokShopClient client, Models.FulfillmentCombinePackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", "combine");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentCombinePackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/packages/uncombine 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa960f1fd3102b92ceb0e ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUncombinePackageResponse> ExecuteFulfillmentUncombinePackageAsync(this TikTokShopClient client, Models.FulfillmentUncombinePackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "packages", "uncombine");

            return await client.SendFlurlRequesAsJsontAsync<Models.FulfillmentUncombinePackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Upload
        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/images/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa70d0fcef602bf32772f ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUploadImageResponse> ExecuteFulfillmentUploadImageAsync(this TikTokShopClient client, Models.FulfillmentUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = MimeTypes.GetMimeMapping(request.ImageFileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "images", "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "data");
            return await client.SendFlurlRequestAsync<Models.FulfillmentUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fulfillment/{version}/files/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509dffdc16ffe02b8dc10c5 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FulfillmentUploadFileResponse> ExecuteFulfillmentUploadFileAsync(this TikTokShopClient client, Models.FulfillmentUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".pdf";

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName) ;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fulfillment", request.ApiVersion, "files", "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "data");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.FileName)), "name");
            return await client.SendFlurlRequestAsync<Models.FulfillmentUploadFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
