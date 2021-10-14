using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternalAnchorExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /data/external/anchor/mp_item_click_distribution 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6874570865061660685 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalAnchorMpItemClickDistributionResponse> ExecuteDataExternalAnchorMpItemClickDistributionAsync(this TikTokClient client, Models.DataExternalAnchorMpItemClickDistributionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "anchor", "mp_item_click_distribution")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("mp_id", request.MiniAppId)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalAnchorMpItemClickDistributionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/user 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798428881782788 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIUserResponse> ExecuteDataExternalPOIUserAsync(this TikTokClient client, Models.DataExternalPOIUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "poi", "user")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("poi_id", request.POIId)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalPOIUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/service_base 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798407369295875 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIServiceBaseResponse> ExecuteDataExternalPOIServiceBaseAsync(this TikTokClient client, Models.DataExternalPOIServiceBaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "poi", "service_base")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("poi_id", request.POIId)
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString);

            if (request.ServiceType != null)
                flurlReq.SetQueryParam("service_type", request.ServiceType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalPOIServiceBaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/service_user 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798428881750020 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIServiceUserResponse> ExecuteDataExternalPOIServiceUserAsync(this TikTokClient client, Models.DataExternalPOIServiceUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "poi", "service_user")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("poi_id", request.POIId)
                .SetQueryParam("date_type", request.DateType);

            if (request.ServiceType != null)
                flurlReq.SetQueryParam("service_type", request.ServiceType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalPOIServiceUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/billboard 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798428881848324 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIBillboardResponse> ExecuteDataExternalPOIBillboardAsync(this TikTokClient client, Models.DataExternalPOIBillboardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "poi", "billboard")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("billboard_type", request.BillboardType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalPOIBillboardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/claim/list 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798407369263107 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIClaimListResponse> ExecuteDataExternalPOIClaimListAsync(this TikTokClient client, Models.DataExternalPOIClaimListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "poi", "claim", "list")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("cursor", request.PageCursor)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.DataExternalPOIClaimListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
