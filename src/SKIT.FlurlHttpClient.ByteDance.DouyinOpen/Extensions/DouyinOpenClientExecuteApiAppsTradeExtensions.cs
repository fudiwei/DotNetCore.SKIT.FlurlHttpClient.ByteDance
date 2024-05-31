using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteApiAppsTradeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/order/query_item_order_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/query-info/query-item-info ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/query-info/query-item-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeOrderQueryItemOrderInfoV2Response> ExecuteAppsTradeOrderQueryItemOrderInfoV2Async(this DouyinOpenClient client, Models.AppsTradeOrderQueryItemOrderInfoV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "order", "query_item_order_info")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeOrderQueryItemOrderInfoV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/order/query_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/query-info/query-order ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/query-info/query-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeOrderQueryOrderV2Response> ExecuteAppsTradeOrderQueryOrderV2Async(this DouyinOpenClient client, Models.AppsTradeOrderQueryOrderV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "order", "query_order")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeOrderQueryOrderV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/order/query_cps 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/query-info/query-cps ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/query-info/query-cps ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeOrderQueryCPSV2Response> ExecuteAppsTradeOrderQueryCPSV2Async(this DouyinOpenClient client, Models.AppsTradeOrderQueryCPSV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "order", "query_cps")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeOrderQueryCPSV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/order/create_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/pre-order/create-order ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/pre-order/create-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeOrderCreateOrderV2Response> ExecuteAppsTradeOrderCreateOrderV2Async(this DouyinOpenClient client, Models.AppsTradeOrderCreateOrderV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "order", "create_order")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeOrderCreateOrderV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/order/close_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/pre-order/close_order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeOrderCloseOrderV2Response> ExecuteAppsTradeOrderCloseOrderV2Async(this DouyinOpenClient client, Models.AppsTradeOrderCloseOrderV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "order", "close_order")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeOrderCloseOrderV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/fulfillment/delivery_prepare 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/fulfillment/douyin-code/delivery-prepare ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/douyin-code/delivery-preparation ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeFulfillmentDeliveryPrepareV2Response> ExecuteAppsTradeFulfillmentDeliveryPrepareV2Async(this DouyinOpenClient client, Models.AppsTradeFulfillmentDeliveryPrepareV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "fulfillment", "delivery_prepare")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeFulfillmentDeliveryPrepareV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/fulfillment/delivery_verify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/fulfillment/douyin-code/delivery-verify ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/douyin-code/delivery-verify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeFulfillmentDeliveryVerifyV2Response> ExecuteAppsTradeFulfillmentDeliveryVerifyV2Async(this DouyinOpenClient client, Models.AppsTradeFulfillmentDeliveryVerifyV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "fulfillment", "delivery_verify")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeFulfillmentDeliveryVerifyV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/fulfillment/verify_cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/fulfillment/douyin-code/verify-cancel ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/fulfillment/third-code/verify-cancel ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeFulfillmentVerifyCancelV2Response> ExecuteAppsTradeFulfillmentVerifyCancelV2Async(this DouyinOpenClient client, Models.AppsTradeFulfillmentVerifyCancelV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "fulfillment", "verify_cancel")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeFulfillmentVerifyCancelV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/fulfillment/push_delivery 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/fulfillment/third-code/push-delivery ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/third-party-code/push-delivery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeFulfillmentPushDeliveryV2Response> ExecuteAppsTradeFulfillmentPushDeliveryV2Async(this DouyinOpenClient client, Models.AppsTradeFulfillmentPushDeliveryV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "fulfillment", "push_delivery")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeFulfillmentPushDeliveryV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/fulfillment/query_user_certificates 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/fulfill-tool/query-user-certificates ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeFulfillmentQueryUserCertificatesV2Response> ExecuteAppsTradeFulfillmentQueryUserCertificatesV2Async(this DouyinOpenClient client, Models.AppsTradeFulfillmentQueryUserCertificatesV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "fulfillment", "query_user_certificates")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeFulfillmentQueryUserCertificatesV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/fulfillment/order_can_use 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/fulfill-tool/order-can-use ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeFulfillmentOrderCanUseV2Response> ExecuteAppsTradeFulfillmentOrderCanUseV2Async(this DouyinOpenClient client, Models.AppsTradeFulfillmentOrderCanUseV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "fulfillment", "order_can_use")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeFulfillmentOrderCanUseV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/settle/create_settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/settlement/init-settle ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeSettleCreateSettleV2Response> ExecuteAppsTradeSettleCreateSettleV2Async(this DouyinOpenClient client, Models.AppsTradeSettleCreateSettleV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "settle", "create_settle")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeSettleCreateSettleV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/settle/query_settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/settlement/query-settle ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/settlement/query-settle ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeSettleQuerySettleV2Response> ExecuteAppsTradeSettleQuerySettleV2Async(this DouyinOpenClient client, Models.AppsTradeSettleQuerySettleV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "settle", "query_settle")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeSettleQuerySettleV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/refund/create_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/refund/apply ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/refund/init-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeRefundCreateRefundV2Response> ExecuteAppsTradeRefundCreateRefundV2Async(this DouyinOpenClient client, Models.AppsTradeRefundCreateRefundV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "refund", "create_refund")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeRefundCreateRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/refund/query_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/trading/refund/query-refund ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/refund/query-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeRefundQueryRefundV2Response> ExecuteAppsTradeRefundQueryRefundV2Async(this DouyinOpenClient client, Models.AppsTradeRefundQueryRefundV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "refund", "query_refund")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeRefundQueryRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/refund/merchant_audit_callback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/agency-trade-system/refund/audit-callback ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/refund/audit-callback ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeRefundMerchantAuditCallbackV2Response> ExecuteAppsTradeRefundMerchantAuditCallbackV2Async(this DouyinOpenClient client, Models.AppsTradeRefundMerchantAuditCallbackV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "refund", "merchant_audit_callback")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeRefundMerchantAuditCallbackV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/book/create_book 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/book/create-book-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeBookCreateBookV2Response> ExecuteAppsTradeBookCreateBookV2Async(this DouyinOpenClient client, Models.AppsTradeBookCreateBookV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "book", "create_book")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeBookCreateBookV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/book/book_result_callback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/book/book-result-callback ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeBookResultCallbackV2Response> ExecuteAppsTradeBookResultCallbackV2Async(this DouyinOpenClient client, Models.AppsTradeBookResultCallbackV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "book", "book_result_callback")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeBookResultCallbackV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/book/merchant_cancel_book 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/book/merchant-cancel-book ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeBookMerchantCancelBookV2Response> ExecuteAppsTradeBookMerchantCancelBookV2Async(this DouyinOpenClient client, Models.AppsTradeBookMerchantCancelBookV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "book", "merchant_cancel_book")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeBookMerchantCancelBookV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/book/user_cancel_book 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/book/user-cancel-book ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeBookUserCancelBookV2Response> ExecuteAppsTradeBookUserCancelBookV2Async(this DouyinOpenClient client, Models.AppsTradeBookUserCancelBookV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "book", "user_cancel_book")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeBookUserCancelBookV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/book/query_book 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/book/query-book ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeBookQueryBookV2Response> ExecuteAppsTradeBookQueryBookV2Async(this DouyinOpenClient client, Models.AppsTradeBookQueryBookV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "book", "query_book")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeBookQueryBookV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
