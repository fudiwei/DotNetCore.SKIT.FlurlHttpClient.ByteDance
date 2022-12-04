namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/service_provider/sync 接口的响应。</para>
    /// </summary>
    public class POIServiceProviderSyncV2Response : DouyinOpenResponse<POIServiceProviderSyncV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
