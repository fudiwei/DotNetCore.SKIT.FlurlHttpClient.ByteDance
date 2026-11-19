namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static partial class TikTokV2ClientExecuteExtensions
    {
        #region MinisSubscription
        /// <summary>
        /// <para>异步调用 [POST] /minis/subscription/create/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-subscription-apis ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-minis-in-app-purchases-subscriptions ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisSubscriptionCreateResponse> ExecuteMinisSubscriptionCreateAsync(this TikTokV2Client client, Models.MinisSubscriptionCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "subscription", "create/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisSubscriptionCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/subscription/reactivate/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-subscription-apis ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-minis-in-app-purchases-subscriptions ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisSubscriptionReactivateResponse> ExecuteMinisSubscriptionReactivateAsync(this TikTokV2Client client, Models.MinisSubscriptionReactivateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "subscription", "reactivate/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisSubscriptionReactivateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/subscription/get_active_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-subscription-apis ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-minis-in-app-purchases-subscriptions ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisSubscriptionGetActiveListResponse> ExecuteMinisSubscriptionGetActiveListAsync(this TikTokV2Client client, Models.MinisSubscriptionGetActiveListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "subscription", "get_active_list/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisSubscriptionGetActiveListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/subscription/get_subscription_info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-subscription-apis ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisSubscriptionGetSubscriptionInfoResponse> ExecuteMinisSubscriptionGetSubscriptionInfoAsync(this TikTokV2Client client, Models.MinisSubscriptionGetSubscriptionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "subscription", "get_subscription_info/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisSubscriptionGetSubscriptionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/subscription/get_trade_order_info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-subscription-apis ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisSubscriptionGetTradeOrderInfoResponse> ExecuteMinisSubscriptionGetTradeOrderInfoAsync(this TikTokV2Client client, Models.MinisSubscriptionGetTradeOrderInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "subscription", "get_trade_order_info/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisSubscriptionGetTradeOrderInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/subscription/get_subscription_tier_info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-subscription-apis ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisSubscriptionGetSubscriptionTierInfoResponse> ExecuteMinisSubscriptionGetSubscriptionTierInfoAsync(this TikTokV2Client client, Models.MinisSubscriptionGetSubscriptionTierInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "subscription", "get_subscription_tier_info/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisSubscriptionGetSubscriptionTierInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MinisTradeOrder
        /// <summary>
        /// <para>异步调用 [POST] /minis/trade_order/create/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-payment-apis ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/in-app-purchases ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-minis-in-app-purchases ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisTradeOrderCreateResponse> ExecuteMinisTradeOrderCreateAsync(this TikTokV2Client client, Models.MinisTradeOrderCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "trade_order", "create/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisTradeOrderCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/trade_order/query/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-payment-apis ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/in-app-purchases ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisTradeOrderQueryResponse> ExecuteMinisTradeOrderQueryAsync(this TikTokV2Client client, Models.MinisTradeOrderQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "trade_order", "query/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisTradeOrderQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MinisUtility
        /// <summary>
        /// <para>异步调用 [POST] /minis/utility/get_tier_infos/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-payment-apis ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisUtilityGetTierInfosResponse> ExecuteMinisUtilityGetTierInfosAsync(this TikTokV2Client client, Models.MinisUtilityGetTierInfosRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "utility", "get_tier_infos/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisUtilityGetTierInfosResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /minis/utility/check_redeem_amounts/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-payment-apis ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MinisUtilityCheckRedeemAmountsResponse> ExecuteMinisUtilityCheckRedeemAmountsAsync(this TikTokV2Client client, Models.MinisUtilityCheckRedeemAmountsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "minis", "utility", "check_redeem_amounts/");

            return await client.SendFlurlRequestAsJsonAsync<Models.MinisUtilityCheckRedeemAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
