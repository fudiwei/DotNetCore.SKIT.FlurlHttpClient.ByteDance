using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    // TODO: 独立化 ExtendedSDK
    public static class DouyinOpenClientExecuteGoodLifeExtensions
    {
        #region Aftersale
        #region Aftersale/Audit
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/after_sale/audit/notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/refundresult ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeAftersaleAuditNotifyV1Response> ExecuteGoodLifeAftersaleAuditNotifyV1Async(this DouyinOpenClient client, Models.GoodLifeAftersaleAuditNotifyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "after_sale", "audit", "notify")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeAftersaleAuditNotifyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Aftersale/Order
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/after_sale/order/merchant_reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/rejectorder ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeAftersaleOrderMerchantRejectV1Response> ExecuteGoodLifeAftersaleOrderMerchantRejectV1Async(this DouyinOpenClient client, Models.GoodLifeAftersaleOrderMerchantRejectV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "after_sale", "order", "merchant_reject")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeAftersaleOrderMerchantRejectV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/after_sale/order/apply_refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/applyrefund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeAftersaleOrderApplyRefundV1Response> ExecuteGoodLifeAftersaleOrderApplyRefundV1Async(this DouyinOpenClient client, Models.GoodLifeAftersaleOrderApplyRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "after_sale", "order", "apply_refund")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeAftersaleOrderApplyRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Fulfilment
        #region Fulfilment/Certificate
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/prepare 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.prepare ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "prepare")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_data", request.EncryptedData)
                .SetQueryParam("code", request.Code);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentCertificatePrepareV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.get ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_code", request.EncryptedCode)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentCertificateGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/certificate/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.cancel ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "certificate", "cancel")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentCertificateCancelV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/certificate/verify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.verify ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "certificate", "verify")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentCertificateVerifyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.fulfilment/certificate.query ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("encrypted_code", request.EncryptedCode)
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentCertificateQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/fulfilment/certificate/verify_record/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/certificate.verifyrecord.query ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "fulfilment", "certificate", "verify_record", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("poi_ids", request.POIIdList is null ? null : string.Join(",", request.POIIdList))
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentCertificateVerifyRecordQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Fulfilment/Certificate
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/distribution/order/sync_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/syncstatus ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentDistributionOrderSyncStatusV1Response> ExecuteGoodLifeFulfilmentDistributionOrderSyncStatusV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentDistributionOrderSyncStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "distribution", "order", "sync_status")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentDistributionOrderSyncStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Fulfilment/ReserveCode
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/reserve_code/batch_import 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/reservecode/batchimport ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentReserveCodeBatchImportV1Response> ExecuteGoodLifeFulfilmentReserveCodeBatchImportV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentReserveCodeBatchImportV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "reserve_code", "batch_import")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentReserveCodeBatchImportV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/reserve_code/bind_order_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/reservecode/bind.order.info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeFulfilmentReserveCodeBindOrderInfoV1Response> ExecuteGoodLifeFulfilmentReserveCodeBindOrderInfoV1Async(this DouyinOpenClient client, Models.GoodLifeFulfilmentReserveCodeBindOrderInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "reserve_code", "bind_order_info")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeFulfilmentReserveCodeBindOrderInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Goods
        #region Goods/Calendar
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/calendar_static_attr_group/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/savecalendar ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Response> ExecuteGoodLifeGoodsCalendarStaticAttributeGroupSaveV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "calendar_static_attr_group", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/calendar_stock_group/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/savestock ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsCalendarStockGroupSaveV1Response> ExecuteGoodLifeGoodsCalendarStockGroupSaveV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsCalendarStockGroupSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "calendar_stock_group", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsCalendarStockGroupSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/calendar_amount_group/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/saveamount ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsCalendarAmountGroupSaveV1Response> ExecuteGoodLifeGoodsCalendarAmountGroupSaveV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsCalendarAmountGroupSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "calendar_amount_group", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsCalendarAmountGroupSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Goods/Category
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/category/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/category.get ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsCategoryGetV1Response> ExecuteGoodLifeGoodsCategoryGetV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsCategoryGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "category", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("category_id", request.ParentCategoryId)
                .SetQueryParam("query_category_type", request.QueryType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsCategoryGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Goods/Product
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/product/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/save ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductSaveV1Response> ExecuteGoodLifeGoodsProductSaveV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "product", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/product/free_audit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/free.audit ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductFreeAuditV1Response> ExecuteGoodLifeGoodsProductFreeAuditV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductFreeAuditV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "product", "free_audit")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductFreeAuditV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/product/operate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/operate ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductOperateV1Response> ExecuteGoodLifeGoodsProductOperateV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductOperateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "product", "operate")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductOperateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/draft/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductDraftQueryV1Response> ExecuteGoodLifeGoodsProductDraftQueryV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductDraftQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "draft", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("status", request.Status)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductDraftQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/draft/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/draft.get ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductDraftGetV1Response> ExecuteGoodLifeGoodsProductDraftGetV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductDraftGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "draft", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("product_ids", request.ProductIdList is null ? null : string.Join(",", request.ProductIdList))
                .SetQueryParam("out_ids", request.OutProductIdList is null ? null : string.Join(",", request.OutProductIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductDraftGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/online/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/online.query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductOnlineQueryV1Response> ExecuteGoodLifeGoodsProductOnlineQueryV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductOnlineQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "online", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("status", request.Status)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductOnlineQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/online/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/online.get ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsProductOnlineGetV1Response> ExecuteGoodLifeGoodsProductOnlineGetV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsProductOnlineGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "online", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("product_ids", request.ProductIdList is null ? null : string.Join(",", request.ProductIdList))
                .SetQueryParam("out_ids", request.OutProductIdList is null ? null : string.Join(",", request.OutProductIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsProductOnlineGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Goods/SKU
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/sku/batch_save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/goods.batch.save ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsSKUBatchSaveV1Response> ExecuteGoodLifeGoodsSKUBatchSaveV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsSKUBatchSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "sku", "batch_save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsSKUBatchSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Goods/SPU
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/spu/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/savespu ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsSPUSaveV1Response> ExecuteGoodLifeGoodsSPUSaveV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsSPUSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "spu", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsSPUSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Goods/Stock
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/stock/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/batch.save ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsStockSyncV1Response> ExecuteGoodLifeGoodsStockSyncV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsStockSyncV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "stock", "sync")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsStockSyncV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Goods/Template
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/template/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/template.get ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeGoodsTemplateGetV1Response> ExecuteGoodLifeGoodsTemplateGetV1Async(this DouyinOpenClient client, Models.GoodLifeGoodsTemplateGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "template", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("product_type", request.ProductType)
                .SetQueryParam("category_id", request.CategoryId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeGoodsTemplateGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Member
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/member/user/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/update.info ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "member", "user", "update")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeMemberUserUpdateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/member/unionid/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/unionidget ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeMemberUnionIdGetV1Response> ExecuteGoodLifeMemberUnionIdGetV1Async(this DouyinOpenClient client, Models.GoodLifeMemberUnionIdGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "member", "unionid", "get")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeMemberUnionIdGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Partner
        #region Partner/Commission
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/partner/product_commission/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/productcommissionsave ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerProductCommissionSaveV1Response> ExecuteGoodLifePartnerProductCommissionSaveV1Async(this DouyinOpenClient client, Models.GoodLifePartnerProductCommissionSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "partner", "product_commission", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerProductCommissionSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/partner/product_commission/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/productcommissionquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerProductCommissionQueryV1Response> ExecuteGoodLifePartnerProductCommissionQueryV1Async(this DouyinOpenClient client, Models.GoodLifePartnerProductCommissionQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "partner", "product_commission", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerProductCommissionQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/partner/commission_record/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/commissionrecordquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerCommissionRecordQueryV1Response> ExecuteGoodLifePartnerCommissionRecordQueryV1Async(this DouyinOpenClient client, Models.GoodLifePartnerCommissionRecordQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "partner", "commission_record", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerCommissionRecordQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/partner/commission_record/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/commissionrecordget ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerCommissionRecordGetV1Response> ExecuteGoodLifePartnerCommissionRecordGetV1Async(this DouyinOpenClient client, Models.GoodLifePartnerCommissionRecordGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "partner", "commission_record", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("record_id", request.RecordId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerCommissionRecordGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Partner/Order
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/partner/order/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/create ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerOrderCreateV1Response> ExecuteGoodLifePartnerOrderCreateV1Async(this DouyinOpenClient client, Models.GoodLifePartnerOrderCreateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "partner", "order", "create")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerOrderCreateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/partner/order/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/orderquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerOrderQueryV1Response> ExecuteGoodLifePartnerOrderQueryV1Async(this DouyinOpenClient client, Models.GoodLifePartnerOrderQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "partner", "order", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("cooperation_contents", request.CooperationContentType)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("status", request.Status)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("is_asc", request.IsSortByAsc.HasValue ? request.IsSortByAsc.Value ? "true" : "false" : null);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerOrderQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/partner/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/paterner/orderget ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePartnerOrderGetV1Response> ExecuteGoodLifePartnerOrderGetV1Async(this DouyinOpenClient client, Models.GoodLifePartnerOrderGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "partner", "order", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("without_product_items", request.IsWithoutProductItems.GetValueOrDefault() ? "true" : "false");

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePartnerOrderGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region POI
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poisync ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOISyncV1Response> ExecuteGoodLifePOISyncV1Async(this DouyinOpenClient client, Models.GoodLifePOISyncV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "sync")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOISyncV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poi.update ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOIUpdateV1Response> ExecuteGoodLifePOIUpdateV1Async(this DouyinOpenClient client, Models.GoodLifePOIUpdateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "update")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOIUpdateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/claim 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poi.claim ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOIClaimV1Response> ExecuteGoodLifePOIClaimV1Async(this DouyinOpenClient client, Models.GoodLifePOIClaimV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "claim")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOIClaimV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/decorate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poi.decorate ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOIDecorateV1Response> ExecuteGoodLifePOIDecorateV1Async(this DouyinOpenClient client, Models.GoodLifePOIDecorateV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "decorate")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOIDecorateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/poi/task/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/task.query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOITaskQueryV1Response> ExecuteGoodLifePOITaskQueryV1Async(this DouyinOpenClient client, Models.GoodLifePOITaskQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "poi", "task", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("task_ids", string.Join(",", request.TaskIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOITaskQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/match/task/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/match.tasksubmit ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOIMatchTaskSubmitV1Response> ExecuteGoodLifePOIMatchTaskSubmitV1Async(this DouyinOpenClient client, Models.GoodLifePOIMatchTaskSubmitV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "match", "task", "submit")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOIMatchTaskSubmitV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/poi/match/task/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/match.taskquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOIMatchTaskQueryV1Response> ExecuteGoodLifePOIMatchTaskQueryV1Async(this DouyinOpenClient client, Models.GoodLifePOIMatchTaskQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "poi", "match", "task", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("task_id", request.TaskId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOIMatchTaskQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/poi/match/relation/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/match.relationquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOIMatchRelationQueryV1Response> ExecuteGoodLifePOIMatchRelationQueryV1Async(this DouyinOpenClient client, Models.GoodLifePOIMatchRelationQueryV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "poi", "match", "relation", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("ext_ids", string.Join(",", request.POIExternalIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOIMatchRelationQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Goods/Crowd
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/crowd/save 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/crowdsave ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifePOICrowdSaveV1Response> ExecuteGoodLifePOICrowdSaveV1Async(this DouyinOpenClient client, Models.GoodLifePOICrowdSaveV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "crowd", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifePOICrowdSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Settle
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/query_record_by_cert 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/ledger.query-record-by-cert ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "query_record_by_cert")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("certificate_ids", string.Join(",", request.CertificateIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeSettleLedgerQueryRecordByCertificateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/detailed_query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/detailedquery ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "detailed_query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeSettleLedgerDetailedQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/detailed_query_by_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/detailedquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeSettleLedgerDetailedQueryByOrderV1Response> ExecuteGoodLifeSettleLedgerDetailedQueryByOrderV1Async(this DouyinOpenClient client, Models.GoodLifeSettleLedgerDetailedQueryByOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "detailed_query_by_order")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("order_ids", string.Join(",", request.OrderIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeSettleLedgerDetailedQueryByOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.billing/merchantquery ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeSettleLedgerQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/settle/ledger/query_by_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/querybyorder ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeSettleLedgerQueryByOrderV1Response> ExecuteGoodLifeSettleLedgerQueryByOrderV1Async(this DouyinOpenClient client, Models.GoodLifeSettleLedgerQueryByOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "settle", "ledger", "query_by_order")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("order_ids", string.Join(",", request.OrderIdList));

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeSettleLedgerQueryByOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Shop
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/shop/poi/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/shop.query ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "shop", "poi", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("page", request.PageNumber)
                .SetQueryParam("size", request.PageSize)
                .SetQueryParam("account_id", request.AccountId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeShopPOIQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Trade
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/trade/order/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/order.query/query ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/orderquery ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "trade", "order", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("ext_order_id", request.OrderExternalId)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("order_status", request.OrderStatus)
                .SetQueryParam("create_order_start_time", request.CreateOrderStartTimestamp)
                .SetQueryParam("create_order_end_time", request.CreateOrderEndTimestamp)
                .SetQueryParam("update_order_start_time", request.UpdateOrderStartTimestamp)
                .SetQueryParam("update_order_end_time", request.UpdateOrderEndTimestamp)
                .SetQueryParam("get_secret_number", request.RequireGetSecretNumber.HasValue ? request.RequireGetSecretNumber.Value ? "true" : "false" : null)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeTradeOrderQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/trade/book/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/bookingorderquery ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeTradeBookGetV1Response> ExecuteGoodLifeTradeBookGetV1Async(this DouyinOpenClient client, Models.GoodLifeTradeBookGetV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "goodlife", "v1", "trade", "book", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId)
                .SetQueryParam("book_id", request.BookId)
                .SetQueryParam("order_id", request.OrderId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeTradeBookGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/trade/buy/merchant_confirm_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/takeout/confirmorder ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GoodLifeTradeBuyMerchantConfirmOrderV1Response> ExecuteGoodLifeTradeBuyMerchantConfirmOrderV1Async(this DouyinOpenClient client, Models.GoodLifeTradeBuyMerchantConfirmOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "goodlife", "v1", "trade", "buy", "merchant_confirm_order")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GoodLifeTradeBuyMerchantConfirmOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
