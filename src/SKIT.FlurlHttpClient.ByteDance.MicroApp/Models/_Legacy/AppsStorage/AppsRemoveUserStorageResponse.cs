namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/remove_user_storage 接口的响应。</para>
    /// </summary>
    public class AppsRemoveUserStorageResponse : DouyinMicroAppResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorNumber == 0;
        }
    }
}
