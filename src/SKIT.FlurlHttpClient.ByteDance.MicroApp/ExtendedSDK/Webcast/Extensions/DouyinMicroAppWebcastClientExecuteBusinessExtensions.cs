using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    public static class DouyinMicroAppWebcastClientExecuteBusinessExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /business/order/pre_create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/payDiamond#_%E9%A2%84%E4%B8%8B%E5%8D%95 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastBusinessOrderPrecreateResponse> ExecuteWebcastBusinessOrderPrecreateAsync(this DouyinMicroAppWebcastClient client, Models.WebcastBusinessOrderPrecreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "business", "order", "pre_create");

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastBusinessOrderPrecreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /business/diamond/query 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/payDiamond#_%E6%9F%A5%E8%AF%A2%E6%8A%96%E5%B8%81%E6%94%AF%E4%BB%98%E8%AE%A2%E5%8D%95%E7%BB%93%E6%9E%9C ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastBusinessDiamondQueryResponse> ExecuteWebcastBusinessDiamondQueryAsync(this DouyinMicroAppWebcastClient client, Models.WebcastBusinessDiamondQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "business", "diamond", "query");

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastBusinessDiamondQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /business/diamond/reconciliation 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/payDiamond#_%E6%89%B9%E9%87%8F%E5%AE%9E%E6%97%B6%E6%9F%A5%E8%AF%A2%E5%AF%B9%E8%B4%A6%E6%8E%A5%E5%8F%A3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastBusinessDiamondReconciliationResponse> ExecuteWebcastBusinessDiamondReconciliationAsync(this DouyinMicroAppWebcastClient client, Models.WebcastBusinessDiamondReconciliationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "business", "diamond", "reconciliation");

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastBusinessDiamondReconciliationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /business/diamond/order_ack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/payDiamond#_%E6%8A%96%E5%B8%81%E6%94%AF%E4%BB%98-ack-%E6%8E%A5%E5%8F%A3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WebcastBusinessDiamondOrderAckResponse> ExecuteWebcastBusinessDiamondOrderAckAsync(this DouyinMicroAppWebcastClient client, Models.WebcastBusinessDiamondOrderAckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "business", "diamond", "order_ack");

            return await client.SendFlurlRequestAsJsonAsync<Models.WebcastBusinessDiamondOrderAckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
