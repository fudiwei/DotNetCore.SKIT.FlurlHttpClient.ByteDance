using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    public static class DouyinMicroAppProductApiClientExecuteRefundRuleExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /query_refund_rule_meta 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/refund-meta-query ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductQueryRefundRuleMetaResponse> ExecuteProductQueryRefundRuleMetaAsync(this DouyinMicroAppProductApiClient client, Models.ProductQueryRefundRuleMetaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "query_refund_rule_meta")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductQueryRefundRuleMetaResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /modify_refund_rule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/product-refund-rule-modify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductModifyRefundRuleResponse> ExecuteProductModifyRefundRuleAsync(this DouyinMicroAppProductApiClient client, Models.ProductModifyRefundRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "modify_refund_rule")
                .WithHeader("Aweme-Check-Type", request.SandboxCheckType);

            return await client.SendFlurlRequestAsJsonAsync<Models.ProductModifyRefundRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
