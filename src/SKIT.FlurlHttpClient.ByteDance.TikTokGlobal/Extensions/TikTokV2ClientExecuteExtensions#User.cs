namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    public static partial class TikTokV2ClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /user/info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-api-v2-get-user-info ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/minis-user-data ]]> <br/>
        /// <![CDATA[ https://developers.tiktok.com/doc/mini-games-explicit-authorization ]]>
        /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-minis-explicit-authorization ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserInfoResponse> ExecuteUserInfoAsync(this TikTokV2Client client, Models.UserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "user", "info/")
                .SetQueryParam("fields", request.FieldList is not null ? string.Join(",", request.FieldList) : null);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
