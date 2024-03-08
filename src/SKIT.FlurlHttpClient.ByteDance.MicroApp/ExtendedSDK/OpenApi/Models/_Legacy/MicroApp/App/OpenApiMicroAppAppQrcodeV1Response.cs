using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/qrcode 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppAppQrcodeV1Response : OpenApiLegacyResponseBase
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
