using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteLegacyAppsGameExtensions
    {
        private static T PreprocessRequest<T>(DouyinMicroAppClient client, ref T request)
            where T : Models.AppsGameWalletRequestBase, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(request));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
            {
                request.AppId = client.Credentials.AppId;
            }

            if (request.Timestamp is null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            if (request.Signature is null)
            {
                string json = client.JsonSerializer.Serialize(request);
                IDictionary<string, string> paramMap = new SortedDictionary<string, string>(Newtonsoft.Json.JsonConvert.DeserializeObject<IDictionary<string, string>>(json)!, StringComparer.Ordinal);
                foreach (var entry in paramMap)
                {
                    if (entry.Key == "mp_sig")
                        paramMap.Remove(entry.Key);
                    if (entry.Value is null)
                        paramMap.Remove(entry.Key);
                }

                string message = string.Join("&", paramMap.Select(e => $"{e.Key}={e.Value}"))
                    + $"&org_loc={request.GetRequestPath()}"
                    + $"&method={request.GetRequestMethod()}";
                request.Signature = Utilities.HMACUtility.HashWithSHA256(client.Credentials.ECPaySalt!, message).Value!.ToLower();
            }

            return request;
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/game/wallet/get_balance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/acquire-mini-game-coin-balance ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsGameWalletGetBalanceResponse> ExecuteAppsGameWalletGetBalanceAsync(this DouyinMicroAppClient client, Models.AppsGameWalletGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "game", "wallet", "get_balance")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "game", "wallet", "get_balance"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsGameWalletGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/game/wallet/game_pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/mini-game-coin-deduction-interface ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsGameWalletGamePayResponse> ExecuteAppsGameWalletGamePayAsync(this DouyinMicroAppClient client, Models.AppsGameWalletGamePayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "game", "wallet", "game_pay")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "game", "wallet", "game_pay"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsGameWalletGamePayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/game/wallet/add_coin 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/api/payment/mini-game-coin-gift-interface ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsGameWalletAddCoinResponse> ExecuteAppsGameWalletAddCoinAsync(this DouyinMicroAppClient client, Models.AppsGameWalletAddCoinRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "game", "wallet", "add_coin")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("api", "apps", "game", "wallet", "add_coin"));

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsGameWalletAddCoinResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
