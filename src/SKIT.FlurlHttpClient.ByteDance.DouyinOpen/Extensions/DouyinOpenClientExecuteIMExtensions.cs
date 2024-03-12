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
    }
}
