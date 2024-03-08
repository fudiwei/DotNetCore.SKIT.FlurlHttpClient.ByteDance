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
        public static async Task<Models.OpenTpAppTemplateGetTemplateAppListV2Response> ExecuteOpenTpAppTemplateGetTemplateAppListV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppTemplateGetTemplateAppListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "template", "get_tpl_app_list")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppTemplateGetTemplateAppListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.OpenTpAppTemplateGetTemplateListV2Response> ExecuteOpenTpAppTemplateGetTemplateListV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppTemplateGetTemplateListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "tpapp", "v2", "template", "get_tpl_list")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppTemplateGetTemplateListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.OpenTpAppTemplateAddTemplateV2Response> ExecuteOpenTpAppTemplateAddTemplateV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppTemplateAddTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tpapp", "v2", "template", "add_tpl")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppTemplateAddTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.OpenTpAppTemplateDeleteTemplateV2Response> ExecuteOpenTpAppTemplateDeleteTemplateV2Async(this DouyinMicroAppOpenApiClient client, Models.OpenTpAppTemplateDeleteTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tpapp", "v2", "template", "add_tpl")
                .WithHeader("access-token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenTpAppTemplateDeleteTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
