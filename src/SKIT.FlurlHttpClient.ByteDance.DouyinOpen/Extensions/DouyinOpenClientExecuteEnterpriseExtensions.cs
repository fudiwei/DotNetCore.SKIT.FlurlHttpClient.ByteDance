using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteEnterpriseExtensions
    {
        #region IM
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/message/send 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/message-management-enterprise/message-to-user </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseIMMessageSendResponse> ExecuteEnterpriseIMMessageSendAsync(this DouyinOpenClient client, Models.EnterpriseIMMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "im", "message", "send")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseIMMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region IM/Card
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/card/save 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/enterprise-messa-card/create-or-update-message-card </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMCardSaveResponse> ExecuteEnterpriseIMCardSaveAsync(this DouyinOpenClient client, Models.EnterpriseIMCardSaveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "im", "card", "save")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseIMCardSaveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/im/card/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/enterprise-messa-card/get-message-card-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMCardListResponse> ExecuteEnterpriseIMCardListAsync(this DouyinOpenClient client, Models.EnterpriseIMCardListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "im", "card", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseIMCardListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/card/delete 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/enterprise-messa-card/delete-message-card </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMCardDeleteResponse> ExecuteEnterpriseIMCardDeleteAsync(this DouyinOpenClient client, Models.EnterpriseIMCardDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "im", "card", "delete")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseIMCardDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Leads
        /// <summary>
        /// <para>异步调用 [GET] /enterprise/leads/user/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/get-user-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsUserListResponse> ExecuteEnterpriseLeadsUserListAsync(this DouyinOpenClient client, Models.EnterpriseLeadsUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "leads", "user", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("action_type", request.ActionType);

            if (request.LeadsLevel != null)
                flurlReq.SetQueryParam("leads_level", request.LeadsLevel);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/leads/user/detail 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/get-user-detail </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsUserDetailResponse> ExecuteEnterpriseLeadsUserDetailAsync(this DouyinOpenClient client, Models.EnterpriseLeadsUserDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "leads", "user", "detail")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("user_id", request.UserOpenId);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsUserDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/leads/user/action/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/get-user-interaction-record </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsUserActionListResponse> ExecuteEnterpriseLeadsUserActionListAsync(this DouyinOpenClient client, Models.EnterpriseLeadsUserActionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "leads", "user", "action", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("user_id", request.UserOpenId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            if (request.ActionType != null)
                flurlReq.SetQueryParam("action_type", request.ActionType);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsUserActionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/leads/tag/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/get-tag-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsTagListResponse> ExecuteEnterpriseLeadsTagListAsync(this DouyinOpenClient client, Models.EnterpriseLeadsTagListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "leads", "tag", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/leads/tag/create 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/create-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsTagCreateResponse> ExecuteEnterpriseLeadsTagCreateAsync(this DouyinOpenClient client, Models.EnterpriseLeadsTagCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "leads", "tag", "create")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/leads/tag/update 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/edit-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsTagUpdateResponse> ExecuteEnterpriseLeadsTagUpdateAsync(this DouyinOpenClient client, Models.EnterpriseLeadsTagUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "leads", "tag", "update")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/leads/tag/delete 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/delete-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsTagDeleteResponse> ExecuteEnterpriseLeadsTagDeleteAsync(this DouyinOpenClient client, Models.EnterpriseLeadsTagDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "leads", "tag", "delete")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/leads/tag/user/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/get-tag-user-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsTagUserListResponse> ExecuteEnterpriseLeadsTagUserListAsync(this DouyinOpenClient client, Models.EnterpriseLeadsTagUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "leads", "tag", "user", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/leads/tag/user/update 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/enterprise-open-ability/manage-user/set-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-05-31 下线。")]
        public static async Task<Models.EnterpriseLeadsTagUserUpdateResponse> ExecuteEnterpriseLeadsTagUserUpdateAsync(this DouyinOpenClient client, Models.EnterpriseLeadsTagUserUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "leads", "tag", "user", "update")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagUserUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Media
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/upload 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/upload-material-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaUploadResponse> ExecuteEnterpriseMediaUploadAsync(this DouyinOpenClient client, Models.EnterpriseMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "media", "upload")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.MediaFileName == null)
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.MediaContentType == null)
                request.MediaContentType = "image/jpeg";

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MediaFileName, fileBytes: request.MediaFileBytes, fileContentType: request.MediaContentType!, formDataName: "media");
            return await client.SendRequestAsync<Models.EnterpriseMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/temp/upload 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/upload-temp-material-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaTempUploadResponse> ExecuteEnterpriseMediaTempUploadAsync(this DouyinOpenClient client, Models.EnterpriseMediaTempUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "media", "temp", "upload")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.MediaFileName == null)
                request.MediaFileName = Guid.NewGuid().ToString("N").ToLower();

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.MediaFileName, fileBytes: request.MediaFileBytes, fileContentType: request.MediaContentType!, formDataName: "media");
            return await client.SendRequestAsync<Models.EnterpriseMediaTempUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /enterprise/media/list 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/material-list-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaListResponse> ExecuteEnterpriseMediaListAsync(this DouyinOpenClient client, Models.EnterpriseMediaListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "enterprise", "media", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseMediaListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /enterprise/media/delete 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/tools-ability/material-management/delete-material-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseMediaDeleteResponse> ExecuteEnterpriseMediaDeleteAsync(this DouyinOpenClient client, Models.EnterpriseMediaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "media", "delete")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseMediaDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
