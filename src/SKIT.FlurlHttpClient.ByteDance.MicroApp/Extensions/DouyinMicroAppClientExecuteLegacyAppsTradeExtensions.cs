using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteLegacyAppsTradeExtensions
    {
        private static IFlurlRequest WithByteAuthorization(this IFlurlRequest flurlRequest, string appId, string keyVersion, string publicKey)
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            /*
             * REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/invoke-api/common-parameters
             */

            return flurlRequest.BeforeCall(async (flurlCall) =>
            {
                string method = flurlCall.HttpRequestMessage.Method.ToString().ToUpper();
                string url = flurlCall.HttpRequestMessage.RequestUri!.PathAndQuery ?? string.Empty;
                string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
                string nonce = Guid.NewGuid().ToString("N");
                string body = await (flurlCall.HttpRequestMessage!.Content?.ReadAsStringAsync() ?? Task.FromResult(string.Empty)).ConfigureAwait(false);

                string signData = $"{method}\n{url}\n{timestamp}\n{nonce}\n{body}\n";
                string sign;

                try
                {
                    sign = Utilities.RSAUtility.SignWithSHA256(publicKey, signData).Value!;
                }
                catch (Exception ex)
                {
                    throw new DouyinMicroAppException("Failed to sign request. Please see the inner exception for more details.", ex);
                }

                flurlCall.Request.WithHeader("Byte-Authorization", $"SHA256-RSA2048 appid=\"{appId}\",nonce_str=\"{nonce}\",timestamp=\"{timestamp}\",key_version=\"{keyVersion}\",signature=\"{sign}\"");
            });
        }

        #region PreOrder
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/query_cps 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/pre-order/query-cps ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeQueryCPSV2Response> ExecuteAppsTradeQueryCPSV2Async(this DouyinMicroAppClient client, Models.AppsTradeQueryCPSV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "query_cps")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "query_cps"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeQueryCPSV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/query_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/pre-order/query-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeQueryOrderV2Response> ExecuteAppsTradeQueryOrderV2Async(this DouyinMicroAppClient client, Models.AppsTradeQueryOrderV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "query_order")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "query_order"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeQueryOrderV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/create_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/pre-order/create-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeCreateOrderV2Response> ExecuteAppsTradeCreateOrderV2Async(this DouyinMicroAppClient client, Models.AppsTradeCreateOrderV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "create_order")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "create_order"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeCreateOrderV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Refund
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/create_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/refund/apply ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeCreateRefundV2Response> ExecuteAppsTradeCreateRefundV2Async(this DouyinMicroAppClient client, Models.AppsTradeCreateRefundV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "create_refund")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "create_refund"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeCreateRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/query_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/refund/query-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeQueryRefundV2Response> ExecuteAppsTradeQueryRefundV2Async(this DouyinMicroAppClient client, Models.AppsTradeQueryRefundV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "query_refund")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "query_refund"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeQueryRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/merchant_audit_callback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/refund/audit-callback ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeMerchantAuditCallbackV2Response> ExecuteAppsTradeMerchantAuditCallbackV2Async(this DouyinMicroAppClient client, Models.AppsTradeMerchantAuditCallbackV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "merchant_audit_callback")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "merchant_audit_callback"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeMerchantAuditCallbackV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Settlement
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/create_settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/settlement/create-settle ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeCreateSettleV2Response> ExecuteAppsTradeCreateSettleV2Async(this DouyinMicroAppClient client, Models.AppsTradeCreateSettleV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "create_settle")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "create_settle"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeCreateSettleV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/query_settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/settlement/query-settle ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeQuerySettleV2Response> ExecuteAppsTradeQuerySettleV2Async(this DouyinMicroAppClient client, Models.AppsTradeQuerySettleV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "query_settle")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "query_settle"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeQuerySettleV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WriteOff
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/delivery_prepare 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/write-off/douyin-code/delivery-preparation ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeDeliveryPrepareV2Response> ExecuteAppsTradeDeliveryPrepareV2Async(this DouyinMicroAppClient client, Models.AppsTradeDeliveryPrepareV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "delivery_prepare")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "delivery_prepare"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeDeliveryPrepareV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/delivery_verify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/write-off/douyin-code/delivery-verify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeDeliveryVerifyV2Response> ExecuteAppsTradeDeliveryVerifyV2Async(this DouyinMicroAppClient client, Models.AppsTradeDeliveryVerifyV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "delivery_verify")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "delivery_verify"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeDeliveryVerifyV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/query_item_order_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/write-off/douyin-code/query-item-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeQueryItemOrderInfoV2Response> ExecuteAppsTradeQueryItemOrderInfoV2Async(this DouyinMicroAppClient client, Models.AppsTradeQueryItemOrderInfoV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "query_item_order_info")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "query_item_order_info"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeQueryItemOrderInfoV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/push_delivery 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/write-off/third-party-code/push-delivery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradePushDeliveryV2Response> ExecuteAppsTradePushDeliveryV2Async(this DouyinMicroAppClient client, Models.AppsTradePushDeliveryV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "push_delivery")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "trade", "v2", "push_delivery"))
                .WithHeader("access-token", request.AccessToken)
                .WithByteAuthorization(client.Credentials.AppId, client.Credentials.AppKeyVersion!, client.Credentials.AppPrivateKey!);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradePushDeliveryV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
