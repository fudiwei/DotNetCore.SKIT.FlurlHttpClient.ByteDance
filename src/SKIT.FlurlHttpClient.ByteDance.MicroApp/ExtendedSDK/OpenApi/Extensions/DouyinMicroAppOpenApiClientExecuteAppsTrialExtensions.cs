using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteAppsTrialExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /apps/v2/trial/get_trial_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/trial-info-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsTrialGetTrialInfoV2Response> ExecuteOpenAppsTrialGetTrialInfoV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsTrialGetTrialInfoV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v2", "trial", "get_trial_info")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsTrialGetTrialInfoV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
