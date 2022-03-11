using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    public static class OceanEngineClientExecuteFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /2/file/image/advertiser 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710599659532 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileImageAdvertiserResponse> ExecuteFileImageAdvertiserAsync(this OceanEngineClient client, Models.FileImageAdvertiserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileBytes != null)
            {
                if (request.ImageFileName == null)
                    request.ImageFileName = Guid.NewGuid().ToString("N").ToString().ToLower() + ".jpg";

                if (request.ImageFileHash == null)
                    request.ImageFileHash = BitConverter.ToString(Utilities.MD5Utility.Hash(request.ImageFileBytes)).Replace("-", "");

                if (request.ImageContentType == null)
                    request.ImageContentType = "image/jpeg";
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "file", "image", "advertiser")
                .WithHeader("Access-Token", request.AccessToken);

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(request.AdvertiserId.ToString()), "advertiser_id");
            httpContent.Add(new StringContent(request.UploadType), "upload_type");
            httpContent.Add(new StringContent(request.UploadTo), "upload_to");

            if (request.ImageFileBytes != null)
            {
                using var fileContent = new ByteArrayContent(request.ImageFileBytes);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.ImageContentType);
                httpContent.Add(fileContent, "image_file", request.ImageFileName!);
                httpContent.Add(new StringContent(request.ImageFileHash!), "image_signature");
            }
            else
            {
                httpContent.Add(new StringContent(request.ImageUrl!), "image_url");
            }

            return await client.SendRequestAsync<Models.FileImageAdvertiserResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/file/image/ad 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710600176640 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileImageAdvertisingResponse> ExecuteFileImageAdvertisingAsync(this OceanEngineClient client, Models.FileImageAdvertisingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ImageFileBytes != null)
            {
                if (request.ImageFileName == null)
                    request.ImageFileName = Guid.NewGuid().ToString("N").ToString().ToLower() + ".jpg";

                if (request.ImageFileHash == null)
                    request.ImageFileHash = BitConverter.ToString(Utilities.MD5Utility.Hash(request.ImageFileBytes)).Replace("-", "");

                if (request.ImageContentType == null)
                    request.ImageContentType = "image/jpeg";
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "file", "image", "ad")
                .WithHeader("Access-Token", request.AccessToken);

            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(request.AdvertiserId.ToString()), "advertiser_id");
            httpContent.Add(new StringContent(request.UploadType), "upload_type");
            httpContent.Add(new StringContent(request.ImageFileName!), "filename");

            if (request.ImageFileBytes != null)
            {
                using var fileContent = new ByteArrayContent(request.ImageFileBytes);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.ImageContentType);
                httpContent.Add(fileContent, "image_file", request.ImageFileName!);
                httpContent.Add(new StringContent(request.ImageFileHash!), "image_signature");
            }
            else
            {
                httpContent.Add(new StringContent(request.ImageUrl!), "image_url");
            }

            return await client.SendRequestAsync<Models.FileImageAdvertisingResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/file/video/ad 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710600730639 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileVideoAdvertisingResponse> ExecuteFileVideoAdvertisingAsync(this OceanEngineClient client, Models.FileVideoAdvertisingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.VideoFileName == null)
                request.VideoFileName = Guid.NewGuid().ToString("N").ToString().ToLower() + ".mp4";

            if (request.VideoFileHash == null)
                request.VideoFileHash = BitConverter.ToString(Utilities.MD5Utility.Hash(request.VideoFileBytes)).Replace("-", "");

            if (request.VideoContentType == null)
                request.VideoContentType = "video/mp4";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "file", "video", "ad")
                .WithHeader("Access-Token", request.AccessToken);

            using var httpContent = new MultipartFormDataContent();
            using var fileContent = new ByteArrayContent(request.VideoFileBytes ?? Array.Empty<byte>());
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.VideoContentType);
            httpContent.Add(fileContent, "video_file", request.VideoFileName);
            httpContent.Add(new StringContent(request.AdvertiserId.ToString()), "advertiser_id");
            httpContent.Add(new StringContent(request.VideoFileHash), "video_signature");
            httpContent.Add(new StringContent(request.VideoFileName), "filename");

            return await client.SendRequestAsync<Models.FileVideoAdvertisingResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/file/image/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710600730639 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileImageGetResponse> ExecuteFileImageGetAsync(this OceanEngineClient client, Models.FileImageGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "file", "image", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileImageGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/file/video/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710601820172 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileVideoGetResponse> ExecuteFileVideoGetAsync(this OceanEngineClient client, Models.FileVideoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "file", "video", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileVideoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/file/image/ad/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710600730639 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileImageAdvertiserGetResponse> ExecuteFileImageAdvertiserGetAsync(this OceanEngineClient client, Models.FileImageAdvertiserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "file", "image", "ad", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileImageAdvertiserGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /2/file/video/ad/get 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710603509772 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileVideoAdvertiserGetResponse> ExecuteFileVideoAdvertiserGetAsync(this OceanEngineClient client, Models.FileVideoAdvertiserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "2", "file", "video", "ad", "get")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileVideoAdvertiserGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/file/video/delete 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710605373455 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileVideoDeleteResponse> ExecuteFileVideoDeleteAsync(this OceanEngineClient client, Models.FileVideoDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "file", "video", "delete")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileVideoDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/file/video/update 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710605909004 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileVideoUpdateResponse> ExecuteFileVideoUpdateAsync(this OceanEngineClient client, Models.FileVideoUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "file", "video", "update")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileVideoUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /2/file/material/bind 接口。</para>
        /// <para>REF: https://open.oceanengine.com/doc/index.html?key=ad&type=api&id=1696710604852236 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileMaterialBindResponse> ExecuteFileMaterialBindAsync(this OceanEngineClient client, Models.FileMaterialBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "2", "file", "material", "bind")
                .WithHeader("Access-Token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FileMaterialBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
