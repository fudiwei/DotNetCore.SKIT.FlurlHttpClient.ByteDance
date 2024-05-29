using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecutePromotionExtensions
    {
        #region Activity
        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/query_binded_user/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-mgmt/query-binded-user ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityQueryBindedUserV2Response> ExecutePromotionActivityQueryBindedUserV2Async(this DouyinMicroAppClient client, Models.PromotionActivityQueryBindedUserV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "query_binded_user/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityQueryBindedUserV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/bind_user_to_sidebar_activity/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-mgmt/bind-user-to-activity ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityBindUserToSidebarActivityV2Response> ExecutePromotionActivityBindUserToSidebarActivityV2Async(this DouyinMicroAppClient client, Models.PromotionActivityBindUserToSidebarActivityV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "bind_user_to_sidebar_activity/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityBindUserToSidebarActivityV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/upload_popup_screenshot/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/promotion-activity-management/upload-popup-screenshot ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityUploadPopupScreenshotV2Response> ExecutePromotionActivityUploadPopupScreenshotV2Async(this DouyinMicroAppClient client, Models.PromotionActivityUploadPopupScreenshotV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.ImageFileName) ?? "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "upload_popup_screenshot/")
                .WithHeader("access-token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "popup_image");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.ActivityId)), "activity_id");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.PopupType.ToString())), "popup_type");

            return await client.SendFlurlRequestAsync<Models.PromotionActivityUploadPopupScreenshotV2Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/add_self_test_accounts/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/promotion-activity-management/add-self-test-accounts ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityAddSelfTestAccountsV2Response> ExecutePromotionActivityAddSelfTestAccountsV2Async(this DouyinMicroAppClient client, Models.PromotionActivityAddSelfTestAccountsV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "add_self_test_accounts/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityAddSelfTestAccountsV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/create_promotion_activity/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/promotion-activity-management/add-self-test-accounts ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityCreatePromotionActivityV2Response> ExecutePromotionActivityCreatePromotionActivityV2Async(this DouyinMicroAppClient client, Models.PromotionActivityCreatePromotionActivityV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "create_promotion_activity/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityCreatePromotionActivityV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/modify_promotion_activity/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/promotion-activity-management/modify-promotion-activity ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityModifyPromotionActivityV2Response> ExecutePromotionActivityModifyPromotionActivityV2Async(this DouyinMicroAppClient client, Models.PromotionActivityModifyPromotionActivityV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "modify_promotion_activity/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityModifyPromotionActivityV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/update_promotion_activity_status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/promotion-activity-management/update-promotion-activity-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityUpdatePromotionActivityStatusV2Response> ExecutePromotionActivityUpdatePromotionActivityStatusV2Async(this DouyinMicroAppClient client, Models.PromotionActivityUpdatePromotionActivityStatusV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "update_promotion_activity_status/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityUpdatePromotionActivityStatusV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/activity/query_promotion_activity/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/promotion-activity-management/query-promotion-activity ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionActivityQueryPromotionActivityV2Response> ExecutePromotionActivityQueryPromotionActivityV2Async(this DouyinMicroAppClient client, Models.PromotionActivityQueryPromotionActivityV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "activity", "query_promotion_activity/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionActivityQueryPromotionActivityV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Coupon
        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/get_coupon_receive_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-mgmt/get-coupon-receive-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponGetCouponReceiveInfoV1Response> ExecutePromotionCouponGetCouponReceiveInfoV1Async(this DouyinMicroAppClient client, Models.PromotionCouponGetCouponReceiveInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "get_coupon_receive_info")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponGetCouponReceiveInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/batch_consume_coupon 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-mgmt/batch-consume-coupon ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponBatchConsumeCouponV1Response> ExecutePromotionCouponBatchConsumeCouponV1Async(this DouyinMicroAppClient client, Models.PromotionCouponBatchConsumeCouponV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.ConsumeTimestamp is null)
                request.ConsumeTimestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "batch_consume_coupon")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponBatchConsumeCouponV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/batch_rollback_consume_coupon 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-mgmt/batch-rollback-consume-coupon ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponBatchRollbackConsumeCouponV1Response> ExecutePromotionCouponBatchRollbackConsumeCouponV1Async(this DouyinMicroAppClient client, Models.PromotionCouponBatchRollbackConsumeCouponV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.RollbackConsumeTimestamp is null)
                request.RollbackConsumeTimestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "batch_rollback_consume_coupon")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponBatchRollbackConsumeCouponV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/get_talent_coupon 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/anchor-authorization-mgmt/get-talent-coupon ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponGetTalentCouponV1Response> ExecutePromotionCouponGetTalentCouponV1Async(this DouyinMicroAppClient client, Models.PromotionCouponGetTalentCouponV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "get_talent_coupon")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponGetTalentCouponV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/set_talent_coupon/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/anchor-authorization-mgmt/set-talent-coupon ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponSetTalentCouponV1Response> ExecutePromotionCouponSetTalentCouponV1Async(this DouyinMicroAppClient client, Models.PromotionCouponSetTalentCouponV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "set_talent_coupon/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponSetTalentCouponV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/update_talent_coupon_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/anchor-authorization-mgmt/get-talent-coupon ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponUpdateTalentCouponStatusV1Response> ExecutePromotionCouponUpdateTalentCouponStatusV1Async(this DouyinMicroAppClient client, Models.PromotionCouponUpdateTalentCouponStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "update_talent_coupon_status")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponUpdateTalentCouponStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/update_talent_coupon_stock/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/anchor-authorization-mgmt/update-talent-coupon-stock ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponUpdateTalentCouponStockV1Response> ExecutePromotionCouponUpdateTalentCouponStockV1Async(this DouyinMicroAppClient client, Models.PromotionCouponUpdateTalentCouponStockV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "update_talent_coupon_stock/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponUpdateTalentCouponStockV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/send_coupon_to_designated_user 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/direct-send/send-coupon-to-designated-user ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponSendCouponToDesignatedUserV1Response> ExecutePromotionCouponSendCouponToDesignatedUserV1Async(this DouyinMicroAppClient client, Models.PromotionCouponSendCouponToDesignatedUserV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "send_coupon_to_designated_user")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponSendCouponToDesignatedUserV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/get_bill_download_url/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/get-bill-download-url ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponGetBillDownloadUrlV1Response> ExecutePromotionCouponGetBillDownloadUrlV1Async(this DouyinMicroAppClient client, Models.PromotionCouponGetBillDownloadUrlV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "get_bill_download_url/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponGetBillDownloadUrlV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Coupon/DeveloperActivity
        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/create_developer_activity 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/direct-send/create-developer-activity ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponCreateDeveloperActivityV1Response> ExecutePromotionCouponCreateDeveloperActivityV1Async(this DouyinMicroAppClient client, Models.PromotionCouponCreateDeveloperActivityV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "create_developer_activity")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponCreateDeveloperActivityV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/delete_developer_activity 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/direct-send/delete-developer-activity ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponDeleteDeveloperActivityV1Response> ExecutePromotionCouponDeleteDeveloperActivityV1Async(this DouyinMicroAppClient client, Models.PromotionCouponDeleteDeveloperActivityV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "delete_developer_activity")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponDeleteDeveloperActivityV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region CouponMeta
        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/coupon/create_coupon_meta/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/create-coupon-meta ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponCreateCouponMetaV2Response> ExecutePromotionCouponCreateCouponMetaV2Async(this DouyinMicroAppClient client, Models.PromotionCouponCreateCouponMetaV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "coupon", "create_coupon_meta/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponCreateCouponMetaV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/coupon/modify_coupon_meta/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/modify-coupon-meta ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponModifyCouponMetaV2Response> ExecutePromotionCouponModifyCouponMetaV2Async(this DouyinMicroAppClient client, Models.PromotionCouponModifyCouponMetaV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "coupon", "modify_coupon_meta/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponModifyCouponMetaV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v2/coupon/query_coupon_meta/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/query-coupon-meta ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponQueryCouponMetaV2Response> ExecutePromotionCouponQueryCouponMetaV2Async(this DouyinMicroAppClient client, Models.PromotionCouponQueryCouponMetaV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v2", "coupon", "query_coupon_meta/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponQueryCouponMetaV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/delete_coupon_meta 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/delete-coupon-meta ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponDeleteCouponMetaV1Response> ExecutePromotionCouponDeleteCouponMetaV1Async(this DouyinMicroAppClient client, Models.PromotionCouponDeleteCouponMetaV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "delete_coupon_meta")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponDeleteCouponMetaV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/update_coupon_meta_stock 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/update-coupon-meta-stock ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponUpdateCouponMetaStockV1Response> ExecutePromotionCouponUpdateCouponMetaStockV1Async(this DouyinMicroAppClient client, Models.PromotionCouponUpdateCouponMetaStockV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "update_coupon_meta_stock")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponUpdateCouponMetaStockV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/update_coupon_meta_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/update-coupon-meta-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponUpdateCouponMetaStatusV1Response> ExecutePromotionCouponUpdateCouponMetaStatusV1Async(this DouyinMicroAppClient client, Models.PromotionCouponUpdateCouponMetaStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "update_coupon_meta_status")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponUpdateCouponMetaStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/query_activity_meta_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/query_activity_meta_data ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponQueryActivityMetaDataV1Response> ExecutePromotionCouponQueryActivityMetaDataV1Async(this DouyinMicroAppClient client, Models.PromotionCouponQueryActivityMetaDataV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "query_activity_meta_data/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponQueryActivityMetaDataV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/promotion/v1/coupon/get_coupon_meta_statistics 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/merchant-coupon/coupon-meta-mgmt/get-coupon-meta-statistics ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCouponGetCouponMetaStatisticsV1Response> ExecutePromotionCouponGetCouponMetaStatisticsV1Async(this DouyinMicroAppClient client, Models.PromotionCouponGetCouponMetaStatisticsV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "promotion", "v1", "coupon", "get_coupon_meta_statistics")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PromotionCouponGetCouponMetaStatisticsV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
