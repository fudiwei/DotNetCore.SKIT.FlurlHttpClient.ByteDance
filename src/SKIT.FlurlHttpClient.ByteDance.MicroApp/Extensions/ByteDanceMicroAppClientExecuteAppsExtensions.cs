using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /apps/token 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/interface-request-credential/get-access-token </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/interface-request-credential/get-access-token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTokenResponse> ExecuteAppsTokenAsync(this ByteDanceMicroAppClient client, Models.AppsTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apps", "token")
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("secret", client.Credentials.AppSecret)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendRequestWithJsonAsync<Models.AppsTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
