using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteLegacyAppsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apps/v2/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/interface-request-credential/get-access-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/interface-request-credential/get-access-token ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/interface-request-credential/get-access-token ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsTokenV2Response> ExecuteAppsTokenV2Async(this DouyinMicroAppClient client, Models.AppsTokenV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret is null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v2", "token")
                .WithUrl($"{client._BASEURL_LEGACY}/apps/v2/token");

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsTokenV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/v2/jscode2session 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/log-in/code-2-session ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/log-in/code-2-session ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/log-in/code-2-session ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsJsCode2SessionV2Response> ExecuteAppsJsCode2SessionV2Async(this DouyinMicroAppClient client, Models.AppsJsCode2SessionV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret is null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v2", "jscode2session")
                .WithUrl($"{client._BASEURL_LEGACY}/apps/v2/jscode2session");

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsJsCode2SessionV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /apps/qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/qr-code/create-qr-code ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/getqrcode ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsQrcodeResponse> ExecuteAppsQrcodeAsync(this DouyinMicroAppClient client, Models.AppsQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "qrcode")
                .WithUrl($"{client._BASEURL_LEGACY}/apps/qrcode");

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
