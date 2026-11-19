namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    public static partial class DouyinMicroAppClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /api/gift/receive_reward 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-game/develop/server/receive-reward ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GiftReceiveRewardResponse> ExecuteGiftReceiveRewardAsync(this DouyinMicroAppClient client, Models.GiftReceiveRewardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "api", "gift", "receive_reward")
                .WithHeader("access-token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.GiftReceiveRewardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
