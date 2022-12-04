using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteGoodLifeExtensions
    {
        #region Shop
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/shop/poi/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/shop.query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeShopPOIQueryV1Response> ExecuteGoodLifeShopPOIQueryV1Async(this DouyinOpenClient client, Models.GoodLifeShopPOIQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "shop", "poi", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("account_id", request.AccountId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeShopPOIQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Fulfilment
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/prepare 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.prepare </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificatePrepareV1Response> ExecuteGoodLifeFulfilmentCertificatePrepareV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentCertificatePrepareV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "prepare")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_data", request.EncryptedData)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificatePrepareV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.get </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateGetV1Response> ExecuteGoodLifeFulfilmentCertificateGetV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentCertificateGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_code", request.EncryptedCode)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/certificate/cancel 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.cancel </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateCancelV1Response> ExecuteGoodLifeFulfilmentCertificateCancelV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentCertificateCancelV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "certificate", "cancel")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateCancelV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/certificate/verify 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.verify </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateVerifyV1Response> ExecuteGoodLifeFulfilmentCertificateVerifyV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentCertificateVerifyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "certificate", "verify")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateVerifyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateQueryV1Response> ExecuteGoodLifeFulfilmentCertificateQueryV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentCertificateQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_code", request.EncryptedCode)
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/verify_record/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/certificate.verifyrecord.query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentCertificateVerifyRecordQueryV1Response> ExecuteGoodLifeFulfilmentCertificateVerifyRecordQueryV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentCertificateVerifyRecordQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "verify_record", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("account_id", request.AccountId);

            if (request.POIIdList != null)
                flurlReq.SetQueryParam("poi_ids", string.Join(",", request.POIIdList));

            if (request.StartTimestamp != null)
                flurlReq.SetQueryParam("start_time", request.StartTimestamp);

            if (request.EndTimestamp != null)
                flurlReq.SetQueryParam("end_time", request.EndTimestamp);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentCertificateVerifyRecordQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Settle
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/query_record_by_cert 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/ledger.query-record-by-cert </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeSettleLedgerQueryRecordByCertificateV1Response> ExecuteGoodLifeSettleLedgerQueryRecordByCertificateV1Async(this DouyinOpenClient client, Models.GoodLifeSettleLedgerQueryRecordByCertificateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "query_record_by_cert")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("certificate_ids", string.Join(",", request.CertificateIdList));

            return await client.SendRequestWithJsonAsync<Models.GoodLifeSettleLedgerQueryRecordByCertificateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/detailed_query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/detailedquery </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeSettleLedgerDetailedQueryV1Response> ExecuteGoodLifeSettleLedgerDetailedQueryV1Async(this DouyinOpenClient client, Models.GoodLifeSettleLedgerDetailedQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "detailed_query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeSettleLedgerDetailedQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/merchantquery </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeSettleLedgerQueryV1Response> ExecuteGoodLifeSettleLedgerQueryV1Async(this DouyinOpenClient client, Models.GoodLifeSettleLedgerQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeSettleLedgerQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Member
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/member/user/update 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/update.info </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeMemberUserUpdateV1Response> ExecuteGoodLifeMemberUserUpdateV1Async(this DouyinOpenClient client, Models.GoodLifeMemberUserUpdateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "member", "user", "update")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeMemberUserUpdateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Trade
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/trade/order/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/order.query/query </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeTradeOrderQueryV1Response> ExecuteGoodLifeTradeOrderQueryV1Async(this DouyinOpenClient client, Models.GoodLifeTradeOrderQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "trade", "order", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize);

            if (request.OrderId != null)
                flurlReq.SetQueryParam("order_id", request.OrderId);

            if (request.ExternalOrderId != null)
                flurlReq.SetQueryParam("ext_order_id", request.ExternalOrderId);

            if (request.OpenId != null)
                flurlReq.SetQueryParam("open_id", request.OpenId);

            if (request.OrderStatus != null)
                flurlReq.SetQueryParam("order_status", request.OrderStatus);

            if (request.CreateOrderStartTimestamp != null)
                flurlReq.SetQueryParam("create_order_start_time", request.CreateOrderStartTimestamp);

            if (request.CreateOrderEndTimestamp != null)
                flurlReq.SetQueryParam("create_order_end_time", request.CreateOrderEndTimestamp);

            if (request.UpdateOrderStartTimestamp != null)
                flurlReq.SetQueryParam("update_order_start_time", request.UpdateOrderStartTimestamp);

            if (request.UpdateOrderEndTimestamp != null)
                flurlReq.SetQueryParam("update_order_end_time", request.UpdateOrderEndTimestamp);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeTradeOrderQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
