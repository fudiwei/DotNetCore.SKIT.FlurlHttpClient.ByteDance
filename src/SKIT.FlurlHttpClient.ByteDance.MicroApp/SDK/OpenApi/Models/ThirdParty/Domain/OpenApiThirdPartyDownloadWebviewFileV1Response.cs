namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/download/webview_file 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyDownloadWebviewFileV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
