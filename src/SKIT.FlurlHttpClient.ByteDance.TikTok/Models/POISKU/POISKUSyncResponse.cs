namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/sku/sync 接口的响应。</para>
    /// </summary>
    public class POISKUSyncResponse : TikTokResponse<POISKUSyncResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
