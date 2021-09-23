using System;
using System.Collections.Generic;
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
                string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                string filename = "invoice.pdf";
                using var fileContent = new ByteArrayContent(request.FileBytes);
                using var paramContent = new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
                using var httpContent = new MultipartFormDataContent(boundary);
                httpContent.Add(fileContent, "\"upload_file\"", $"\"{HttpUtility.UrlEncode(filename)}\"");
                httpContent.Add(paramContent, Constants.FormDataFields.FORMDATA_PARAM_JSON);
                httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/pdf");
                fileContent.Headers.ContentLength = request.FileBytes.Length;

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
    }
}
