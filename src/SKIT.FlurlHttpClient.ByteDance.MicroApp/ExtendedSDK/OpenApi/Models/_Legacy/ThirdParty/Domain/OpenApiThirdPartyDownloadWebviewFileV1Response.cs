using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/download/webview_file 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyDownloadWebviewFileV1Response : OpenApiLegacyResponseBase
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
