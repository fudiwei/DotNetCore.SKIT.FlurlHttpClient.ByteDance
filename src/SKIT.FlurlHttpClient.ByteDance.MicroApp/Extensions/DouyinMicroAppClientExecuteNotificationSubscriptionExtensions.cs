using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteNotificationSubscriptionExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /api/notification/v2/subscription/query_tpl_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/query_tpl_list_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionQueryTemplateListV2Response> ExecuteNotificationSubscriptionQueryTemplateListV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionQueryTemplateListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "notification", "v2", "subscription", "query_tpl_list/")
                .SetQueryParam("classification", request.Classification)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize)
                .WithHeader("access-token", request.AccessToken);

            if (request.TemplateType is not null)
                flurlReq.SetQueryParam("template_type", request.TemplateType);

            if (request.CategoryIdString is not null)
                flurlReq.SetQueryParam("category_ids", request.CategoryIdString);

            if (request.Keyword is not null)
                flurlReq.SetQueryParam("keyword", request.Keyword);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionQueryTemplateListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/notification/v2/subscription/create_tpl/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/create_tpl_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionCreateTemplateV2Response> ExecuteNotificationSubscriptionCreateTemplateV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionCreateTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "notification", "v2", "subscription", "create_tpl/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionCreateTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/notification/v2/subscription/query_created_tpl_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/query_created_tpl_list_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionQueryCreatedTemplateListV2Response> ExecuteNotificationSubscriptionQueryCreatedTemplateListV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionQueryCreatedTemplateListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "notification", "v2", "subscription", "query_created_tpl_list/")
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize)
                .WithHeader("access-token", request.AccessToken);

            if (request.Status is not null)
                flurlReq.SetQueryParam("status", request.Status.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionQueryCreatedTemplateListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/notification/v2/subscription/add_app_tpl/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/add_app_tpl_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionAddAppTemplateV2Response> ExecuteNotificationSubscriptionAddAppTemplateV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionAddAppTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "notification", "v2", "subscription", "add_app_tpl/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionAddAppTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/notification/v2/subscription/query_app_tpl/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/query_app_tpl_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionQueryAppTemplateV2Response> ExecuteNotificationSubscriptionQueryAppTemplateV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionQueryAppTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "notification", "v2", "subscription", "query_app_tpl/")
                .SetQueryParam("classification", request.Classification)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize)
                .WithHeader("access-token", request.AccessToken);

            if (request.CategoryIdString is not null)
                flurlReq.SetQueryParam("category_ids", request.CategoryIdString);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionQueryAppTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/notification/v2/subscription/delete_app_tpl/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/delete_app_tpl_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionDeleteAppTemplateV2Response> ExecuteNotificationSubscriptionDeleteAppTemplateV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionDeleteAppTemplateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "notification", "v2", "subscription", "delete_app_tpl/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionDeleteAppTemplateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/notification/v2/subscription/notify_user/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/subscribe-notification/notify_user_v2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotificationSubscriptionNotifyUserV2Response> ExecuteNotificationSubscriptionNotifyUserV2Async(this DouyinMicroAppClient client, Models.NotificationSubscriptionNotifyUserV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "notification", "v2", "subscription", "notify_user/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.NotificationSubscriptionNotifyUserV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
