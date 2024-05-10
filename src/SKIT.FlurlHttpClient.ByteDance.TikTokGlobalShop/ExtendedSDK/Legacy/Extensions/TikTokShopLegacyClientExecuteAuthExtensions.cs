using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyClientExecuteAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /token/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/261250 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthGetTokenResponse> ExecuteAuthGetTokenAsync(this TikTokShopLegacyClient client, Models.AuthGetTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "token", "get")
                .WithUrl($"{client._BASEURL_AUTHAPI}/token/get")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("app_secret", client.Credentials.AppSecret)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("auth_code", request.AuthorizedCode)
                .RemoveQueryParams("access_token", "timestamp", "shop_id", "shop_cipher", "version");

            return await client.SendFlurlRequesAsJsontAsync<Models.AuthGetTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /token/refresh 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/261250 ]]> <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262967 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AuthRefreshTokenResponse> ExecuteAuthRefreshTokenAsync(this TikTokShopLegacyClient client, Models.AuthRefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "token", "refresh")
                .WithUrl($"{client._BASEURL_AUTHAPI}/token/refresh")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("app_secret", client.Credentials.AppSecret)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("refresh_token", request.RefreshToken)
                .RemoveQueryParams("access_token", "timestamp", "shop_id", "shop_cipher", "version");

            return await client.SendFlurlRequesAsJsontAsync<Models.AuthRefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
