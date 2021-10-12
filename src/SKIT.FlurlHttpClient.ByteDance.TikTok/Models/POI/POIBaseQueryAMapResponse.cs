namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/base/query/amap 接口的响应。</para>
    /// </summary>
    public class POIBaseQueryAMapResponse : TikTokResponse<POIBaseQueryAMapResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : POIQueryResponse.Types.Data
            {
            }
        }
    }
}
