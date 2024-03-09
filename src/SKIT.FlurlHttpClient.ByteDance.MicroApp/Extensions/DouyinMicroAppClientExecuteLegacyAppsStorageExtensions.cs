using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteLegacyAppsStorageExtensions
    {
        private static string GenerateRequestSignature<TRequest>(DouyinMicroAppClient client, TRequest request, string signMethod, string sessionKey)
            where TRequest : DouyinMicroAppRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));
            if (sessionKey is null) throw new ArgumentNullException(nameof(sessionKey));

            /*
             * REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/other/user-login-sign/
             * REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/other/user-login-sign/
             */

            string json = client.JsonSerializer.Serialize(request);

            switch (signMethod)
            {
                case "hmac_sha256":
                    return Utilities.HMACUtility.HashWithSHA256(sessionKey, json).Value!.ToLower();

                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/set_user_storage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-caching/set-user-storage ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/data-caching/set-user-storage ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsSetUserStorageResponse> ExecuteAppsSetUserStorageAsync(this DouyinMicroAppClient client, Models.AppsSetUserStorageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request, request.SignMethod, request.SessionKey!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "set_user_storage")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "set_user_storage"))
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsSetUserStorageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/remove_user_storage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-caching/remove-user-storage ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/data-caching/remove-user-storage ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsRemoveUserStorageResponse> ExecuteAppsRemoveUserStorageAsync(this DouyinMicroAppClient client, Models.AppsRemoveUserStorageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature is null)
                request.Signature = GenerateRequestSignature(client, request, request.SignMethod, request.SessionKey!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "remove_user_storage")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("apps", "remove_user_storage"))
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsRemoveUserStorageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
