using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public static class DouyinMicroAppOpenApiClientExecuteAppsICPRecordExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apps/v1/icp_record/upload_image/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/upload-image ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordUploadImageV1Response> ExecuteOpenAppsICPRecordUploadImageV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordUploadImageV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.ImageFileName) ?? "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v1", "icp_record", "upload_image/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "image");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.ImageType.ToString())), "image_type");

            return await client.SendFlurlRequestAsync<Models.OpenAppsICPRecordUploadImageV1Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/get_facial_recognition_url/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/get-facial-recognition-url ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordGetFacialRecognitionUrlV1Response> ExecuteOpenAppsICPRecordGetFacialRecognitionUrlV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordGetFacialRecognitionUrlV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "get_facial_recognition_url/")
                .SetQueryParam("province_code", request.ProvinceCode)
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordGetFacialRecognitionUrlV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/v1/icp_record/send_facial_recognition_notify/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/send-facial-recognition-notify ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordSendFacialRecognitionNotifyV1Response> ExecuteOpenAppsICPRecordSendFacialRecognitionNotifyV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordSendFacialRecognitionNotifyV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v1", "icp_record", "send_facial_recognition_notify/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordSendFacialRecognitionNotifyV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_facial_recognition_status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-facial-recognition-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryFacialRecognitionStatusV1Response> ExecuteOpenAppsICPRecordQueryFacialRecognitionStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryFacialRecognitionStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_facial_recognition_status/")
                .SetQueryParam("facial_recognition_token", request.FacialRecognitionToken)
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryFacialRecognitionStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_corp_type_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-corp-type-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryCorpTypeListV1Response> ExecuteOpenAppsICPRecordQueryCorpTypeListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryCorpTypeListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_corp_type_list/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryCorpTypeListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_region_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-region-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryRegionListV1Response> ExecuteOpenAppsICPRecordQueryRegionListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryRegionListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_region_list/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryRegionListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_incharge_people_credentials_type_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-incharge-people-credentials-type-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryInchargePeopleCredentialsTypeListV1Response> ExecuteOpenAppsICPRecordQueryInchargePeopleCredentialsTypeListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryInchargePeopleCredentialsTypeListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_incharge_people_credentials_type_list/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryInchargePeopleCredentialsTypeListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_service_content_type_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-service-content-type-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryServiceContentTypeListV1Response> ExecuteOpenAppsICPRecordQueryServiceContentTypeListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryServiceContentTypeListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_service_content_type_list/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryServiceContentTypeListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_pre_approval_item_type_list/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-pre-approval-item-type-list ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryPreApprovalItemTypeListV1Response> ExecuteOpenAppsICPRecordQueryPreApprovalItemTypeListV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryPreApprovalItemTypeListV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_pre_approval_item_type_list/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryPreApprovalItemTypeListV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apps/v1/icp_record/query_record_status/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/query-record-status ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordQueryRecordStatusV1Response> ExecuteOpenAppsICPRecordQueryRecordStatusV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordQueryRecordStatusV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apps", "v1", "icp_record", "query_record_status/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordQueryRecordStatusV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apps/v1/icp_record/submit_record_info/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/icp-record/submit-record-info ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenAppsICPRecordSubmitRecordInfoV1Response> ExecuteOpenAppsICPRecordSubmitRecordInfoV1Async(this DouyinMicroAppOpenApiClient client, Models.OpenAppsICPRecordSubmitRecordInfoV1Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apps", "v1", "icp_record", "submit_record_info/")
                .WithHeader("access-token", request.AuthorizerAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.OpenAppsICPRecordSubmitRecordInfoV1Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
