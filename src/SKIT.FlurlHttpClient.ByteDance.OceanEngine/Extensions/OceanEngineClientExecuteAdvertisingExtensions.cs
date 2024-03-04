using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteAdvertisingExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /2/ad/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710535150604 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingGetResponse> ExecuteAdvertisingGetAsync(this OceanEngineClient client, Models.AdvertisingGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "2", "ad", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/ad/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1701607421369355 ]]> <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710535694348 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingCreateResponse> ExecuteAdvertisingCreateAsync(this OceanEngineClient client, Models.AdvertisingCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "2", "ad", "create")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/ad/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1701620468172800 ]]> <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710536211456 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingUpdateResponse> ExecuteAdvertisingUpdateAsync(this OceanEngineClient client, Models.AdvertisingUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "2", "ad", "update")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/ad/update/status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1701620468172800 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingUpdateStatusResponse> ExecuteAdvertisingUpdateStatusAsync(this OceanEngineClient client, Models.AdvertisingUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "2", "ad", "update", "status")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/ad/update/budget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710537225231 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingUpdateBudgetResponse> ExecuteAdvertisingUpdateBudgetAsync(this OceanEngineClient client, Models.AdvertisingUpdateBudgetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "2", "ad", "update", "budget")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingUpdateBudgetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/ad/update/bid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710537746444 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingUpdateBidResponse> ExecuteAdvertisingUpdateBidAsync(this OceanEngineClient client, Models.AdvertisingUpdateBidRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "2", "ad", "update", "bid")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingUpdateBidResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/ad/reject_reason 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710537746444 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingRejectReasonResponse> ExecuteAdvertisingRejectReasonAsync(this OceanEngineClient client, Models.AdvertisingRejectReasonRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "2", "ad", "reject_reason")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingRejectReasonResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/ad/cost_protect_status/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1697193170177032 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdvertisingCostProtectStatusGetResponse> ExecuteAdvertisingCostProtectStatusGetAsync(this OceanEngineClient client, Models.AdvertisingCostProtectStatusGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "2", "ad", "cost_protect_status", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.AdvertisingCostProtectStatusGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
