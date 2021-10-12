namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/card/delete 接口的响应。</para>
    /// </summary>
    public class EnterpriseIMCardDeleteResponse : TikTokResponse<EnterpriseIMCardDeleteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
