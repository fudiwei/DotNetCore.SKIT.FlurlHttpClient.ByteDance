using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/fund/bills 接口的响应。</para>
    /// </summary>
    public class AppsFundBillsResponse : DouyinMicroAppResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
