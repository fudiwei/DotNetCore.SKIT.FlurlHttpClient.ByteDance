using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteTpAppTemplateExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /tpapp/v2/template/get_tpl_app_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/tpl-app-list-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiTpAppTemplateGetTemplateAppListV2Response> ExecuteOpenApiTpAppTemplateGetTemplateAppListV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiTpAppTemplateGetTemplateAppListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "template", "get_tpl_app_list")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiTpAppTemplateGetTemplateAppListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /tpapp/v2/template/get_tpl_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/tpl-list-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiTpAppTemplateGetTemplateListV2Response> ExecuteOpenApiTpAppTemplateGetTemplateListV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiTpAppTemplateGetTemplateListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "template", "get_tpl_list")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiTpAppTemplateGetTemplateListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tpapp/v2/template/add_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/add-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiTpAppTemplateAddTemplateV2Response> ExecuteOpenApiTpAppTemplateAddTemplateV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiTpAppTemplateAddTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tpapp", "v2", "template", "add_tpl")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiTpAppTemplateAddTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tpapp/v2/template/del_tpl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/tpl-manage/delete-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiTpAppTemplateDeleteTemplateV2Response> ExecuteOpenApiTpAppTemplateDeleteTemplateV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenApiTpAppTemplateDeleteTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tpapp", "v2", "template", "add_tpl")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenApiTpAppTemplateDeleteTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
