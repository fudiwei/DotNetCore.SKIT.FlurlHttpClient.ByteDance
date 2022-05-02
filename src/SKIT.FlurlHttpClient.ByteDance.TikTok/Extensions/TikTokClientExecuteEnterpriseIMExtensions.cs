using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteEnterpriseIMExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/message/send 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/interaction-management/message-management-enterprise/message-to-user </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMMessageSendResponse> ExecuteEnterpriseIMMessageSendAsync(this TikTokClient client, Models.EnterpriseIMMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "enterprise", "im", "message", "send")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.EnterpriseIMMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /enterprise/im/card/save 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/enterprise-messa-card/create-or-update-message-card </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMCardSaveResponse> ExecuteEnterpriseIMCardSaveAsync(this TikTokClient client, Models.EnterpriseIMCardSaveRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/enterprise-messa-card/get-message-card-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMCardListResponse> ExecuteEnterpriseIMCardListAsync(this TikTokClient client, Models.EnterpriseIMCardListRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/enterprise-open-ability/enterprise-messa-card/delete-message-card </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EnterpriseIMCardDeleteResponse> ExecuteEnterpriseIMCardDeleteAsync(this TikTokClient client, Models.EnterpriseIMCardDeleteRequest request, CancellationToken cancellationToken = default)
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
    }
}
