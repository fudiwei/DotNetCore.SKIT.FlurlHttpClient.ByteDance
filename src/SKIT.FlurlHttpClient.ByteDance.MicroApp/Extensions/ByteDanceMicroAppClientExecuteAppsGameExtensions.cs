using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class ByteDanceMicroAppClientExecuteAppsGameExtensions
    {
        private static string GenerateRequestSignature<TRequest>(this ByteDanceMicroAppClient client, ref TRequest request, string method, string reqLoc)
            where TRequest : Models.AppsGameWalletRequestBase
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (request == null) throw new ArgumentNullException(nameof(request));

            /*
             * REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/payment-signature-generation-algorithm
             */

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            if (request.Timestamp == null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            IDictionary<string, string> paramMap = new SortedDictionary<string, string>(
                new Dictionary<string, string>()
                {
                    { "access_token", HttpUtility.UrlEncode(request.AccessToken ?? string.Empty) },
                    { "appid", HttpUtility.UrlEncode(request.AppId ?? string.Empty) },
                    { "openid", HttpUtility.UrlEncode(request.OpenId ?? string.Empty) },
                    { "zone_id", HttpUtility.UrlEncode(request.ZoneId ?? string.Empty) },
                    { "pf", HttpUtility.UrlEncode(request.Platform ?? string.Empty) },
                    { "ts", request.Timestamp.ToString()! }
                },
                StringComparer.Ordinal
            );
            string plainText = string.Join("&", paramMap.Select(e => $"{e.Key}={e.Value}"))
                + $"&org_loc={reqLoc}"
                + $"&method={method.ToUpper()}";
            return Utilities.HMACUtility.HashWithSHA256(client.Credentials.ECPaySalt ?? string.Empty, plainText).ToLower();
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/game/wallet/get_balance 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/acquire-mini-game-coin-balance </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsGameWalletGetBalanceResponse> ExecuteAppsGameWalletGetBalanceAsync(this ByteDanceMicroAppClient client, Models.AppsGameWalletGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(ref request, HttpMethod.Post.Method, "/api/apps/game/wallet/get_balance");

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "game", "wallet", "get_balance");

            return await client.SendRequestWithJsonAsync<Models.AppsGameWalletGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/game/wallet/game_pay 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/mini-game-coin-deduction-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsGameWalletGamePayResponse> ExecuteAppsGameWalletGamePayAsync(this ByteDanceMicroAppClient client, Models.AppsGameWalletGamePayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(ref request, HttpMethod.Post.Method, "/api/apps/game/wallet/game_pay");

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "game", "wallet", "game_pay");

            return await client.SendRequestWithJsonAsync<Models.AppsGameWalletGamePayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/game/wallet/add_coin 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/mini-game-coin-gift-interface </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsGameWalletAddCoinResponse> ExecuteAppsGameWalletAddCoinAsync(this ByteDanceMicroAppClient client, Models.AppsGameWalletAddCoinRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Signature == null)
                request.Signature = client.GenerateRequestSignature(ref request, HttpMethod.Post.Method, "/api/apps/game/wallet/add_coin");

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apps", "game", "wallet", "add_coin");

            return await client.SendRequestWithJsonAsync<Models.AppsGameWalletAddCoinResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
