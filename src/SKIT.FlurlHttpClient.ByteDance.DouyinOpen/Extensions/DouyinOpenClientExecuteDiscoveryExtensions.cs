using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteDiscoveryExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /discovery/ent/rank/item/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/douyin-tv-tops-data/get-douyin-tv-tops ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DiscoveryEntertainmentRankItemResponse> ExecuteDiscoveryEntertainmentRankItemAsync(this DouyinOpenClient client, Models.DiscoveryEntertainmentRankItemRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "discovery", "ent", "rank", "item/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("version", request.Version);

            return await client.SendFlurlRequestAsJsonAsync<Models.DiscoveryEntertainmentRankItemResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /discovery/ent/rank/version/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/douyin-tv-tops-data/get-douyin-tv-version ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DiscoveryEntertainmentRankVersionResponse> ExecuteDiscoveryEntertainmentRankVersionAsync(this DouyinOpenClient client, Models.DiscoveryEntertainmentRankVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "discovery", "ent", "rank", "version/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.DiscoveryEntertainmentRankVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
