using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    using SKIT.FlurlHttpClient;

    public static class TikTokShopClientExecuteCustomerServiceExtensions
    {
        #region Agents
        /// <summary>
        /// <para>异步调用 [GET] /customer_service/{version}/agents/settings 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a58d2bace3e02b7556575 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceGetAgentSettingsResponse> ExecuteCustomerServiceGetAgentSettingsAsync(this TikTokShopClient client, Models.CustomerServiceGetAgentSettingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customer_service", request.ApiVersion, "agents", "settings");

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceGetAgentSettingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /customer_service/{version}/agents/settings 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a59870fcef602bf2a1d79 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceUpdateAgentSettingsResponse> ExecuteCustomerServiceUpdateAgentSettingsAsync(this TikTokShopClient client, Models.CustomerServiceUpdateAgentSettingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "customer_service", request.ApiVersion, "agents", "settings");

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceUpdateAgentSettingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [POST] /customer_service/{version}/conversations 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a5a0bf1fd3102b9245b8d ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceCreateConversationResponse> ExecuteCustomerServiceCreateConversationAsync(this TikTokShopClient client, Models.CustomerServiceCreateConversationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customer_service", request.ApiVersion, "conversations");

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceCreateConversationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customer_service/{version}/conversations 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a589f0fcef602bf29fecf ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceGetConversationsResponse> ExecuteCustomerServiceGetConversationsAsync(this TikTokShopClient client, Models.CustomerServiceGetConversationsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customer_service", request.ApiVersion, "conversations")
                .SetQueryParam("locale", request.Locale)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceGetConversationsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customer_service/{version}/conversations/{conversation_id}/messages 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a58bbbace3e02b7556286 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceCreateConversationMessageResponse> ExecuteCustomerServiceCreateConversationMessageAsync(this TikTokShopClient client, Models.CustomerServiceCreateConversationMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customer_service", request.ApiVersion, "conversations", request.ConversationId, "messages");

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceCreateConversationMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customer_service/{version}/conversations/{conversation_id}/messages 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a587edefece02be664cd2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceGetConversationMessagesResponse> ExecuteCustomerServiceGetConversationMessagesAsync(this TikTokShopClient client, Models.CustomerServiceGetConversationMessagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customer_service", request.ApiVersion, "conversations", request.ConversationId, "messages")
                .SetQueryParam("locale", request.Locale)
                .SetQueryParam("sort_field", request.SortField)
                .SetQueryParam("sort_order", request.SortOrder)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceGetConversationMessagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customer_service/{version}/images/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a599d0fcef602bf2a1dc8 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceUploadImageResponse> ExecuteCustomerServiceUploadImageAsync(this TikTokShopClient client, Models.CustomerServiceUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = MimeTypes.GetMimeMapping(request.ImageFileName);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customer_service", request.ApiVersion, "images", "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "data");
            return await client.SendFlurlRequestAsync<Models.CustomerServiceUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customer_service/{version}/conversations/{conversation_id}/messages/read 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650a59f7c16ffe02b8e8db3f ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomerServiceReadConversationMessageResponse> ExecuteCustomerServiceReadConversationMessageAsync(this TikTokShopClient client, Models.CustomerServiceReadConversationMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customer_service", request.ApiVersion, "conversations", request.ConversationId, "messages", "read");

            return await client.SendFlurlRequesAsJsontAsync<Models.CustomerServiceReadConversationMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
