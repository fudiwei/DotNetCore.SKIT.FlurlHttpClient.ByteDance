using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecuteEventExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /event/{version}/webhooks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509a3a1c16ffe02b8d64149 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EventGetWebhooksResponse> ExecuteEventGetWebhooksAsync(this TikTokShopClient client, Models.EventGetWebhooksRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "event", request.ApiVersion, "webhooks");

            return await client.SendFlurlRequesAsJsontAsync<Models.EventGetWebhooksResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /event/{version}/webhooks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa064defece02be6df919 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EventUpdateWebhookResponse> ExecuteEventUpdateWebhookAsync(this TikTokShopClient client, Models.EventUpdateWebhookRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "event", request.ApiVersion, "webhooks");

            return await client.SendFlurlRequesAsJsontAsync<Models.EventUpdateWebhookResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /event/{version}/webhooks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650aa1eadefece02be6e224a ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.EventDeleteWebhookResponse> ExecuteEventDeleteWebhookAsync(this TikTokShopClient client, Models.EventDeleteWebhookRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "event", request.ApiVersion, "webhooks");

            return await client.SendFlurlRequesAsJsontAsync<Models.EventDeleteWebhookResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
