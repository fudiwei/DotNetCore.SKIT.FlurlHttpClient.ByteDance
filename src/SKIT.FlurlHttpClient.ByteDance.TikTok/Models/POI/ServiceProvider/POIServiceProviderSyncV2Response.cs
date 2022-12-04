namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/service_provider/sync 接口的响应。</para>
    /// </summary>
    public class POIServiceProviderSyncV2Response : TikTokResponse<POIServiceProviderSyncV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
