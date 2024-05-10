using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyClientExecutePromotionExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262939 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionSearchActivitiesResponse> ExecutePromotionSearchActivitiesAsync(this TikTokShopLegacyClient client, Models.PromotionSearchActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "promotion", "activity", "list");

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionSearchActivitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /promotion/activity/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262942 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionGetActivityDetailResponse> ExecutePromotionGetActivityDetailAsync(this TikTokShopLegacyClient client, Models.PromotionGetActivityDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "promotion", "activity", "get")
                .SetQueryParam("promotion_id", request.PromotionId);

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionGetActivityDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262944 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCreateActivityResponse> ExecutePromotionCreateActivityAsync(this TikTokShopLegacyClient client, Models.PromotionCreateActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "promotion", "activity", "create");

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionCreateActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262881 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionUpdateActivityResponse> ExecutePromotionUpdateActivityAsync(this TikTokShopLegacyClient client, Models.PromotionUpdateActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "promotion", "activity", "update");

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionUpdateActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/deactivate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262940 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionDeactivateActivityResponse> ExecutePromotionDeactivateActivityAsync(this TikTokShopLegacyClient client, Models.PromotionDeactivateActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "promotion", "activity", "deactivate");

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionDeactivateActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Items
        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/items/addorupdate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262941 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionAddOrUpdateActivityItemsResponse> ExecutePromotionAddOrUpdateActivityItemsAsync(this TikTokShopLegacyClient client, Models.PromotionAddOrUpdateActivityItemsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "promotion", "activity", "items", "addorupdate");

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionAddOrUpdateActivityItemsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/items/remove 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.tiktokshop.com/doc/page/262941 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionRemoveActivityItemsResponse> ExecutePromotionRemoveActivityItemsAsync(this TikTokShopLegacyClient client, Models.PromotionRemoveActivityItemsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "promotion", "activity", "items", "remove");

            return await client.SendFlurlRequesAsJsontAsync<Models.PromotionRemoveActivityItemsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
