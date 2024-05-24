using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/qrcode 接口的响应。</para>
    /// </summary>
    public class AppsQrcodeResponse : DouyinMicroAppResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
