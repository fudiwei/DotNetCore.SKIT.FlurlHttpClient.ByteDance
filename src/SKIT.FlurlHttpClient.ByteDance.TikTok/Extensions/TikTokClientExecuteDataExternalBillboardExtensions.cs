using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecuteDataExternalBillboardExtensions
    {
        #region HotVideo
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/hot_video 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908910551393437707 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardHotVideoResponse> ExecuteDataExternalBillboardHotVideoAsync(this TikTokClient client, Models.DataExternalBillboardHotVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "hot_video")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardHotVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        
        #region Sport
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908910551393486859 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportOverallResponse> ExecuteDataExternalBillboardSportOverallAsync(this TikTokClient client, Models.DataExternalBillboardSportOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/basketball 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908957982965450756 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportBasketballResponse> ExecuteDataExternalBillboardSportBasketballAsync(this TikTokClient client, Models.DataExternalBillboardSportBasketballRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "basketball")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportBasketballResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/soccer 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972452743776267 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportSoccerResponse> ExecuteDataExternalBillboardSportSoccerAsync(this TikTokClient client, Models.DataExternalBillboardSportSoccerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "soccer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportSoccerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/comprehensive 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908910551598893060 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportComprehensiveResponse> ExecuteDataExternalBillboardSportComprehensiveAsync(this TikTokClient client, Models.DataExternalBillboardSportComprehensiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "comprehensive")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportComprehensiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/fitness 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972452743825419 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportFitnessResponse> ExecuteDataExternalBillboardSportFitnessAsync(this TikTokClient client, Models.DataExternalBillboardSportFitnessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "fitness")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportFitnessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/outdoors 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908957982965499908 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportOutdoorsResponse> ExecuteDataExternalBillboardSportOutdoorsAsync(this TikTokClient client, Models.DataExternalBillboardSportOutdoorsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "outdoors")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportOutdoorsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/table_tennis 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908910551598942212 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportTableTennisResponse> ExecuteDataExternalBillboardSportTableTennisAsync(this TikTokClient client, Models.DataExternalBillboardSportTableTennisRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "table_tennis")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportTableTennisResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/culture 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972452743874571 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportCultureResponse> ExecuteDataExternalBillboardSportCultureAsync(this TikTokClient client, Models.DataExternalBillboardSportCultureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "culture")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportCultureResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Amusement
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/amusement/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908957983204460556 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardAmusementOverallResponse> ExecuteDataExternalBillboardAmusementOverallAsync(this TikTokClient client, Models.DataExternalBillboardAmusementOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "amusement", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardAmusementOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/amusement/new 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908910551598991364 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardAmusementNewResponse> ExecuteDataExternalBillboardAmusementNewAsync(this TikTokClient client, Models.DataExternalBillboardAmusementNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "amusement", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardAmusementNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Amusement
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/game/console 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908957983204509708 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardGameConsoleResponse> ExecuteDataExternalBillboardGameConsoleAsync(this TikTokClient client, Models.DataExternalBillboardGameConsoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "game", "console")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardGameConsoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/game/inf 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908910551599040516 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardGameInformationResponse> ExecuteDataExternalBillboardGameInformationAsync(this TikTokClient client, Models.DataExternalBillboardGameInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "game", "inf")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardGameInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Food
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/food/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972452978640907 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodOverallResponse> ExecuteDataExternalBillboardFoodOverallAsync(this TikTokClient client, Models.DataExternalBillboardFoodOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "food", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardFoodOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/food/new 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972452978690059 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodNewResponse> ExecuteDataExternalBillboardFoodNewAsync(this TikTokClient client, Models.DataExternalBillboardFoodNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "food", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardFoodNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/food/tutorial 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908957983204558860 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodTutorialResponse> ExecuteDataExternalBillboardFoodTutorialAsync(this TikTokClient client, Models.DataExternalBillboardFoodTutorialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "food", "tutorial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardFoodTutorialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/food/shop 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866709719052 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodShopResponse> ExecuteDataExternalBillboardFoodShopAsync(this TikTokClient client, Models.DataExternalBillboardFoodShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "food", "shop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardFoodShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Drama
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/drama/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972452978739211 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardDramaOverallResponse> ExecuteDataExternalBillboardDramaOverallAsync(this TikTokClient client, Models.DataExternalBillboardDramaOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "drama", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardDramaOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
