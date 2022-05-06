using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /order/searchList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/555 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderSearchListResponse> ExecuteOrderSearchListAsync(this TikTokShopClient client, Models.OrderSearchListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "searchList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderSearchListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/orderDetail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/1144 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderDetailResponse> ExecuteOrderDetailAsync(this TikTokShopClient client, Models.OrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "orderDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/addOrderRemark 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/568 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderAddOrderRemarkResponse> ExecuteOrderAddOrderRemarkAsync(this TikTokShopClient client, Models.OrderAddOrderRemarkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "addOrderRemark")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderAddOrderRemarkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/updatePostAmount 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/264 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderUpdatePostAmountResponse> ExecuteOrderUpdatePostAmountAsync(this TikTokShopClient client, Models.OrderUpdatePostAmountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "updatePostAmount")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderUpdatePostAmountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/updateOrderAmount 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/263 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderUpdateOrderAmountResponse> ExecuteOrderUpdateOrderAmountAsync(this TikTokShopClient client, Models.OrderUpdateOrderAmountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "updateOrderAmount")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderUpdateOrderAmountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/addressModify 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/290 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderAddressModifyResponse> ExecuteOrderAddressModifyAsync(this TikTokShopClient client, Models.OrderAddressModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "addressModify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderAddressModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/AddressAppliedSwitch 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/500 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderAddressAppliedSwitchResponse> ExecuteOrderAddressAppliedSwitchAsync(this TikTokShopClient client, Models.OrderAddressAppliedSwitchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "AddressAppliedSwitch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderAddressAppliedSwitchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/addressConfirm 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/505 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderAddressConfirmResponse> ExecuteOrderAddressConfirmAsync(this TikTokShopClient client, Models.OrderAddressConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "addressConfirm")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderAddressConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/addresSwitchConfig 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/501 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderAddressSwitchConfigResponse> ExecuteOrderAddressSwitchConfigAsync(this TikTokShopClient client, Models.OrderAddressSwitchConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "addresSwitchConfig")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderAddressSwitchConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/addSerialNumber 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/687 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderAddSerialNumberResponse> ExecuteOrderAddSerialNumberAsync(this TikTokShopClient client, Models.OrderAddSerialNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "addSerialNumber")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderAddSerialNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

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

        #region Insurance
        /// <summary>
        /// <para>异步调用 [POST] /order/insurance 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/32/626 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderInsuranceResponse> ExecuteOrderInsuranceAsync(this TikTokShopClient client, Models.OrderInsuranceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "insurance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderInsuranceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/policy 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/32/902 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderPolicyResponse> ExecuteOrderPolicyAsync(this TikTokShopClient client, Models.OrderPolicyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "policy")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderPolicyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Service
        /// <summary>
        /// <para>异步调用 [POST] /order/getServiceList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/266 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderGetServiceListResponse> ExecuteOrderGetServiceListAsync(this TikTokShopClient client, Models.OrderGetServiceListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "getServiceList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderGetServiceListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/serviceDetail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/266 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderServiceDetailResponse> ExecuteOrderServiceDetailAsync(this TikTokShopClient client, Models.OrderServiceDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "serviceDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderServiceDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/replyService 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/75 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderReplyServiceResponse> ExecuteOrderReplyServiceAsync(this TikTokShopClient client, Models.OrderReplyServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "replyService")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderReplyServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Invoice
        /// <summary>
        /// <para>异步调用 [POST] /order/invoiceList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/660 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderInvoiceListResponse> ExecuteOrderInvoiceListAsync(this TikTokShopClient client, Models.OrderInvoiceListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "invoiceList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderInvoiceListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/invoiceUpload 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/guide-docs/150/812 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderInvoiceUploadResponse> ExecuteOrderInvoiceUploadAsync(this TikTokShopClient client, Models.OrderInvoiceUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "invoiceUpload")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.FileBytes == null)
            {
                return await client.SendRequestWithJsonAsync<Models.OrderInvoiceUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            }
            else
            {
                using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "invoice.pdf", fileBytes: request.FileBytes, fileContentType: "application/pdf", formDataName: "upload_file");
                httpContent.Add(new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8, "application/json"), Constants.FormDataFields.FORMDATA_PARAM_JSON);

                return await client.SendRequestAsync<Models.OrderInvoiceUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
            }
        }
        #endregion

        #region CrossBorder
        /// <summary>
        /// <para>异步调用 [POST] /order/getCrossBorderFulfillInfo 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/15/495 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderGetCrossBorderFulfillInformationResponse> ExecuteOrderGetCrossBorderFulfillInformationAsync(this TikTokShopClient client, Models.OrderGetCrossBorderFulfillInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "getCrossBorderFulfillInfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderGetCrossBorderFulfillInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Settle
        /// <summary>
        /// <para>异步调用 [POST] /order/settle 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/46/204 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderSettleResponse> ExecuteOrderSettleAsync(this TikTokShopClient client, Models.OrderSettleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "settle")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderSettleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/getSettleBillDetail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/46/1192 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderGetSettleBillDetailResponse> ExecuteOrderGetSettleBillDetailAsync(this TikTokShopClient client, Models.OrderGetSettleBillDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "getSettleBillDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderGetSettleBillDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/downloadToShop 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/46/1193 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderDownloadToShopResponse> ExecuteOrderDownloadToShopAsync(this TikTokShopClient client, Models.OrderDownloadToShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "downloadToShop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderDownloadToShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/downloadSettleItemToShop 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/46/1191 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderDownloadSettleItemToShopResponse> ExecuteOrderDownloadSettleItemToShopAsync(this TikTokShopClient client, Models.OrderDownloadSettleItemToShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "downloadSettleItemToShop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderDownloadSettleItemToShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Logistics
        /// <summary>
        /// <para>异步调用 [POST] /order/logisticsAdd 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/389 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderLogisticsAddResponse> ExecuteOrderLogisticsAddAsync(this TikTokShopClient client, Models.OrderLogisticsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "logisticsAdd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderLogisticsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/logisticsCompanyList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/541 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderLogisticsCompanyListResponse> ExecuteOrderLogisticsCompanyListAsync(this TikTokShopClient client, Models.OrderLogisticsCompanyListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "logisticsCompanyList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderLogisticsCompanyListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/logisticsEdit 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/390 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderLogisticsEditResponse> ExecuteOrderLogisticsEditAsync(this TikTokShopClient client, Models.OrderLogisticsEditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "logisticsEdit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderLogisticsEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/logisticsAddSinglePack 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/563 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderLogisticsAddSinglePackageResponse> ExecuteOrderLogisticsAddSinglePackageAsync(this TikTokShopClient client, Models.OrderLogisticsAddSinglePackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "logisticsAddSinglePack")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderLogisticsAddSinglePackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/logisticsAddMultiPack 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/562 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderLogisticsAddMultiplePackageResponse> ExecuteOrderLogisticsAddMultiplePackageAsync(this TikTokShopClient client, Models.OrderLogisticsAddMultiplePackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "logisticsAddMultiPack")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderLogisticsAddMultiplePackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /order/logisticsEditByPack 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/16/539 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderLogisticsEditByPackageResponse> ExecuteOrderLogisticsEditByPackageAsync(this TikTokShopClient client, Models.OrderLogisticsEditByPackageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "order", "logisticsEditByPack")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderLogisticsEditByPackageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
