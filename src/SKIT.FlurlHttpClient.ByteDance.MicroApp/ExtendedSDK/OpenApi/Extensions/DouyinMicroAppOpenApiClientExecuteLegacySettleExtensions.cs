using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteLegacySettleExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v1/settle/pre_check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/developer-settle/predict-check ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSettlePreCheckV1Response> ExecuteOpenApiSettlePreCheckV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiSettlePreCheckV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "settle", "pre_check")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "settle", "pre_check"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiSettlePreCheckV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/settle/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/developer-settle/settle-apply ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSettleApplyV1Response> ExecuteOpenApiSettleApplyV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiSettleApplyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v1", "settle", "apply")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "settle", "apply"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiSettleApplyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v1/settle/get_apply_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/developer-settle/get-apply-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSettleGetApplyStatusV1Response> ExecuteOpenApiSettleGetApplyStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiSettleGetApplyStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v1", "settle", "get_apply_status")
                .WithUrl(url => new Url(client._BASEURL_LEGACY).AppendPathSegments("v1", "settle", "get_apply_status"))
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("apply_id", request.ApplyId);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiSettleGetApplyStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
