namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static partial class DouyinMicroAppClientExecuteExtensions
    {
        #region Ad
        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v3/capacity/query_ad_income/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/basic-abilities/traffic-permission/query-ad-income ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryAdIncomeV3Response> ExecuteAppsCapacityQueryAdIncomeV3Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryAdIncomeV3Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v3", "capacity", "query_ad_income/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString)
                .SetQueryParam("host_name", request.HostName);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryAdIncomeV3Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v3/capacity/query_ad_settlement_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/basic-abilities/traffic-permission/query-ad-settlement-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryAdSettlementListV3Response> ExecuteAppsCapacityQueryAdSettlementListV3Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryAdSettlementListV3Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v3", "capacity", "query_ad_settlement_list/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("month", request.PeriodString)
                .SetQueryParam("status", request.Status);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryAdSettlementListV3Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region AwemeKeyword
        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_aweme_video_keyword_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/aweme-capacity/query-aweme-video-keyword ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryAwemeVideoKeywordListV1Response> ExecuteAppsCapacityQueryAwemeVideoKeywordListV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryAwemeVideoKeywordListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_aweme_video_keyword_list/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryAwemeVideoKeywordListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/add_aweme_video_keyword/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/aweme-capacity/add-aweme-video-keyword ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityAddAwemeVideoKeywordV1Response> ExecuteAppsCapacityAddAwemeVideoKeywordV1Async(this DouyinMicroAppClient client, Models.AppsCapacityAddAwemeVideoKeywordV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "add_aweme_video_keyword/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityAddAwemeVideoKeywordV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/delete_aweme_video_keyword/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/aweme-capacity/delete-aweme-video-keyword ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityDeleteAwemeVideoKeywordV1Response> ExecuteAppsCapacityDeleteAwemeVideoKeywordV1Async(this DouyinMicroAppClient client, Models.AppsCapacityDeleteAwemeVideoKeywordV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "delete_aweme_video_keyword/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityDeleteAwemeVideoKeywordV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Delivery
        /// <summary>
        /// <para>异步调用 [POST] /aweme/apps/v1/alias/create_alias/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/delivery/add-alias ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityCreateAliasV1Response> ExecuteAppsCapacityCreateAliasV1Async(this DouyinMicroAppClient client, Models.AppsCapacityCreateAliasV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "aweme", "apps", "v1", "alias", "create_alias/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityCreateAliasV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /aweme/apps/v1/alias/list_alias/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/delivery/query-alias-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityListAliasV1Response> ExecuteAppsCapacityListAliasV1Async(this DouyinMicroAppClient client, Models.AppsCapacityListAliasV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "aweme", "apps", "v1", "alias", "list_alias/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityListAliasV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/modify_alias/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/delivery/modify-alias ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityModifyAliasV1Response> ExecuteAppsCapacityModifyAliasV1Async(this DouyinMicroAppClient client, Models.AppsCapacityModifyAliasV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "modify_alias/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityModifyAliasV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/delete_alias/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/delivery/delete-alias ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityDeleteAliasV1Response> ExecuteAppsCapacityDeleteAliasV1Async(this DouyinMicroAppClient client, Models.AppsCapacityDeleteAliasV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "delete_alias/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityDeleteAliasV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/set_search_tag/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/delivery/set-search-tag ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacitySetSearchTagV1Response> ExecuteAppsCapacitySetSearchTagV1Async(this DouyinMicroAppClient client, Models.AppsCapacitySetSearchTagV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "set_search_tag/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacitySetSearchTagV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_search_tag_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/delivery/query-search-tag-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQuerySearchTagListV1Response> ExecuteAppsCapacityQuerySearchTagListV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQuerySearchTagListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_search_tag_list/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQuerySearchTagListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SimpleQrcode
        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v2/capacity/query_simple_qr_bind_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/simple-qr-code/query-simple-qr-bind-listv3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQuerySimpleQrcodeBindListV2Response> ExecuteAppsCapacityQuerySimpleQrcodeBindListV2Async(this DouyinMicroAppClient client, Models.AppsCapacityQuerySimpleQrcodeBindListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v2", "capacity", "query_simple_qr_bind_list/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQuerySimpleQrcodeBindListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v2/capacity/add_simple_qr_bind/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/simple-qr-code/add-simple-qr-bindv3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityAddSimpleQrcodeBindV2Response> ExecuteAppsCapacityAddSimpleQrcodeBindV2Async(this DouyinMicroAppClient client, Models.AppsCapacityAddSimpleQrcodeBindV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v2", "capacity", "add_simple_qr_bind/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityAddSimpleQrcodeBindV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v2/capacity/update_simple_qr_bind/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/simple-qr-code/update-simple-qr-bindv3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityUpdateSimpleQrcodeBindV2Response> ExecuteAppsCapacityUpdateSimpleQrcodeBindV2Async(this DouyinMicroAppClient client, Models.AppsCapacityUpdateSimpleQrcodeBindV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v2", "capacity", "update_simple_qr_bind/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityUpdateSimpleQrcodeBindV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v2/capacity/update_simple_qr_bind_status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/simple-qr-code/update-simple-qr-bind-statusv3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityUpdateSimpleQrcodeBindStatusV2Response> ExecuteAppsCapacityUpdateSimpleQrcodeBindStatusV2Async(this DouyinMicroAppClient client, Models.AppsCapacityUpdateSimpleQrcodeBindStatusV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v2", "capacity", "update_simple_qr_bind_status/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityUpdateSimpleQrcodeBindStatusV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v2/capacity/delete_simple_qr_bind/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/operation/simple-qr-code/delete-simple-qr-bindv3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityDeleteSimpleQrcodeBindV2Response> ExecuteAppsCapacityDeleteSimpleQrcodeBindV2Async(this DouyinMicroAppClient client, Models.AppsCapacityDeleteSimpleQrcodeBindV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v2", "capacity", "delete_simple_qr_bind/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityDeleteSimpleQrcodeBindV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SubService
        /// <summary>
        /// <para>异步调用 [POST] /api/apps/v1/capacity/create_ma_sub_service/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/search/create-ma-sub-service ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityCreateMicroAppSubServiceV1Response> ExecuteAppsCapacityCreateMicroAppSubServiceV1Async(this DouyinMicroAppClient client, Models.AppsCapacityCreateMicroAppSubServiceV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "apps", "v1", "capacity", "create_ma_sub_service/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityCreateMicroAppSubServiceV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/apps/v1/capacity/query_ma_sub_service/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/reach-marketing/search/query-ma-sub-service ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppsCapacityQueryMicroAppSubServiceV1Response> ExecuteAppsCapacityQueryMicroAppSubServiceV1Async(this DouyinMicroAppClient client, Models.AppsCapacityQueryMicroAppSubServiceV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "apps", "v1", "capacity", "query_ma_sub_service/")
                .SetQueryParam("page_no", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("approval_state", request.ApprovalState)
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AppsCapacityQueryMicroAppSubServiceV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
