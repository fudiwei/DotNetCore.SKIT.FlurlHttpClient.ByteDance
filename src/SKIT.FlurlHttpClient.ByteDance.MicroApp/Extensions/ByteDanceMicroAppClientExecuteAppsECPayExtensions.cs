using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsECPayExtensions
    {
        private static string GenerateRequestSignature<TRequest>(this ByteDanceMicroAppClient client, TRequest request)
            where TRequest : ByteDanceMicroAppRequest
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (request == null) throw new ArgumentNullException(nameof(request));

            /*
             * REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/appendix#%E8%AF%B7%E6%B1%82%E7%AD%BE%E5%90%8D%E7%AE%97%E6%B3%95
             */

            string json = client.JsonSerializer.Serialize(request);
            IList<string> tempList = new List<string>() { client.Credentials.ECPaySalt! };
            IDictionary<string, string> paramMap = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json)!;

            foreach (var item in paramMap)
            {
                string key = item.Key;
                string? value = item.Value?.Trim();

                if ("other_settle_params".Equals(key) ||
                    "app_id".Equals(key) ||
                    "thirdparty_id".Equals(key) ||
                    "sign".Equals(key))
                {
                    continue;
                }

                if (value != null && value.StartsWith("\"") && value.EndsWith("\""))
                {
                    value = value.Substring(1, value.Length - 1).Trim();
                }

                if (string.IsNullOrEmpty(value) || "null".Equals(value))
                {
                    continue;
                }

                tempList.Add(value!);
            }

            var tempArray = tempList.ToArray();
            Array.Sort(tempArray, StringComparer.Ordinal);
            string plainText = string.Join("&", tempArray);
            return Utilities.MD5Utility.Hash(plainText).ToLower();
        }

        #region SaaS
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/create_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/APIlist/apply/create </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSCreateMerchantResponse> ExecuteAppsECPaySaaSCreateMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSCreateMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "create_merchant");

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSCreateMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/image_upload 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/APIlist/apply/image-upload </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSImageUploadResponse> ExecuteAppsECPaySaaSImageUploadAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "image_upload");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/query_merchant_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/APIlist/apply/query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSQueryMerchantStatusResponse> ExecuteAppsECPaySaaSQueryMerchantStatusAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSQueryMerchantStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "query_merchant_status");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSQueryMerchantStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/add_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/page-links/apply/merchant </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAddMerchantResponse> ExecuteAppsECPaySaaSAddMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSAddMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "add_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSAddMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/get_app_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/page-links/apply/app-merchant </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSGetAppMerchantResponse> ExecuteAppsECPaySaaSGetAppMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSGetAppMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "get_app_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSGetAppMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/app_add_sub_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/page-links/apply/sub-merchant </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAppAddSubMerchantResponse> ExecuteAppsECPaySaaSAppAddSubMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSAppAddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "app_add_sub_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSAppAddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/add_sub_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/merchant#%E6%9C%8D%E5%8A%A1%E5%95%86%E4%B8%BA%E7%AC%AC%E4%B8%89%E6%96%B9%E8%BF%9B%E4%BB%B6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAddSubMerchantResponse> ExecuteAppsECPaySaaSAddSubMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSAddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "add_sub_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSAddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_order 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayCreateOrderV1Response> ExecuteAppsECPayCreateOrderV1Async(this ByteDanceMicroAppClient client, Models.AppsECPayCreateOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_order");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayCreateOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_order 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQueryOrderV1Response> ExecuteAppsECPayQueryOrderV1Async(this ByteDanceMicroAppClient client, Models.AppsECPayQueryOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_order");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayQueryOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_refund 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayCreateRefundV1Response> ExecuteAppsECPayCreateRefundV1Async(this ByteDanceMicroAppClient client, Models.AppsECPayCreateRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_refund");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayCreateRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_refund 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQueryRefundV1Response> ExecuteAppsECPayQueryRefundV1Async(this ByteDanceMicroAppClient client, Models.AppsECPayQueryRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_refund");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayQueryRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/settle 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySettleV1Response> ExecuteAppsECPaySettleV1Async(this ByteDanceMicroAppClient client, Models.AppsECPaySettleV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "settle");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySettleV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_settle 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQuerySettleV1Response> ExecuteAppsECPayQuerySettleV1Async(this ByteDanceMicroAppClient client, Models.AppsECPayQuerySettleV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_settle");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayQuerySettleV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [GET] /apps/bill 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/bill </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsBillResponse> ExecuteAppsBillAsync(this ByteDanceMicroAppClient client, Models.AppsBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apps", "bill")
                .SetQueryParam("app_id", request.AppId)
                .SetQueryParam("seller", request.MerchantId)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString)
                .SetQueryParam("bill_type", request.BillType)
                .SetQueryParam("sign", request.Signature);

            return await client.SendRequestWithJsonAsync<Models.AppsBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
