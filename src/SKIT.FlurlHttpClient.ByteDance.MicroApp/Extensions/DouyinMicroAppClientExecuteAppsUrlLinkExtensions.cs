using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteAppsUrlLinkExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/url/generate_schema/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/url-and-qrcode/schema/generate-schema-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsUrlGenerateSchemaV1Response> ExecuteAppsUrlGenerateSchemaV1Async(this DouyinMicroAppClient client, Models.AppsUrlGenerateSchemaV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "url", "generate_schema/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsUrlGenerateSchemaV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/url/query_schema/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/url-and-qrcode/schema/query-schema-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsUrlQuerySchemaV1Response> ExecuteAppsUrlQuerySchemaV1Async(this DouyinMicroAppClient client, Models.AppsUrlQuerySchemaV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "url", "query_schema/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsUrlQuerySchemaV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/url/query_schema_quota/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/url-and-qrcode/schema/query-schema-quota-v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsUrlQuerySchemaQuotaV1Response> ExecuteAppsUrlQuerySchemaQuotaV1Async(this DouyinMicroAppClient client, Models.AppsUrlQuerySchemaQuotaV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "url", "query_schema_quota/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsUrlQuerySchemaQuotaV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
