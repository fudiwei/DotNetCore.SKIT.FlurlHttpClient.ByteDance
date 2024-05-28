using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static class DouyinMicroAppClientExecuteTradeAuthDeveloperExtensions
    {
        #region AuthDeposit
        #region AuthDeposit/Auth
        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_admissible_auth/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/auth/query-admissible-auth ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQueryAdmissibleAuthV1Response> ExecuteTradeAuthDeveloperQueryAdmissibleAuthV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQueryAdmissibleAuthV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_admissible_auth/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQueryAdmissibleAuthV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/create_auth_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/auth/create-auth-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperCreateAuthOrderV1Response> ExecuteTradeAuthDeveloperCreateAuthOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperCreateAuthOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "create_auth_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperCreateAuthOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/cancel_auth_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/auth/cancel-auth-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperCancelAuthOrderV1Response> ExecuteTradeAuthDeveloperCancelAuthOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperCancelAuthOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "cancel_auth_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperCancelAuthOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/finish_auth_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/auth/finish-auth-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperFinishAuthOrderV1Response> ExecuteTradeAuthDeveloperFinishAuthOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperFinishAuthOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "finish_auth_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperFinishAuthOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_auth_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/auth/query-auth-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQueryAuthOrderV1Response> ExecuteTradeAuthDeveloperQueryAuthOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQueryAuthOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_auth_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQueryAuthOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region AuthDeposit/Pay
        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/create_pay_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/pay/create-pay-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperCreatePayOrderV1Response> ExecuteTradeAuthDeveloperCreatePayOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperCreatePayOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "create_pay_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperCreatePayOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/close_pay_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/pay/close-pay-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperClosePayOrderV1Response> ExecuteTradeAuthDeveloperClosePayOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperClosePayOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "close_pay_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperClosePayOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_pay_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/pay/query-pay-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQueryPayOrderV1Response> ExecuteTradeAuthDeveloperQueryPayOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQueryPayOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_pay_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQueryPayOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region AuthDeposit/Refund
        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/create_refund/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/refund/create-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperCreateRefundV1Response> ExecuteTradeAuthDeveloperCreateRefundV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperCreateRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "create_refund/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperCreateRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_refund/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/auth-deposit/refund/query-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQueryRefundV1Response> ExecuteTradeAuthDeveloperQueryRefundV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQueryRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_refund/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQueryRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region PeriodicDeduction
        #region PeriodicDeduction/Pay
        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/create_sign_pay/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/periodic-deduction/pay/create-sign-pay ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperCreateSignPayV1Response> ExecuteTradeAuthDeveloperCreateSignPayV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperCreateSignPayV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "create_sign_pay/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperCreateSignPayV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_sign_pay/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/periodic-deduction/pay/query-sign-pay ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQuerySignPayV1Response> ExecuteTradeAuthDeveloperQuerySignPayV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQuerySignPayV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_sign_pay/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQuerySignPayV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region PeriodicDeduction/Refund
        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/create_sign_refund/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/periodic-deduction/refund/create-sign-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperCreateSignRefundV1Response> ExecuteTradeAuthDeveloperCreateSignRefundV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperCreateSignRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "create_sign_refund/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperCreateSignRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_sign_refund/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/periodic-deduction/refund/query-sign-refund ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQuerySignRefundV1Response> ExecuteTradeAuthDeveloperQuerySignRefundV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQuerySignRefundV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_sign_refund/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQuerySignRefundV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region PeriodicDeduction/Sign
        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/terminate_sign/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/periodic-deduction/sign/terminate-sign ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperTerminateSignV1Response> ExecuteTradeAuthDeveloperTerminateSignV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperTerminateSignV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "terminate_sign/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperTerminateSignV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /api/trade_auth/v1/developer/query_sign_order/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/management-capacity/periodic-deduction/sign/query-sign-order ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TradeAuthDeveloperQuerySignOrderV1Response> ExecuteTradeAuthDeveloperQuerySignOrderV1Async(this DouyinMicroAppClient client, Models.TradeAuthDeveloperQuerySignOrderV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "trade_auth", "v1", "developer", "query_sign_order/")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.TradeAuthDeveloperQuerySignOrderV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion
    }
}
