using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteToolsExtensions
    {
        #region VideoCover
        /// <summary>
        /// <para>异步调用 [GET] /2/tools/video_cover/suggest 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710602404864 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ToolsVideoCoverSuggestResponse> ExecuteToolsVideoCoverSuggestAsync(this OceanEngineClient client, Models.ToolsVideoCoverSuggestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "2", "tools", "video_cover", "suggest")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ToolsVideoCoverSuggestResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
