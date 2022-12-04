namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/status 接口的响应。</para>
    /// </summary>
    public class POIOrderStatusResponse : DouyinOpenResponse<POIOrderStatusResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
