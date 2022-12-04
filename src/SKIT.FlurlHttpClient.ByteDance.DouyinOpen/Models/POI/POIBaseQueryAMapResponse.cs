namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/base/query/amap 接口的响应。</para>
    /// </summary>
    public class POIBaseQueryAMapResponse : DouyinOpenResponse<POIBaseQueryAMapResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : POIQueryResponse.Types.Data
            {
            }
        }
    }
}
