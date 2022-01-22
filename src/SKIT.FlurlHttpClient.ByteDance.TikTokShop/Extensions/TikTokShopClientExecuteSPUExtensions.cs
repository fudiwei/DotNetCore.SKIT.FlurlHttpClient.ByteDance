using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteSPUExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /spu/getKeyPropertyByCid 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/642 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SPUGetKeyPropertyByCategoryIdResponse> ExecuteSPUGetKeyPropertyByCategoryIdAsync(this TikTokShopClient client, Models.SPUGetKeyPropertyByCategoryIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "spu", "getKeyPropertyByCid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.SPUGetKeyPropertyByCategoryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /spu/getSpuTpl 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/644 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SPUGetSPUTemplateResponse> ExecuteSPUGetSPUTemplateAsync(this TikTokShopClient client, Models.SPUGetSPUTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "spu", "getSpuTpl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.SPUGetSPUTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /spu/getSpuInfoBySpuId 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/643 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SPUGetSPUInformationBySPUIdResponse> ExecuteSPUGetSPUInformationBySPUIdAsync(this TikTokShopClient client, Models.SPUGetSPUInformationBySPUIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "spu", "getSpuInfoBySpuId")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.SPUGetSPUInformationBySPUIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /spu/addShopSpu 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/645 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SPUAddShopSPUResponse> ExecuteSPUAddShopSPUAsync(this TikTokShopClient client, Models.SPUAddShopSPURequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "spu", "addShopSpu")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.SPUAddShopSPUResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
