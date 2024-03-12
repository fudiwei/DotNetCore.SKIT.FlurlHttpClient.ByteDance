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
                .WithHeader("access-token", request.AccessToken);

            if (request.RequireCallback is not null)
                flurlReq.SetQueryParam("need_callback", request.RequireCallback.Value ? "true" : "false");

            if (request.SourceStyleId is not null)
                flurlReq.SetQueryParam("source_style_id", request.SourceStyleId);

            if (request.DefaultHashTag is not null)
                flurlReq.SetQueryParam("default_hashtag", request.DefaultHashTag);

            if (request.LinkParameter is not null)
                flurlReq.SetQueryParam("link_param", request.LinkParameter);

            return await client.SendFlurlRequestAsJsonAsync<Models.ShareIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
