using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecutePlatformDataAnalysisExtensions
    {
        #region Transaction
        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_deal_overview_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/overview-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryDealOverviewDataV2Response> ExecutePlatformDataAnalysisQueryDealOverviewDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryDealOverviewDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_deal_overview_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryDealOverviewDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/platform/v2/data_analysis/query_deal_data_with_conversion/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/deal-conversion-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryDealDataWithConversionV2Response> ExecutePlatformDataAnalysisQueryDealDataWithConversionV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryDealDataWithConversionV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "platform", "v2", "data_analysis", "query_deal_data_with_conversion/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryDealDataWithConversionV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_video_deal_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/video-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryVideoDealDataV2Response> ExecutePlatformDataAnalysisQueryVideoDealDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryVideoDealDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_video_deal_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("host_name", request.HostName);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryVideoDealDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_live_room/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/query-live-room-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryLiveRoomV2Response> ExecutePlatformDataAnalysisQueryLiveRoomV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryLiveRoomV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_live_room/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("anchor_name", request.AnchorName);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryLiveRoomV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_live_room_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/live-room-data-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryLiveRoomDataV2Response> ExecutePlatformDataAnalysisQueryLiveRoomDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryLiveRoomDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_live_room_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("live_room_id", request.LiveRoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryLiveRoomDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_live_deal_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/live-deal-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryLiveDealDataV2Response> ExecutePlatformDataAnalysisQueryLiveDealDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryLiveDealDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_live_deal_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("live_room_id", request.LiveRoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryLiveDealDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_product_deal_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/transaction-analysis/product-deal-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryProductDealDataV2Response> ExecutePlatformDataAnalysisQueryProductDealDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryProductDealDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_product_deal_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("page_num", request.PageNumber)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("host_name", request.HostName);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryProductDealDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region User
        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_behavior_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/behavior-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryBehaviorDataV2Response> ExecutePlatformDataAnalysisQueryBehaviorDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryBehaviorDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_behavior_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("os", request.OS)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryBehaviorDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_real_time_user_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/realtime-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryRealTimeUserDataV2Response> ExecutePlatformDataAnalysisQueryRealTimeUserDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryRealTimeUserDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_real_time_user_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryRealTimeUserDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_retention_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/retention-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryRetentionDataV2Response> ExecutePlatformDataAnalysisQueryRetentionDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryRetentionDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_retention_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("user_type", request.UserType)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("os", request.OS)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryRetentionDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_scene_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/scene-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQuerySceneDataV2Response> ExecutePlatformDataAnalysisQuerySceneDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQuerySceneDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_scene_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQuerySceneDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_user_portrait_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/user-portrait-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryUserPortraitDataV2Response> ExecutePlatformDataAnalysisQueryUserPortraitDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryUserPortraitDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_user_portrait_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("user_type", request.UserType)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryUserPortraitDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_client_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/client-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryClientDataV2Response> ExecutePlatformDataAnalysisQueryClientDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryClientDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_client_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("user_type", request.UserType)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryClientDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /api/platform/v2/data_analysis/query_page_data/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/data-analysis/user-analysis/page-analysis-datav3 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PlatformDataAnalysisQueryPageDataV2Response> ExecutePlatformDataAnalysisQueryPageDataV2Async(this DouyinMicroAppClient client, Models.PlatformDataAnalysisQueryPageDataV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "api", "platform", "v2", "data_analysis", "query_page_data/")
                .WithHeader("access-token", request.AccessToken)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp)
                .SetQueryParam("host_name", request.HostName)
                .SetQueryParam("os", request.OS)
                .SetQueryParam("version_type", request.VersionType);

            return await client.SendFlurlRequestAsJsonAsync<Models.PlatformDataAnalysisQueryPageDataV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
