using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
            return Security.MD5Utility.Hash(plainText).ToLower();
        }

        #region SaaS
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/add_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/merchant#%E6%9C%8D%E5%8A%A1%E5%95%86%E8%BF%9B%E4%BB%B6%E6%8E%A5%E5%8F%A3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAddMerchantResponse> ExecuteAppsECPaySaaSAddMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSAddMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "add_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSAddMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/get_app_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/merchant#%E6%9C%8D%E5%8A%A1%E5%95%86%E4%BB%A3%E5%B0%8F%E7%A8%8B%E5%BA%8F%E8%BF%9B%E4%BB%B6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSGetAppMerchantResponse> ExecuteAppsECPaySaaSGetAppMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSGetAppMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "get_app_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSGetAppMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/app_add_sub_merchant 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/merchant#%E5%B0%8F%E7%A8%8B%E5%BA%8F%E4%B8%BA%E7%AC%AC%E4%B8%89%E6%96%B9%E8%BF%9B%E4%BB%B6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAppAddSubMerchantResponse> ExecuteAppsECPaySaaSAppAddSubMerchantAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSAppAddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.Signature))
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

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "add_sub_merchant");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSAddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/query_merchant_status 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/merchant#%E8%BF%9B%E4%BB%B6%E7%8A%B6%E6%80%81%E6%9F%A5%E8%AF%A2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSQueryMerchantStatusResponse> ExecuteAppsECPaySaaSQueryMerchantStatusAsync(this ByteDanceMicroAppClient client, Models.AppsECPaySaaSQueryMerchantStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "query_merchant_status");

            return await client.SendRequestWithJsonAsync<Models.AppsECPaySaaSQueryMerchantStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region V1
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_order 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayV1CreateOrderResponse> ExecuteAppsECPayV1CreateOrderAsync(this ByteDanceMicroAppClient client, Models.AppsECPayV1CreateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_order");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayV1CreateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_order 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayV1QueryOrderResponse> ExecuteAppsECPayV1QueryOrderAsync(this ByteDanceMicroAppClient client, Models.AppsECPayV1QueryOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_order");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayV1QueryOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_refund 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayV1CreateRefundResponse> ExecuteAppsECPayV1CreateRefundAsync(this ByteDanceMicroAppClient client, Models.AppsECPayV1CreateRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_refund");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayV1CreateRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_refund 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayV1QueryRefundResponse> ExecuteAppsECPayV1QueryRefundAsync(this ByteDanceMicroAppClient client, Models.AppsECPayV1QueryRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_refund");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayV1QueryRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/settle 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayV1SettleResponse> ExecuteAppsECPayV1SettleAsync(this ByteDanceMicroAppClient client, Models.AppsECPayV1SettleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "settle");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayV1SettleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_settle 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/server-doc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayV1QuerySettleResponse> ExecuteAppsECPayV1QuerySettleAsync(this ByteDanceMicroAppClient client, Models.AppsECPayV1QuerySettleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_settle");

            return await client.SendRequestWithJsonAsync<Models.AppsECPayV1QuerySettleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [GET] /apps/ecpay/bill 接口。</para>
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

            if (string.IsNullOrEmpty(request.AppId))
                request.AppId = client.Credentials.AppId;

            if (string.IsNullOrEmpty(request.Signature))
                request.Signature = client.GenerateRequestSignature(request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apps", "ecpay", "bill");

            return await client.SendRequestWithJsonAsync<Models.AppsBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
