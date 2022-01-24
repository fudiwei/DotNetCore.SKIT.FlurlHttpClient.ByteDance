using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsStorageExtensions
    {
        private static string GenerateRequestSignature<TRequest>(this ByteDanceMicroAppClient client, TRequest request, string signMethod, string sessionKey)
            where TRequest : ByteDanceMicroAppRequest
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (sessionKey == null) throw new ArgumentNullException(nameof(sessionKey));

            /*
             * REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/other/user-login-sign/
             * REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/other/user-login-sign/
             */

            string json = client.JsonSerializer.Serialize(request);

            switch (signMethod)
            {
                case "hmac_sha256":
                    return Utilities.HMACUtility.HashWithSHA256(sessionKey, json).ToLower();

                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/set_user_storage 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/data-caching/set-user-storage </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/data-caching/set-user-storage </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsSetUserStorageResponse> ExecuteAppsSetUserStorageAsync(this ByteDanceMicroAppClient client, Models.AppsSetUserStorageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request, request.SignMethod, request.SessionKey!);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "set_user_storage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendRequestWithJsonAsync<Models.AppsSetUserStorageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/remove_user_storage 接口。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/server/data-caching/remove-user-storage </para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-game/develop/server/data-caching/remove-user-storage </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsRemoveUserStorageResponse> ExecuteAppsRemoveUserStorageAsync(this ByteDanceMicroAppClient client, Models.AppsRemoveUserStorageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(request, request.SignMethod, request.SessionKey!);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "remove_user_storage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendRequestWithJsonAsync<Models.AppsRemoveUserStorageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
