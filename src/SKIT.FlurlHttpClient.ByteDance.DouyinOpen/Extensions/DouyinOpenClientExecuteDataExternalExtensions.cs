using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientExecuteDataExternalExtensions
    {
        #region Anchor
        /// <summary>
        /// <para>异步调用 [GET] /data/external/anchor/mp_item_click_distribution 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/mini-app-list/get-video-click-distribution </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalAnchorMpItemClickDistributionResponse> ExecuteDataExternalAnchorMpItemClickDistributionAsync(this DouyinOpenClient client, Models.DataExternalAnchorMpItemClickDistributionRequest request, CancellationToken cancellationToken = default)
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
        #endregion

        #region Billboard
        #region Billboard/HotVideo
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/hot_video 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/hot-video-list/hot-video-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardHotVideoResponse> ExecuteDataExternalBillboardHotVideoAsync(this DouyinOpenClient client, Models.DataExternalBillboardHotVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "hot_video")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardHotVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Sport
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/sport/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/sports-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportOverallResponse> ExecuteDataExternalBillboardSportOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportOverallRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/basketball-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportBasketballResponse> ExecuteDataExternalBillboardSportBasketballAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportBasketballRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/football-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportSoccerResponse> ExecuteDataExternalBillboardSportSoccerAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportSoccerRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/multiple-sports-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportComprehensiveResponse> ExecuteDataExternalBillboardSportComprehensiveAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportComprehensiveRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/fitness-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportFitnessResponse> ExecuteDataExternalBillboardSportFitnessAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportFitnessRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/outdoor-sports-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportOutdoorsResponse> ExecuteDataExternalBillboardSportOutdoorsAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportOutdoorsRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/billiards-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportTableTennisResponse> ExecuteDataExternalBillboardSportTableTennisAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportTableTennisRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/sports-list/sport-culture-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardSportCultureResponse> ExecuteDataExternalBillboardSportCultureAsync(this DouyinOpenClient client, Models.DataExternalBillboardSportCultureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "sport", "culture")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardSportCultureResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Amusement
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/amusement/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/funny-list-data/funny-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardAmusementOverallResponse> ExecuteDataExternalBillboardAmusementOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardAmusementOverallRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/funny-list-data/funny-new-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardAmusementNewResponse> ExecuteDataExternalBillboardAmusementNewAsync(this DouyinOpenClient client, Models.DataExternalBillboardAmusementNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "amusement", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardAmusementNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Game
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/game/console 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/game-list-data/computer-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardGameConsoleResponse> ExecuteDataExternalBillboardGameConsoleAsync(this DouyinOpenClient client, Models.DataExternalBillboardGameConsoleRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/game-list-data/game-information-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardGameInformationResponse> ExecuteDataExternalBillboardGameInformationAsync(this DouyinOpenClient client, Models.DataExternalBillboardGameInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "game", "inf")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardGameInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Food
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/food/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/food-list-data/food-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodOverallResponse> ExecuteDataExternalBillboardFoodOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardFoodOverallRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/food-list-data/food-new-list  </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodNewResponse> ExecuteDataExternalBillboardFoodNewAsync(this DouyinOpenClient client, Models.DataExternalBillboardFoodNewRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/food-list-data/food-guide-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodTutorialResponse> ExecuteDataExternalBillboardFoodTutorialAsync(this DouyinOpenClient client, Models.DataExternalBillboardFoodTutorialRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/food-list-data/food-discover-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardFoodShopResponse> ExecuteDataExternalBillboardFoodShopAsync(this DouyinOpenClient client, Models.DataExternalBillboardFoodShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "food", "shop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardFoodShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Drama
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/drama/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/plot-list-data/plot-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardDramaOverallResponse> ExecuteDataExternalBillboardDramaOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardDramaOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "drama", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardDramaOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Car
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/car/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/car-list-data/car-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarOverallResponse> ExecuteDataExternalBillboardCarOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardCarOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "car", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCarOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/car/comment 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/car-list-data/comment </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarCommentResponse> ExecuteDataExternalBillboardCarCommentAsync(this DouyinOpenClient client, Models.DataExternalBillboardCarCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "car", "comment")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCarCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/car/play 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/car-list-data/play </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarPlayResponse> ExecuteDataExternalBillboardCarPlayAsync(this DouyinOpenClient client, Models.DataExternalBillboardCarPlayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "car", "play")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCarPlayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/car/use 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/car-list-data/drive </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarUseResponse> ExecuteDataExternalBillboardCarUseAsync(this DouyinOpenClient client, Models.DataExternalBillboardCarUseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "car", "use")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCarUseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/car/driver 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/car-list-data/exam </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarDriverResponse> ExecuteDataExternalBillboardCarDriverAsync(this DouyinOpenClient client, Models.DataExternalBillboardCarDriverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "car", "driver")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCarDriverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Travel
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/travel/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/tour-list-data/tour-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardTravelOverallResponse> ExecuteDataExternalBillboardTravelOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardTravelOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "travel", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardTravelOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/travel/new 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/tour-list-data/tour-new-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardTravelNewResponse> ExecuteDataExternalBillboardTravelNewAsync(this DouyinOpenClient client, Models.DataExternalBillboardTravelNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "travel", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardTravelNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Cospa
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/overall 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/anime-overall-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaOverallResponse> ExecuteDataExternalBillboardCospaOverallAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaOverallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "overall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaOverallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/qing_man 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/light-anime </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaQingmanResponse> ExecuteDataExternalBillboardCospaQingmanAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaQingmanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "qing_man")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaQingmanResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/out_shot 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/shoot </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaOutshotResponse> ExecuteDataExternalBillboardCospaOutshotAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaOutshotRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "out_shot")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaOutshotResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/painting 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/draw </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaPaintingResponse> ExecuteDataExternalBillboardCospaPaintingAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaPaintingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "painting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaPaintingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/voice_control 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/sound </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaVoiceResponse> ExecuteDataExternalBillboardCospaVoiceAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaVoiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "voice_control")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaVoiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/brain_cavity 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/imagine </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaBrainCavityResponse> ExecuteDataExternalBillboardCospaBrainCavityAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaBrainCavityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "brain_cavity")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaBrainCavityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/new 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/anime-list-data/anime-new-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaNewResponse> ExecuteDataExternalBillboardCospaNewAsync(this DouyinOpenClient client, Models.DataExternalBillboardCospaNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Stars
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/stars 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/entertainment-star-list-data/entertainment-star-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardStarsResponse> ExecuteDataExternalBillboardStarsAsync(this DouyinOpenClient client, Models.DataExternalBillboardStarsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "stars")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardStarsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Live
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/live 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/live-list-data/live-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardLiveResponse> ExecuteDataExternalBillboardLiveAsync(this DouyinOpenClient client, Models.DataExternalBillboardLiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "live")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardLiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Music
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/music/hot 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/music-list-data/hot-songs-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardMusicHotResponse> ExecuteDataExternalBillboardMusicHotAsync(this DouyinOpenClient client, Models.DataExternalBillboardMusicHotRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "music", "hot")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardMusicHotResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/music/soar 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/music-list-data/ascending-songs-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardMusicSoarResponse> ExecuteDataExternalBillboardMusicSoarAsync(this DouyinOpenClient client, Models.DataExternalBillboardMusicSoarRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "music", "soar")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardMusicSoarResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/music/original 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/music-list-data/original-songs-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardMusicOriginalResponse> ExecuteDataExternalBillboardMusicOriginalAsync(this DouyinOpenClient client, Models.DataExternalBillboardMusicOriginalRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "music", "original")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardMusicOriginalResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Topic
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/topic 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/topic-list-data/topic-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardTopicResponse> ExecuteDataExternalBillboardTopicAsync(this DouyinOpenClient client, Models.DataExternalBillboardTopicRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "topic")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardTopicResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Billboard/Prop
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/prop 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/tops-data/prop-list-data/prop-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardPropResponse> ExecuteDataExternalBillboardPropAsync(this DouyinOpenClient client, Models.DataExternalBillboardPropRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "prop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardPropResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Fans
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/fans/source 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/fans-portrait-data/get-user-fans-origin </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalFansSourceResponse> ExecuteDataExternalFansSourceAsync(this DouyinOpenClient client, Models.DataExternalFansSourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "fans", "source")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalFansSourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/fans/favourite 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/fans-portrait-data/get-user-fans-like </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalFansFavouriteResponse> ExecuteDataExternalFansFavouriteAsync(this DouyinOpenClient client, Models.DataExternalFansFavouriteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "fans", "favourite")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalFansFavouriteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/extern/fans/comment 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/fans-portrait-data/get-user-fans-hot-comment </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalFansCommentResponse> ExecuteDataExternalFansCommentAsync(this DouyinOpenClient client, Models.DataExternalFansCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "fans", "comment")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalFansCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Item
        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/base 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/video-data/get-basic-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemBaseResponse> ExecuteDataExternalItemBaseAsync(this DouyinOpenClient client, Models.DataExternalItemBaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "base")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemBaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/like 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/video-data/get-like-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemLikeResponse> ExecuteDataExternalItemLikeAsync(this DouyinOpenClient client, Models.DataExternalItemLikeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "like")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemLikeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/comment 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/video-data/get-comment-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemCommentResponse> ExecuteDataExternalItemCommentAsync(this DouyinOpenClient client, Models.DataExternalItemCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "comment")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/play 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/video-data/get-play-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemPlayResponse> ExecuteDataExternalItemPlayAsync(this DouyinOpenClient client, Models.DataExternalItemPlayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "play")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemPlayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/item/share 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/video-data/get-share-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalItemShareResponse> ExecuteDataExternalItemShareAsync(this DouyinOpenClient client, Models.DataExternalItemShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "item", "share")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("item_id", request.ItemId);

            return await client.SendRequestWithJsonAsync<Models.DataExternalItemShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region POI
        /// <summary>
        /// <para>异步调用 [GET] /data/external/poi/base 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-data/get-poi-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIBaseResponse> ExecuteDataExternalPOIBaseAsync(this DouyinOpenClient client, Models.DataExternalPOIBaseRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-data/poi-user-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIUserResponse> ExecuteDataExternalPOIUserAsync(this DouyinOpenClient client, Models.DataExternalPOIUserRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-data/poi-service-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIServiceBaseResponse> ExecuteDataExternalPOIServiceBaseAsync(this DouyinOpenClient client, Models.DataExternalPOIServiceBaseRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-data/poi-service-user-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIServiceUserResponse> ExecuteDataExternalPOIServiceUserAsync(this DouyinOpenClient client, Models.DataExternalPOIServiceUserRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-data/poi-service-hot-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIBillboardResponse> ExecuteDataExternalPOIBillboardAsync(this DouyinOpenClient client, Models.DataExternalPOIBillboardRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/micro-app/poi-data/poi-claim-list </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalPOIClaimListResponse> ExecuteDataExternalPOIClaimListAsync(this DouyinOpenClient client, Models.DataExternalPOIClaimListRequest request, CancellationToken cancellationToken = default)
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
        #endregion

        #region SDK
        /// <summary>
        /// <para>异步调用 [GET] /data/external/sdk_share 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/openapi/data-open-service/sdk-share-video-data/get-share-data </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-08-09 下线。")]
        public static async Task<Models.DataExternalSDKShareResponse> ExecuteDataExternalSDKShareAsync(this DouyinOpenClient client, Models.DataExternalSDKShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "sdk_share")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.DataExternalSDKShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region User
        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/item 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/user-data/get-user-video-status </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserItemResponse> ExecuteDataExternalUserItemAsync(this DouyinOpenClient client, Models.DataExternalUserItemRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "item")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserItemResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/fans 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/user-data/get-user-fans-count </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserFansResponse> ExecuteDataExternalUserFansAsync(this DouyinOpenClient client, Models.DataExternalUserFansRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "fans")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserFansResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/like 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/user-data/get-user-like-number </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserLikeResponse> ExecuteDataExternalUserLikeAsync(this DouyinOpenClient client, Models.DataExternalUserLikeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "like")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserLikeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/comment 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/user-data/get-user-comment-count </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserCommentResponse> ExecuteDataExternalUserCommentAsync(this DouyinOpenClient client, Models.DataExternalUserCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "comment")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/share 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/user-data/get-user-share-count </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserShareResponse> ExecuteDataExternalUserShareAsync(this DouyinOpenClient client, Models.DataExternalUserShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "share")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /data/external/user/profile 接口。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/data-open-service/user-data/get-user-home-pv </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalUserProfileResponse> ExecuteDataExternalUserProfileAsync(this DouyinOpenClient client, Models.DataExternalUserProfileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "external", "user", "profile")
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_type", request.DateType);

            return await client.SendRequestWithJsonAsync<Models.DataExternalUserProfileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
