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
        
        #region Car
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/car/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972511904417795 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarOverallResponse> ExecuteDataExternalBillboardCarOverallAsync(this TikTokClient client, Models.DataExternalBillboardCarOverallRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866709768204 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarCommentResponse> ExecuteDataExternalBillboardCarCommentAsync(this TikTokClient client, Models.DataExternalBillboardCarCommentRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908962762139977731 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarPlayResponse> ExecuteDataExternalBillboardCarPlayAsync(this TikTokClient client, Models.DataExternalBillboardCarPlayRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908962762140026883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarUseResponse> ExecuteDataExternalBillboardCarUseAsync(this TikTokClient client, Models.DataExternalBillboardCarUseRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866709817356 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCarDriverResponse> ExecuteDataExternalBillboardCarDriverAsync(this TikTokClient client, Models.DataExternalBillboardCarDriverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "car", "driver")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCarDriverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Travel
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/travel/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866969733124 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardTravelOverallResponse> ExecuteDataExternalBillboardTravelOverallAsync(this TikTokClient client, Models.DataExternalBillboardTravelOverallRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908972511904466947 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardTravelNewResponse> ExecuteDataExternalBillboardTravelNewAsync(this TikTokClient client, Models.DataExternalBillboardTravelNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "travel", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardTravelNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Cospa
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/cospa/overall 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972511904516099 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaOverallResponse> ExecuteDataExternalBillboardCospaOverallAsync(this TikTokClient client, Models.DataExternalBillboardCospaOverallRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908972511904565251 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaQingmanResponse> ExecuteDataExternalBillboardCospaQingmanAsync(this TikTokClient client, Models.DataExternalBillboardCospaQingmanRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908962762370680843 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaOutshotResponse> ExecuteDataExternalBillboardCospaOutshotAsync(this TikTokClient client, Models.DataExternalBillboardCospaOutshotRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866969782276 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaPaintingResponse> ExecuteDataExternalBillboardCospaPaintingAsync(this TikTokClient client, Models.DataExternalBillboardCospaPaintingRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908972512596494348 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaVoiceResponse> ExecuteDataExternalBillboardCospaVoiceAsync(this TikTokClient client, Models.DataExternalBillboardCospaVoiceRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908962762370631691 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaBrainCavityResponse> ExecuteDataExternalBillboardCospaBrainCavityAsync(this TikTokClient client, Models.DataExternalBillboardCospaBrainCavityRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866969831428 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardCospaNewResponse> ExecuteDataExternalBillboardCospaNewAsync(this TikTokClient client, Models.DataExternalBillboardCospaNewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "cospa", "new")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardCospaNewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Stars
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/stars 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908932866969831428 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardStarsResponse> ExecuteDataExternalBillboardStarsAsync(this TikTokClient client, Models.DataExternalBillboardStarsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "stars")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardStarsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Live
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/live 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908950744699766796 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardLiveResponse> ExecuteDataExternalBillboardLiveAsync(this TikTokClient client, Models.DataExternalBillboardLiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "live")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardLiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Music
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/music/hot 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908972512596592652 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardMusicHotResponse> ExecuteDataExternalBillboardMusicHotAsync(this TikTokClient client, Models.DataExternalBillboardMusicHotRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908970631979632644 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardMusicSoarResponse> ExecuteDataExternalBillboardMusicSoarAsync(this TikTokClient client, Models.DataExternalBillboardMusicSoarRequest request, CancellationToken cancellationToken = default)
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
        /// <para>REF: https://open.douyin.com/platform/doc/6908950744699865100 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardMusicOriginalResponse> ExecuteDataExternalBillboardMusicOriginalAsync(this TikTokClient client, Models.DataExternalBillboardMusicOriginalRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "music", "original")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardMusicOriginalResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Topic
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/topic 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908950744699815948 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardTopicResponse> ExecuteDataExternalBillboardTopicAsync(this TikTokClient client, Models.DataExternalBillboardTopicRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "topic")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardTopicResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Prop
        /// <summary>
        /// <para>异步调用 [GET] /data/extern/billboard/prop 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6908971406340392963 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataExternalBillboardPropResponse> ExecuteDataExternalBillboardPropAsync(this TikTokClient client, Models.DataExternalBillboardPropRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "data", "extern", "billboard", "prop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataExternalBillboardPropResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
