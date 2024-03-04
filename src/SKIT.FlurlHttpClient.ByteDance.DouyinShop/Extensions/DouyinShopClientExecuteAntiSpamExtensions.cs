using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteAntiSpamExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /antispam/userLogin 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/13/635 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AntiSpamUserLoginResponse> ExecuteAntiSpamUserLoginAsync(this DouyinShopClient client, Models.AntiSpamUserLoginRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "antispam", "userLogin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AntiSpamUserLoginResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /antispam/orderSend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/15/649 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AntiSpamOrderSendResponse> ExecuteAntiSpamOrderSendAsync(this DouyinShopClient client, Models.AntiSpamOrderSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "antispam", "orderSend")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AntiSpamOrderSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /antispam/orderQuery 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/15/650 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AntiSpamOrderQueryResponse> ExecuteAntiSpamOrderQueryAsync(this DouyinShopClient client, Models.AntiSpamOrderQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "antispam", "orderQuery")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AntiSpamOrderQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
