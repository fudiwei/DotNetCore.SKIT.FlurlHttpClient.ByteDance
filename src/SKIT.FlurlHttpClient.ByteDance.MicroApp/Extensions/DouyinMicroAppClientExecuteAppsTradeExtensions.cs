using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteAppsTradeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/toolkit/query_text 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/fulfill-tool/query_text ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeToolkitQueryTextV2Response> ExecuteAppsTradeToolkitQueryTextV2Async(this DouyinMicroAppClient client, Models.AppsTradeToolkitQueryTextV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "toolkit", "query_text")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeToolkitQueryTextV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/toolkit/update_merchant_conf 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/fulfill-tool/update_merchant_conf ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeToolkitUpdateMerchantConfigV2Response> ExecuteAppsTradeToolkitUpdateMerchantConfigV2Async(this DouyinMicroAppClient client, Models.AppsTradeToolkitUpdateMerchantConfigV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "toolkit", "update_merchant_conf")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeToolkitUpdateMerchantConfigV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/toolkit/button_white_setting 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/fulfill-tool/button_white_setting ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeToolkitButtonWhiteSettingV2Response> ExecuteAppsTradeToolkitButtonWhiteSettingV2Async(this DouyinMicroAppClient client, Models.AppsTradeToolkitButtonWhiteSettingV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "toolkit", "button_white_setting")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeToolkitButtonWhiteSettingV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/trade/v2/toolkit/update_merchant_path 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/trade-system/self-operated-trading/write-off/fulfill-tool/update_merchant_path ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTradeToolkitUpdateMerchantPathV2Response> ExecuteAppsTradeToolkitUpdateMerchantPathV2Async(this DouyinMicroAppClient client, Models.AppsTradeToolkitUpdateMerchantPathV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "trade", "v2", "toolkit", "update_merchant_path")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTradeToolkitUpdateMerchantPathV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
