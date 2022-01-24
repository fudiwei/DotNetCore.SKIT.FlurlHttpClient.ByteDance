using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteAgentExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /2/agent/info 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710518158351 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentInfoResponse> ExecuteAgentInfoAsync(this OceanEngineClient client, Models.AgentInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "agent", "info")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/agent/child_agent/select 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710517693452 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentChildAgentSelectResponse> ExecuteAgentChildAgentSelectAsync(this OceanEngineClient client, Models.AgentChildAgentSelectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "agent", "child_agent", "select")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentChildAgentSelectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Advertiser
        /// <summary>
        /// <para>异步调用 [GET] /2/agent/advertiser/select 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710516003852 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentAdvertiserSelectResponse> ExecuteAgentAdvertiserSelectAsync(this OceanEngineClient client, Models.AgentAdvertiserSelectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "agent", "advertiser", "select")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentAdvertiserSelectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/agent/advertiser/create_v2 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710516003852 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentAdvertiserCreateV2Response> ExecuteAgentAdvertiserCreateV2Async(this OceanEngineClient client, Models.AgentAdvertiserCreateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "agent", "advertiser", "create_v2")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentAdvertiserCreateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/agent/advertiser/update 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710517205007 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentAdvertiserUpdateResponse> ExecuteAgentAdvertiserUpdateAsync(this OceanEngineClient client, Models.AgentAdvertiserUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "agent", "advertiser", "update")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentAdvertiserUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/agent/advertiser/recharge 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710527687680 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentAdvertiserRechargeResponse> ExecuteAgentAdvertiserRechargeAsync(this OceanEngineClient client, Models.AgentAdvertiserRechargeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "agent", "advertiser", "recharge")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentAdvertiserRechargeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/agent/advertiser/refund 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710528174095 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AgentAdvertiserRefundResponse> ExecuteAgentAdvertiserRefundAsync(this OceanEngineClient client, Models.AgentAdvertiserRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "agent", "advertiser", "refund")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AgentAdvertiserRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
