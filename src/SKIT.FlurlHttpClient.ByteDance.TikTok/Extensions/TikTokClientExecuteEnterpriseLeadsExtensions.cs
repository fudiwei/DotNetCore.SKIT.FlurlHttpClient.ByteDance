using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteEnterpriseLeadsMExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /enterprise/leads/user/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/get-user-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsUserListResponse> ExecuteEnterpriseLeadsUserListAsync(this TikTokClient client, Models.EnterpriseLeadsUserListRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/get-user-detail </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsUserDetailResponse> ExecuteEnterpriseLeadsUserDetailAsync(this TikTokClient client, Models.EnterpriseLeadsUserDetailRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/get-user-interaction-record </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsUserActionListResponse> ExecuteEnterpriseLeadsUserActionListAsync(this TikTokClient client, Models.EnterpriseLeadsUserActionListRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/get-tag-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsTagListResponse> ExecuteEnterpriseLeadsTagListAsync(this TikTokClient client, Models.EnterpriseLeadsTagListRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/create-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsTagCreateResponse> ExecuteEnterpriseLeadsTagCreateAsync(this TikTokClient client, Models.EnterpriseLeadsTagCreateRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/edit-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsTagUpdateResponse> ExecuteEnterpriseLeadsTagUpdateAsync(this TikTokClient client, Models.EnterpriseLeadsTagUpdateRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/delete-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsTagDeleteResponse> ExecuteEnterpriseLeadsTagDeleteAsync(this TikTokClient client, Models.EnterpriseLeadsTagDeleteRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/get-tag-user-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsTagUserListResponse> ExecuteEnterpriseLeadsTagUserListAsync(this TikTokClient client, Models.EnterpriseLeadsTagUserListRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/manage-user/set-tag </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseLeadsTagUserUpdateResponse> ExecuteEnterpriseLeadsTagUserUpdateAsync(this TikTokClient client, Models.EnterpriseLeadsTagUserUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "leads", "tag", "user", "update")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseLeadsTagUserUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
