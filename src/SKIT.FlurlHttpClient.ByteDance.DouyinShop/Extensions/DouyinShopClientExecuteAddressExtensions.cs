using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    public static class DouyinShopClientExecuteAddressExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /address/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/13/558 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddressListResponse> ExecuteAddressListAsync(this DouyinShopClient client, Models.AddressListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "address", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AddressListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /address/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/13/741 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddressCreateResponse> ExecuteAddressCreateAsync(this DouyinShopClient client, Models.AddressCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "address", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AddressCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /address/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/13/742 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddressUpdateResponse> ExecuteAddressUpdateAsync(this DouyinShopClient client, Models.AddressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /address/getAreasByProvince 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/16/334 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddressGetAreasByProvinceResponse> ExecuteAddressGetAreasByProvinceAsync(this DouyinShopClient client, Models.AddressGetAreasByProvinceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "address", "getAreasByProvince")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AddressGetAreasByProvinceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /address/getProvince 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/api-docs/16/336 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddressGetProvinceResponse> ExecuteAddressGetProvinceAsync(this DouyinShopClient client, Models.AddressGetProvinceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "address", "getProvince")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AddressGetProvinceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
