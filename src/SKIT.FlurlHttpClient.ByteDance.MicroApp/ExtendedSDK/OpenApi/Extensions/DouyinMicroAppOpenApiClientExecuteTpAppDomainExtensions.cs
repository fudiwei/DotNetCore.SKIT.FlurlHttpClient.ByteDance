using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteTpAppDomainExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /tpapp/v2/doamin/get_webview_check_file_info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/domain/get-webview-check-file-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenTpAppDomainGetWebviewCheckFileInfoV2Response> ExecuteOpenTpAppDomainGetWebviewCheckFileInfoV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppDomainGetWebviewCheckFileInfoV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "doamin", "get_webview_check_file_info/")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppDomainGetWebviewCheckFileInfoV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
