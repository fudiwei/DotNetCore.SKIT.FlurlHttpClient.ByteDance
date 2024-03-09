using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteAppsDomainExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apps/v2/domain/modify_server_domain 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-domain-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsDomainModifyServerDomainV2Response> ExecuteOpenAppsDomainModifyServerDomainV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsDomainModifyServerDomainV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v2", "domain", "modify_server_domain")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsDomainModifyServerDomainV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/v2/domain/modify_webview_domain 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-webview-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsDomainModifyWebviewDomainV2Response> ExecuteOpenAppsDomainModifyWebviewDomainV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsDomainModifyWebviewDomainV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v2", "domain", "modify_webview_domain")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsDomainModifyWebviewDomainV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
