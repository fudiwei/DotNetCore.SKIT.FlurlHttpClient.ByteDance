using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Extensions
{
    public static class ByteDanceMicroAppAuthEntityClientExecuteExtensions
    {

        /// <summary>
        /// 该接口用于上传资质材料。在审核资质之前需要需要先使用该接口上传资质。如果需要大批量上传资质材料，请保证上传 QPS 不大于 10。
        /// 上传资源后会立即得到一个 uri，该 uri 是作为上传资质接口中材料的 path 参数。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityUploadMaterialResponse> ExecuteAuthEntityUploadMaterialAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityUploadMaterialRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "upload_material");
                // .PostMultipartAsync();

            using MultipartFormDataContent httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType!, formDataName: "material_file");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.MaterialType.ToString())), "material_type");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.AccessToken)), "access_token");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.AppId)), "appid");
            // httpContent.add
            var resp = await client.SendRequestAsync<Models.AuthEntityUploadMaterialResponse>(flurlReq, httpContent, cancellationToken: cancellationToken);
            return resp;
        }

        /// <summary>
        /// 该接口用于服务商帮助老师或机构入驻，调用成功过后，基础认证资质和角色下类目认证资质(服务商没有该信息)都会进审，接口返回实体的唯一标识 entity_id 以及审核 ID，审核通过后资质生效。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityByPartnerResponse> ExecuteAuthEntityByPartnerAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityByPartnerRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "bypartner");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityByPartnerResponse>(flurlReq, request, cancellationToken: cancellationToken);
            return resp;
        }

        /// <summary>
        /// 该接口用于服务商/机构的入驻，调用成功过后，基础认证资质和角色下类目认证资质(服务商没有该信息)都会进审，接口返回实体的唯一标识 entity_id 以及审核 ID，审核通过后资质生效
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityBySelfResponse> ExecuteAuthEntityBySelfAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityBySelfRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "byself");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityBySelfResponse>(flurlReq, request, cancellationToken: cancellationToken);
            return resp;
        }


        /// <summary>
        /// 该接口用于已入驻实体添加角色，调用成功过后，角色下类目认证(服务商没有该信息)会进审，接口返回审核 ID，审核通过后角色生效。
        /// - 已有代运营服务商角色要新增机构角色。
        /// - 已有机构角色实体要新增代运营服务商角色。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityAddRoleResponse> ExecuteAuthEntityAddRoleAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityAddRoleRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "add_role");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityAddRoleResponse>(flurlReq, request, cancellationToken: cancellationToken);
            return resp;
        }



        /// <summary>
        /// 该接口用于获取实体基础认证资质信息
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityGetBasicAuthResponse> ExecuteAuthEntityGetBasicAuthAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityGetBasicAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_basic_auth");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityGetBasicAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于更新实体基础认证授权信息
        /// a) 服务商实体/机构实体自主更新实体
        /// b) 服务商帮助老师更新实体基础认证信息
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityUpdateBasicAuthResponse> ExecuteAuthEntityUpdateBasicAuthAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityUpdateBasicAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "update_basic_auth");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityUpdateBasicAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于查询实体类目认证资质信息
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityGetClassAuthResponse> ExecuteAuthEntityGetClassAuthAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityGetClassAuthRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_class_auth");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityGetClassAuthResponse>(flurlReq, request, cancellationToken: cancellationToken);
            return resp;
        }


        /// <summary>
        /// 该接口用于更新实体类目认证资质
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityUpdateClassAuthResponse> ExecuteAuthEntityUpdateClassAuthAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityUpdateClassAuthRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "update_class_auth");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityUpdateClassAuthResponse>(flurlReq, request, cancellationToken: cancellationToken);
            return resp;
        }


        /// <summary>
        /// 该接口用于服务商代(老师/代运营模式机构)添加类目；自营模式机构添加类目
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityAddClassAuthResponse> ExecuteAuthEntityAddClassAuthAsync(this ByteDanceMicroAppAuthEntityClient client,Models.AuthEntityAddClassAuthRequest request,CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "add_class_auth");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityAddClassAuthResponse>(flurlReq, request, cancellationToken: cancellationToken);
            return resp;
        }


        /// <summary>
        /// 该接口用于根据审核任务类型和任务 ID 获取审核任务详情接口
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityGetAuditDetailResponse> ExecuteAuthEntityGetAuditDetailAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityGetAuditDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_audit_detail");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityGetAuditDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于角色绑定小程序，是认领小程序的过程。只有拥有小程序的角色才可以调用绑定接口认领小程序。
        /// 仅代运营服务商和自营模式机构需要调用该接口
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityRoleBindOrUnResponse> ExecuteAuthEntityBindRoleAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityRoleBindOrUnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "bind_role");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityRoleBindOrUnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于角色解除绑定小程序
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityRoleBindOrUnResponse> ExecuteAuthEntityUnBindRoleAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityRoleBindOrUnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "unbind_role");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityRoleBindOrUnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于查询小程序绑定的角色
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityGetBindListResponse> ExecuteAuthEntityGetBindListAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityGetBindListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_bind_list");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityGetBindListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于角色授权小程序，某角色将运营的权限授予给某个小程序。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityAuthRoleResponse> ExecuteAuthEntityAuthRoleAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityAuthRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "auth_role");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityAuthRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于解除商家实体和小程序之间的授权关系
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityUnAuthRoleResponse> ExecuteAuthEntityUnAuthRoleAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityUnAuthRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "un_auth_role");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityUnAuthRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于查询授权小程序信息
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityGetAppidAuthResponse> ExecuteAuthEntityGetAppidAuthAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityGetAppidAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "get_appid_auth");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityGetAppidAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于更新授权小程序授权函
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityUpdateAuthLetterResponse> ExecuteAuthEntityUpdateAuthLetterAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityUpdateAuthLetterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "update_authletter");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityUpdateAuthLetterResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }


        /// <summary>
        /// 该接口用于激活泛知识存量商户号
        /// 泛知识商家实体业务场景下只有绑定了老师角色实体 ID 的商户号才能用于泛知识小程序的收款，该接口提供给泛知识开发者可以将存量商户号迁移到新逻辑下。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityActivateMerchantCodeResponse> ExecuteAuthEntityActivateMerchantCodeAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityActivateMerchantCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "activate_merchantcode");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityActivateMerchantCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        /// <summary>
        /// 该接口用于查询激活泛知识存量商户号的状态
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<Models.AuthEntityQueryMerchantCodeStatusResponse> ExecuteAuthEntityQueryMerchantCodeStatusAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityQueryMerchantCodeStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_merchantcode_status");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityQueryMerchantCodeStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }

        public static async Task<Models.AuthEntityQueryEntityInfoResponse> ExecuteAuthEntityQueryEntityInfoAsync(this ByteDanceMicroAppAuthEntityClient client, Models.AuthEntityQueryEntityInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "query_entity_info");

            var resp = await client.SendRequestWithJsonAsync<Models.AuthEntityQueryEntityInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            return resp;

        }



    }
}
