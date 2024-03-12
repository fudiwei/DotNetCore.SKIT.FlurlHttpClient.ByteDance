using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteIMExtensions
    {
        #region Authorize
        /// <summary>
        /// <para>异步调用 [POST] /im/authorize/user_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/private-message/query_private_auth_user ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/query_private_auth_user ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMAuthorizeUserListResponse> ExecuteIMAuthorizeUserListAsync(this DouyinOpenClient client, Models.IMAuthorizeUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "authorize", "user_list/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMAuthorizeUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/authorize/status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/QueryAuthorizeStatus ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMAuthorizeStatusResponse> ExecuteIMAuthorizeStatusAsync(this DouyinOpenClient client, Models.IMAuthorizeStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "authorize", "status/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMAuthorizeStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /im/save/retain_consult_card/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/business-tool/retain-consult-card/create-retain-consult-card ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMSaveRetainConsultCardResponse> ExecuteIMSaveRetainConsultCardAsync(this DouyinOpenClient client, Models.IMSaveRetainConsultCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "save", "retain_consult_card/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMSaveRetainConsultCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /im/get/retain_consult_card/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/business-tool/retain-consult-card/query-retain-consult-card ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGetRetainConsultCardResponse> ExecuteIMGetRetainConsultCardAsync(this DouyinOpenClient client, Models.IMGetRetainConsultCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "im", "get", "retain_consult_card/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGetRetainConsultCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/del/retain_consult_card/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/business-tool/retain-consult-card/delete-retain-consult-card ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMDeleteRetainConsultCardResponse> ExecuteIMDeleteRetainConsultCardAsync(this DouyinOpenClient client, Models.IMDeleteRetainConsultCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "del", "retain_consult_card/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("card_id", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMDeleteRetainConsultCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Group
        /// <summary>
        /// <para>异步调用 [POST] /im/group/fans/create/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/create.fans.group ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/create-group ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupFansCreateResponse> ExecuteIMGroupFansCreateAsync(this DouyinOpenClient client, Models.IMGroupFansCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "group", "fans", "create/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupFansCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /im/group/fans/list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/query.fans.group ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/query-group-information ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupFansListResponse> ExecuteIMGroupFansListAsync(this DouyinOpenClient client, Models.IMGroupFansListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "im", "group", "fans", "list/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupFansListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /im/group/fans/count/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/group.fans.nums ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/query-group-scope ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupFansCountResponse> ExecuteIMGroupFansCountAsync(this DouyinOpenClient client, Models.IMGroupFansCountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "im", "group", "fans", "count/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupFansCountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/group/enter/audit/set/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/update.user.audit.status ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/join-group-audit ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupEnterAuditSetResponse> ExecuteIMGroupEnterAuditSetAsync(this DouyinOpenClient client, Models.IMGroupEnterAuditSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "group", "enter", "audit", "set/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupEnterAuditSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /im/group/enter/audit/get/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/group.fans.audit.get ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/check-group-member ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupEnterAuditGetResponse> ExecuteIMGroupEnterAuditGetAsync(this DouyinOpenClient client, Models.IMGroupEnterAuditGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "im", "group", "enter", "audit", "get/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupEnterAuditGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/group/setting/set/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/set_group_setting ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/group-setting ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupSettingSetResponse> ExecuteIMGroupSettingSetAsync(this DouyinOpenClient client, Models.IMGroupSettingSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "group", "setting", "set/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupSettingSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/group/setting/disable/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/join-group/cancel_group_setting ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-manage/cancel_group-setting ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMGroupSettingDisableResponse> ExecuteIMGroupSettingDisableAsync(this DouyinOpenClient client, Models.IMGroupSettingDisableRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "group", "setting", "disable/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMGroupSettingDisableResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Message
        /// <summary>
        /// <para>异步调用 [POST] /im/send/msg/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/private-message/send-msg ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/send-message ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMSendMessageResponse> ExecuteIMSendMessageAsync(this DouyinOpenClient client, Models.IMSendMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "send", "msg/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMSendMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/send/msg/group/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/group-msg/im.group.message.send ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-message/im.group.message.send ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMSendMessageGroupResponse> ExecuteIMSendMessageGroupAsync(this DouyinOpenClient client, Models.IMSendMessageGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "send", "msg", "group/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMSendMessageGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /im/recall/msg/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/private-message/recall-msg ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/group-msg/group-msg-recall ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/recall-msg ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-message/group-msg-recall ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IMRecallMessageResponse> ExecuteIMRecallMessageAsync(this DouyinOpenClient client, Models.IMRecallMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "im", "recall", "msg/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.IMRecallMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
