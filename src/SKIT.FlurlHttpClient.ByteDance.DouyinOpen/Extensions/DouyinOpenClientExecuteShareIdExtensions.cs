using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteShareIdExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /share-id/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/video-management/douyin/search-video/video-share-result ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ShareIdResponse> ExecuteShareIdAsync(this DouyinOpenClient client, Models.ShareIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "share-id/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("need_callback", request.RequireCallback.HasValue ? request.RequireCallback.Value ? "true" : "false" : null)
                .SetQueryParam("source_style_id", request.SourceStyleId)
                .SetQueryParam("default_hashtag", request.DefaultHashTag)
                .SetQueryParam("link_param", request.LinkParameter);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShareIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
