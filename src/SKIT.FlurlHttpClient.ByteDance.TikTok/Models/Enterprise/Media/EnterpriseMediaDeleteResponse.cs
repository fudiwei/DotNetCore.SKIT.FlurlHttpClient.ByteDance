namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/media/delete 接口的响应。</para>
    /// </summary>
    public class EnterpriseMediaDeleteResponse : TikTokResponse<EnterpriseMediaDeleteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
