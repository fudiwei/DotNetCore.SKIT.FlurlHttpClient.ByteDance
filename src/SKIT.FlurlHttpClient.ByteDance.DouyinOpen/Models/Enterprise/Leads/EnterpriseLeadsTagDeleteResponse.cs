using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/delete 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-05-31 下线。")]
    public class EnterpriseLeadsTagDeleteResponse : DouyinOpenResponse<EnterpriseLeadsTagDeleteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
