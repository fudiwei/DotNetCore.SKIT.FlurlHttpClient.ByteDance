namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/sku/sync 接口的响应。</para>
    /// </summary>
    public class POISKUSyncResponse : DouyinOpenResponse<POISKUSyncResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
