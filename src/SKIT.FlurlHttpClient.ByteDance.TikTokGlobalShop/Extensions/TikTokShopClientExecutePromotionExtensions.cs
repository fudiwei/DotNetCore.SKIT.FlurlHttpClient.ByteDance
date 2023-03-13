using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientExecutePromotionExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/list 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262939 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionSearchActivitiesResponse> ExecutePromotionSearchActivitiesAsync(this TikTokShopClient client, Models.PromotionSearchActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promotion", "activity", "list")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.PromotionSearchActivitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /promotion/activity/get 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262942 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionGetActivityDetailResponse> ExecutePromotionGetActivityDetailAsync(this TikTokShopClient client, Models.PromotionGetActivityDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "promotion", "activity", "get")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId)
                .SetQueryParam("promotion_id", request.PromotionId);

            return await client.SendRequestWithJsonAsync<Models.PromotionGetActivityDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/create 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262944 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionCreateActivityResponse> ExecutePromotionCreateActivityAsync(this TikTokShopClient client, Models.PromotionCreateActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promotion", "activity", "create")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.PromotionCreateActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/update 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262881 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionUpdateActivityResponse> ExecutePromotionUpdateActivityAsync(this TikTokShopClient client, Models.PromotionUpdateActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promotion", "activity", "update")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.PromotionUpdateActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/deactivate 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262940 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionDeactivateActivityResponse> ExecutePromotionDeactivateActivityAsync(this TikTokShopClient client, Models.PromotionDeactivateActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promotion", "activity", "deactivate")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.PromotionDeactivateActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Items
        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/items/addorupdate 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262941 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionAddOrUpdateActivityItemsResponse> ExecutePromotionAddOrUpdateActivityItemsAsync(this TikTokShopClient client, Models.PromotionAddOrUpdateActivityItemsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promotion", "activity", "items", "addorupdate")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.PromotionAddOrUpdateActivityItemsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /promotion/activity/items/remove 接口。</para>
        /// <para>REF: https://partner.tiktokshop.com/doc/page/262941 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PromotionRemoveActivityItemsResponse> ExecutePromotionRemoveActivityItemsAsync(this TikTokShopClient client, Models.PromotionRemoveActivityItemsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "promotion", "activity", "items", "remove")
                .SetQueryParam("app_key", client.Credentials.AppKey)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("timestamp", request.Timestamp)
                .SetQueryParam("shop_id", request.ShopId);

            return await client.SendRequestWithJsonAsync<Models.PromotionRemoveActivityItemsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
