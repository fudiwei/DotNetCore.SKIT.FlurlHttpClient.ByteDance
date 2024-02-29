using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static class TikTokV2ClientExecuteUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /user/info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-api-v2-get-user-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserInfoResponse> ExecuteUserInfoAsync(this TikTokV2Client client, Models.UserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "user", "info", "")
                .SetQueryParam("fields", string.Join(",", request.FieldList));

            return await client.SendFlurlRequestAsync<Models.UserInfoResponse>(flurlReq, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
