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
    public static class DouyinMicroAppClientExecuteLegacyAppsECPayExtensions
    {
        private static string GenerateRequestSignature<TRequest>(DouyinMicroAppClient client, TRequest request, Dictionary<string, string?>? extraParams = null)
            where TRequest : DouyinMicroAppRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            /*
             * REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/ecpay/TE/#%E4%B8%89%E3%80%81%E7%AD%BE%E5%90%8D-demo
             */

            string json = client.JsonSerializer.Serialize(request);
            IList<string> tempList = new List<string>() { client.Credentials.ECPaySalt! };
            IDictionary<string, string?> paramMap = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string?>>(json)!;

            if (extraParams is not null)
            {
                foreach (KeyValuePair<string, string?> item in extraParams)
                {
                    paramMap[item.Key] = item.Value;
                }
            }

            foreach (KeyValuePair<string, string?> item in paramMap)
            {
                string key = item.Key;
                string? value = item.Value?.Trim();

                if ("app_id".Equals(key) ||
                    "thirdparty_id".Equals(key) ||
                    "sign".Equals(key) ||
                    "other_settle_params".Equals(key))
                {
                    continue;
                }

                if (value is not null && value.StartsWith("\"") && value.EndsWith("\""))
                {
                    value = value.Substring(1, value.Length - 1).Trim();
                }

                if (string.IsNullOrEmpty(value) || "null".Equals(value))
                {
                    continue;
                }

                tempList.Add(value!);
            }

            string[] tempArray = tempList.ToArray();
            Array.Sort(tempArray, StringComparer.Ordinal);

            string plainText = string.Join("&", tempArray);
            return Utilities.MD5Utility.Hash(plainText).Value!.ToLower();
        }

        #region Bills
        /// <summary>
        /// <para>异步调用 [GET] /apps/bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/bills/bill ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsBillsResponse> ExecuteAppsBillsAsync(this DouyinMicroAppClient client, Models.AppsBillsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
            {
                request.Signature = GenerateRequestSignature(client, request, new()
                {
                    { "merchant_id" , request.MerchantId },
                    { "bill_date" , request.DateString },
                    { "bill_type" , request.BillType }
                });
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "bills")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "bills"))
                .SetQueryParam("app_id", request.AppId)
                .SetQueryParam("merchant_id", request.MerchantId)
                .SetQueryParam("bill_date", request.DateString)
                .SetQueryParam("bill_type", request.BillType)
                .SetQueryParam("sign", request.Signature);

            if (request.ComponentAppId is not null)
                flurlReq.SetQueryParam("thirdparty_id", request.ComponentAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsBillsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/fund/bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/bills/fundbill ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsFundBillsResponse> ExecuteAppsFundBillsAsync(this DouyinMicroAppClient client, Models.AppsFundBillsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
            {
                request.Signature = GenerateRequestSignature(client, request, new()
                {
                    { "merchant_id" , request.MerchantId },
                    { "bill_date" , request.DateString },
                    { "account_type" , request.AccountType },
                    { "payment_type" , request.PaymentType },
                    { "trade_type" , request.TradeType },
                });
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "fund", "bills")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "fund", "bills"))
                .SetQueryParam("app_id", request.AppId)
                .SetQueryParam("merchant_id", request.MerchantId)
                .SetQueryParam("bill_date", request.DateString)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("payment_type", request.PaymentType)
                .SetQueryParam("trade_type", request.TradeType)
                .SetQueryParam("sign", request.Signature);

            if (request.ComponentAppId is not null)
                flurlReq.SetQueryParam("thirdparty_id", request.ComponentAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsFundBillsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/pay-list/pay ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayCreateOrderV1Response> ExecuteAppsECPayCreateOrderV1Async(this DouyinMicroAppClient client, Models.AppsECPayCreateOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_order")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "create_order"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayCreateOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/pay-list/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQueryOrderV1Response> ExecuteAppsECPayQueryOrderV1Async(this DouyinMicroAppClient client, Models.AppsECPayQueryOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_order")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "query_order"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayQueryOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/refund-list/refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayCreateRefundV1Response> ExecuteAppsECPayCreateRefundV1Async(this DouyinMicroAppClient client, Models.AppsECPayCreateRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_refund")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "create_refund"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayCreateRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/refund-list/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQueryRefundV1Response> ExecuteAppsECPayQueryRefundV1Async(this DouyinMicroAppClient client, Models.AppsECPayQueryRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_refund")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "query_refund"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayQueryRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/settlements/settlement ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySettleV1Response> ExecuteAppsECPaySettleV1Async(this DouyinMicroAppClient client, Models.AppsECPaySettleV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "settle")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "settle"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySettleV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/settlements/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQuerySettleV1Response> ExecuteAppsECPayQuerySettleV1Async(this DouyinMicroAppClient client, Models.AppsECPayQuerySettleV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_settle")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "query_settle"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayQuerySettleV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/create_return 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/return-settle/ReturnSettle ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayCreateReturnV1Response> ExecuteAppsECPayCreateReturnV1Async(this DouyinMicroAppClient client, Models.AppsECPayCreateReturnV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "create_return")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "create_return"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayCreateReturnV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_return 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/return-settle/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQueryReturnV1Response> ExecuteAppsECPayQueryReturnV1Async(this DouyinMicroAppClient client, Models.AppsECPayQueryReturnV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_return")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "query_return"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayQueryReturnV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/v1/query_platform_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/settlements/auto-settle/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPayQueryPlatformOrderV1Response> ExecuteAppsECPayQueryPlatformOrderV1Async(this DouyinMicroAppClient client, Models.AppsECPayQueryPlatformOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "v1", "query_platform_order")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "v1", "query_platform_order"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPayQueryPlatformOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SaaS
        #region SaaS - Apply
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/create_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/apply/create ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSCreateMerchantResponse> ExecuteAppsECPaySaaSCreateMerchantAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSCreateMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "create_merchant")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "create_merchant"));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSCreateMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/image_upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/apply/image-upload ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSImageUploadResponse> ExecuteAppsECPaySaaSImageUploadAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "image_upload")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "image_upload"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/query_merchant_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/apply/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSQueryMerchantStatusResponse> ExecuteAppsECPaySaaSQueryMerchantStatusAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSQueryMerchantStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "query_merchant_status")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "query_merchant_status"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSQueryMerchantStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SaaS - PageLinks
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/add_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/apply/merchant ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/withdraw/merchant ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAddMerchantResponse> ExecuteAppsECPaySaaSAddMerchantAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSAddMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId is null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "add_merchant")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "add_merchant"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSAddMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/get_app_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/apply/app-merchant ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/withdraw/app-merchant ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSGetAppMerchantResponse> ExecuteAppsECPaySaaSGetAppMerchantAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSGetAppMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId is null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "get_app_merchant")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "get_app_merchant"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSGetAppMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/app_add_sub_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/apply/sub-merchant ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/withdraw/app-sub-merchant ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAppAddSubMerchantResponse> ExecuteAppsECPaySaaSAppAddSubMerchantAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSAppAddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "app_add_sub_merchant")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "app_add_sub_merchant"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSAppAddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/add_sub_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/apply/sub-merchant ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/page-links/withdraw/sub-merchant ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSAddSubMerchantResponse> ExecuteAppsECPaySaaSAddSubMerchantAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSAddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId is null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "add_sub_merchant")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "add_sub_merchant"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSAddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SaaS - Withdraw
        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/query_merchant_balance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/withdraw/query-balance ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSQueryMerchantBalanceResponse> ExecuteAppsECPaySaaSQueryMerchantBalanceAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSQueryMerchantBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "query_merchant_balance")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "query_merchant_balance"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSQueryMerchantBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/merchant_withdraw 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/withdraw/merchant-withdraw ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSMerchantWithdrawResponse> ExecuteAppsECPaySaaSMerchantWithdrawAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSMerchantWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "merchant_withdraw")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "merchant_withdraw"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSMerchantWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/ecpay/saas/query_withdraw_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/ecpay/withdraw/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsECPaySaaSQueryWithdrawOrderResponse> ExecuteAppsECPaySaaSQueryWithdrawOrderAsync(this DouyinMicroAppClient client, Models.AppsECPaySaaSQueryWithdrawOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "ecpay", "saas", "query_withdraw_order")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "ecpay", "saas", "query_withdraw_order"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsECPaySaaSQueryWithdrawOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion
    }
}
