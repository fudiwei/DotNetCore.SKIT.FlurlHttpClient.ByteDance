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
        #region Fulfilment
        #region Fulfilment/Certificate
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

        #region Fulfilment/ReserveCode
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/reserve_code/batch_import 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/reservecode/batchimport </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "reserve_code", "batch_import")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentReserveCodeBatchImportV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/fulfilment/reserve_code/bind_order_info 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/reservecode/bind.order.info </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "fulfilment", "reserve_code", "bind_order_info")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeFulfilmentReserveCodeBindOrderInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Goods
        #region Goods/Calendar
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/calendar_static_attr_group/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/savecalendar </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "calendar_static_attr_group", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/calendar_stock_group/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/savestock </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "calendar_stock_group", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsCalendarStockGroupSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/calendar_amount_group/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/saveamount </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "calendar_amount_group", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsCalendarAmountGroupSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Goods/Category
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/category/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/category.get </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "category", "get")
                .WithHeader("access-token", request.AccessToken);

            if (request.AccountId != null)
                flurlReq.SetQueryParam("account_id", request.AccountId);

            if (request.ParentCategoryId != null)
                flurlReq.SetQueryParam("category_id", request.ParentCategoryId.Value);

            if (request.QueryType != null)
                flurlReq.SetQueryParam("query_category_type", request.QueryType.Value);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsCategoryGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Goods/Product
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/product/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/save </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "product", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/product/free_audit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/free.audit </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "product", "free_audit")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductFreeAuditV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/product/operate 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/operate </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "product", "operate")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductOperateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/draft/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/query </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "draft", "query")
                .WithHeader("access-token", request.AccessToken);

            if (request.AccountId != null)
                flurlReq.SetQueryParam("account_id", request.AccountId);

            if (request.Status != null)
                flurlReq.SetQueryParam("status", request.Status.Value);

            if (request.PageCursor != null)
                flurlReq.SetQueryParam("cursor", request.PageCursor);

            if (request.PageSize != null)
                flurlReq.SetQueryParam("count", request.PageSize.Value);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductDraftQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/draft/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/draft.get </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "draft", "get")
                .WithHeader("access-token", request.AccessToken);

            if (request.AccountId != null)
                flurlReq.SetQueryParam("account_id", request.AccountId);

            if (request.ProductIdList != null)
                flurlReq.SetQueryParam("product_ids", string.Join(",", request.ProductIdList));

            if (request.OutProductIdList != null)
                flurlReq.SetQueryParam("out_ids", string.Join(",", request.OutProductIdList));

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductDraftGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/online/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/online.query </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "online", "query")
                .WithHeader("access-token", request.AccessToken);

            if (request.AccountId != null)
                flurlReq.SetQueryParam("account_id", request.AccountId);

            if (request.Status != null)
                flurlReq.SetQueryParam("status", request.Status.Value);

            if (request.PageCursor != null)
                flurlReq.SetQueryParam("cursor", request.PageCursor);

            if (request.PageSize != null)
                flurlReq.SetQueryParam("count", request.PageSize.Value);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductOnlineQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/product/online/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/online.get </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "product", "online", "get")
                .WithHeader("access-token", request.AccessToken);

            if (request.AccountId != null)
                flurlReq.SetQueryParam("account_id", request.AccountId);

            if (request.ProductIdList != null)
                flurlReq.SetQueryParam("product_ids", string.Join(",", request.ProductIdList));

            if (request.OutProductIdList != null)
                flurlReq.SetQueryParam("out_ids", string.Join(",", request.OutProductIdList));

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsProductOnlineGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Goods/SKU
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/sku/batch_save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/goods.batch.save </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "sku", "batch_save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsSKUBatchSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Goods/SPU
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/spu/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/savespu </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "spu", "save")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsSPUSaveV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Goods/Stock
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/goods/stock/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/batch.save </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "goods", "stock", "sync")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsStockSyncV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Goods/Template
        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/goods/template/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/goods/template.get </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "goods", "template", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("product_type", request.ProductType)
                .SetQueryParam("category_id", request.CategoryId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeGoodsTemplateGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
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

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/member/unionid/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/unionidget </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "member", "unionid", "get")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeMemberUnionIdGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region POI
        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/sync 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poisync </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "sync")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOISyncV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/update 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poi.update </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "update")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOIUpdateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/claim 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poi.claim </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "claim")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOIClaimV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/poi/decorate 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/poi.decorate </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "poi", "decorate")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOIDecorateV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/poi/task/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/task.query </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "poi", "task", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("task_ids", string.Join(",", request.TaskIdList));

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOITaskQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /goodlife/v1/poi/match/task/submit 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/match.tasksubmit </para>
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
                .CreateRequest(request, HttpMethod.Post, "goodlife", "v1", "poi", "match", "task", "submit")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOIMatchTaskSubmitV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/poi/match/task/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/match.taskquery </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "poi", "match", "task", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("task_id", request.TaskId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOIMatchTaskQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/poi/match/relation/query 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/life.capacity.shop/match.relationquery </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "poi", "match", "relation", "query")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("ext_ids", string.Join(",", request.POIExternalIdList));

            return await client.SendRequestWithJsonAsync<Models.GoodLifePOIMatchRelationQueryV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
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

            if (request.OrderExternalId != null)
                flurlReq.SetQueryParam("ext_order_id", request.OrderExternalId);

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

        /// <summary>
        /// <para>异步调用 [GET] /goodlife/v1/trade/book/get 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/presale/bookingorderquery </para>
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
                .CreateRequest(request, HttpMethod.Get, "goodlife", "v1", "trade", "book", "get")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("account_id", request.AccountId);

            if (request.BookId != null)
                flurlReq.SetQueryParam("book_id", request.BookId);

            if (request.OrderId != null)
                flurlReq.SetQueryParam("order_id", request.OrderId);

            return await client.SendRequestWithJsonAsync<Models.GoodLifeTradeBookGetV1Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
