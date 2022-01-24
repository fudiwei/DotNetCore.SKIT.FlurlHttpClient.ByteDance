using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteAdvertiserExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/info 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710509559820 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserInfoResponse> ExecuteAdvertiserInfoAsync(this OceanEngineClient client, Models.AdvertiserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "info")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/public_info 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710511950860 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserPublicInfoResponse> ExecuteAdvertiserPublicInfoAsync(this OceanEngineClient client, Models.AdvertiserPublicInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "public_info")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserPublicInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Qualification
        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/qualification/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710509559820 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserQualificationGetResponse> ExecuteAdvertiserQualificationGetAsync(this OceanEngineClient client, Models.AdvertiserQualificationGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "qualification", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserQualificationGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/advertiser/qualification/submit 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710510055424 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserQualificationSubmitResponse> ExecuteAdvertiserQualificationSubmitAsync(this OceanEngineClient client, Models.AdvertiserQualificationSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "advertiser", "qualification", "submit")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserQualificationSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/qualification/select_v2 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710513397775 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserQualificationSelectV2Response> ExecuteAdvertiserQualificationSelectV2Async(this OceanEngineClient client, Models.AdvertiserQualificationSelectV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "qualification", "select_v2")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserQualificationSelectV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/advertiser/qualification/create_v2 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710514343951 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserQualificationCreateV2Response> ExecuteAdvertiserQualificationCreateV2Async(this OceanEngineClient client, Models.AdvertiserQualificationCreateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "advertiser", "qualification", "create_v2")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserQualificationCreateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Avatar
        /// <summary>
        /// <para>异步调用 [POST] /2/advertiser/avatar/submit 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710512435215 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserAvatarSubmitResponse> ExecuteAdvertiserAvatarSubmitAsync(this OceanEngineClient client, Models.AdvertiserAvatarSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "advertiser", "avatar", "submit")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserAvatarSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/avatar/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710512904192 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserAvatarGetResponse> ExecuteAdvertiserAvatarGetAsync(this OceanEngineClient client, Models.AdvertiserAvatarGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "avatar", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserAvatarGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Fund
        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/fund/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710526192652 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserFundGetResponse> ExecuteAdvertiserFundGetAsync(this OceanEngineClient client, Models.AdvertiserFundGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "fund", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserFundGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/fund/daily_stat 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710526682112 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserFundDailyStatisticsResponse> ExecuteAdvertiserFundDailyStatisticsAsync(this OceanEngineClient client, Models.AdvertiserFundDailyStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "fund", "daily_stat")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserFundDailyStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/fund/transaction/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710527205388 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserFundTransactionGetResponse> ExecuteAdvertiserFundTransactionGetAsync(this OceanEngineClient client, Models.AdvertiserFundTransactionGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "fund", "transaction", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserFundTransactionGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Budget
        /// <summary>
        /// <para>异步调用 [GET] /2/advertiser/budget/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710531128335 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserBudgetGetResponse> ExecuteAdvertiserBudgetGetAsync(this OceanEngineClient client, Models.AdvertiserBudgetGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "advertiser", "budget", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserBudgetGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/advertiser/update/budget 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710531631116 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertiserUpdateBudgetResponse> ExecuteAdvertiserUpdateBudgetAsync(this OceanEngineClient client, Models.AdvertiserUpdateBudgetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "advertiser", "update", "budget")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdvertiserUpdateBudgetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
