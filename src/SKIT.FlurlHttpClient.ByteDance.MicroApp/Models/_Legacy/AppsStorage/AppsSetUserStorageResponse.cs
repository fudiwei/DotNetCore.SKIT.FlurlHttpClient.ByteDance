namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/set_user_storage 接口的响应。</para>
    /// </summary>
    public class AppsSetUserStorageResponse : DouyinMicroAppResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorNumber == 0;
        }
    }
}
