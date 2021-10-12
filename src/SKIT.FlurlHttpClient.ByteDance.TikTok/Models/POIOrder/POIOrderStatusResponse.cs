namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/status 接口的响应。</para>
    /// </summary>
    public class POIOrderStatusResponse : TikTokResponse<POIOrderStatusResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
