using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternalPOIExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/base 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/poi-data/get-poi-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIBaseResponse> ExecuteDataExternalPOIBaseAsync(this TikTokClient client, Models.DataExternalPOIBaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "poi", "base")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("poi_id", request.POIId)
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.DataExternalPOIBaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/user 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/poi-data/poi-user-data </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/poi-data/poi-service-data </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/poi-data/poi-service-user-data </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/poi-data/poi-service-hot-list </para>
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
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/life-service-open-ability/poi-data/poi-claim-list </para>
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
