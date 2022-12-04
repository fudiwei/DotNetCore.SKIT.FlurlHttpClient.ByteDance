namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/card/delete 接口的响应。</para>
    /// </summary>
    public class EnterpriseIMCardDeleteResponse : DouyinOpenResponse<EnterpriseIMCardDeleteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
